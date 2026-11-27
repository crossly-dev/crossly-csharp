#!/usr/bin/env bash
# Pack the four NuGet packages into dist/ (run from the repository root, after check-csharp.sh):
#   Crossly (seller), Crossly.Buyer, Crossly.Core (verifier, errors, pagination), Crossly.AspNetCore (middleware).
# All at the clients' version: -p:Version is global, so it also versions the Crossly.Core the clients reference.
set -euo pipefail
seller=$(ls seller/src/*/*.csproj | head -1)
buyer=$(ls buyer/src/*/*.csproj | head -1)
ver=$(sed -n 's:.*<Version>\(.*\)</Version>.*:\1:p' "$seller" | head -1)
extras=codegen/integrations/extras/csharp
mkdir -p dist
for p in "$seller" "$buyer" "$extras/Crossly.Core/Crossly.Core.csproj" "$extras/Crossly.AspNetCore/Crossly.AspNetCore.csproj"; do
  dotnet pack "$p" -c Release -nologo -v q -clp:ErrorsOnly -o dist "-p:Version=$ver"
done
ls -l dist
