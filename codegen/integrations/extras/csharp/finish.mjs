#!/usr/bin/env node
/**
 * Finish one generated C# client so it packs for nuget.org and carries the vendored extras.
 *
 *   node codegen/integrations/extras/csharp/finish.mjs <seller|buyer dir>
 *
 * Run by codegen/ci/check-csharp.sh before every build. Idempotent. It does what the generator cannot be told to
 * (the shared generate-sdks.mjs passes only packageName/packageVersion):
 *
 *   1. Package metadata: the csharp-netcore 5.4.0 template writes PackageId = the namespace (net.crossly), Authors
 *      "OpenAPI", "No Copyright" and a GIT_USER_ID repository URL. The ids become Crossly / Crossly.Buyer, with
 *      the MIT licence expression and the project URL nuget.org shows.
 *   2. A ProjectReference to Crossly.Core (codegen/integrations/extras/csharp/Crossly.Core), which holds the webhook
 *      verifier, CrosslyException and CrosslyPages once for both clients; `dotnet pack` turns it into a package
 *      dependency on Crossly.Core of the same version.
 *   3. Vendored files (codegen/repo.json), copied again here so CI on an older committed tree checks the current
 *      extras.
 */
import { cpSync, existsSync, readdirSync, readFileSync, writeFileSync } from 'node:fs';
import { basename, dirname, join, relative, resolve, sep } from 'node:path';
import { fileURLToPath } from 'node:url';

const dir = resolve(process.argv[2] ?? '');
const side = basename(dir) === 'buyer' ? 'buyer' : 'seller';
const src = join(dir, 'src');
const project = existsSync(src)
  ? readdirSync(src)
      .map((d) => join(src, d, `${d}.csproj`))
      .find((p) => existsSync(p))
  : null;
if (!project) {
  console.error(`finish: no src/<name>/<name>.csproj in ${dir}`);
  process.exit(2);
}
const packageId = side === 'buyer' ? 'Crossly.Buyer' : 'Crossly';
const REPO = 'https://github.com/crossly-dev/crossly-csharp';

const CODEGEN = resolve(dirname(fileURLToPath(import.meta.url)), '..', '..', '..');
const ROOT = resolve(CODEGEN, '..');
const repoJson = join(CODEGEN, 'repo.json');
for (const v of existsSync(repoJson) ? JSON.parse(readFileSync(repoJson, 'utf8')).vendor ?? [] : []) {
  if (resolve(ROOT, v.to).startsWith(dir + sep)) cpSync(join(CODEGEN, 'integrations', v.from), resolve(ROOT, v.to));
}

let xml = readFileSync(project, 'utf8');
const before = xml;
const set = (tag, value) => {
  const re = new RegExp(`<${tag}>[^<]*</${tag}>`);
  if (re.test(xml)) xml = xml.replace(re, `<${tag}>${value}</${tag}>`);
  else xml = xml.replace('</PropertyGroup>', `  <${tag}>${value}</${tag}>\n  </PropertyGroup>`);
};
const what =
  side === 'buyer'
    ? 'buyer API (shopping: cart, orders, wishlists, offers)'
    : 'seller API (listings, crossposting, orders, analytics)';
set('PackageId', packageId);
set('Authors', 'Crossly');
set('Company', 'Crossly');
set('AssemblyTitle', `Crossly .NET SDK (${side})`);
set('Product', 'Crossly .NET SDK');
set(
  'Description',
  `Official .NET client for the Crossly ${what}, generated from the public OpenAPI spec, with retries, idempotency keys and typed errors. Webhook verification: Crossly.Core; ASP.NET Core middleware: Crossly.AspNetCore.`,
);
set('Copyright', 'Copyright (c) Crossly');
set('RepositoryUrl', `${REPO}.git`);
set('PackageReleaseNotes', `${REPO}/blob/main/CHANGELOG.md`);
set('PackageLicenseExpression', 'MIT');
set('PackageProjectUrl', REPO);
set('PackageTags', 'crossly;reselling;crosslisting;marketplace;sdk');
// Generated XML docs are incomplete by design; CS1591 alone is thousands of lines per build.
set('NoWarn', '$(NoWarn);CS1591');

const core = join(CODEGEN, 'integrations', 'extras', 'csharp', 'Crossly.Core', 'Crossly.Core.csproj');
const ref = relative(dirname(project), core).split(sep).join('/');
if (!xml.includes('Crossly.Core.csproj')) {
  xml = xml.replace(
    /<\/Project>\s*$/,
    `  <ItemGroup>\n    <!-- Webhook verifier, CrosslyException, CrosslyPages (one assembly for seller and buyer). -->\n    <ProjectReference Include="${ref}" />\n  </ItemGroup>\n\n</Project>\n`,
  );
}

if (xml !== before) writeFileSync(project, xml);

// 4. An anyOf parameter (e.g. listListings' `tag`: string | string[]) is emitted as `AnyOfstringarray`, a type the
//    5.4.0 template never generates. Every such undefined AnyOf* name becomes `string`: one value, which every
//    such parameter accepts.
const csFiles = [];
const walk = (d) => {
  for (const e of readdirSync(d, { withFileTypes: true })) {
    const p = join(d, e.name);
    if (e.isDirectory()) walk(p);
    else if (e.name.endsWith('.cs')) csFiles.push(p);
  }
};
walk(dirname(project));
const defined = new Set();
for (const f of csFiles) for (const m of readFileSync(f, 'utf8').matchAll(/\b(?:class|enum|struct)\s+(AnyOf\w+)/g)) defined.add(m[1]);
let anyOf = 0;
for (const f of csFiles) {
  const text = readFileSync(f, 'utf8');
  const next = text.replace(/\bAnyOf\w+\b/g, (name) => (defined.has(name) ? name : (anyOf++, 'string')));
  if (next !== text) writeFileSync(f, next);
}
console.log(
  `finish ${side}: ${packageId} (${relative(ROOT, project)}), csproj ${xml === before ? 'already finished' : 'updated'}, ${anyOf} AnyOf type(s) -> string`,
);
