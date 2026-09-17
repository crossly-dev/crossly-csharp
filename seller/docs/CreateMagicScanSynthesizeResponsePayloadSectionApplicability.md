# net.crossly.Model.CreateMagicScanSynthesizeResponsePayloadSectionApplicability
Deterministic (NO-AI) applicability hint for the heavyweight optional  form sections (vehicle compatibility, EU EPR / energy label, hazmat).  Computed from the resolved category + seller region via  `applicableOptionalSections`; the form pre-checks each section's  \"this item needs …\" toggle from it. Additive + best-effort.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VehicleCompat** | **bool** | eBay Motors / Parts vehicle-fitment (compatibilityList). | 
**Epr** | **bool** | EU/UK Extended Producer Responsibility (packaging/e-waste schemes). | 
**EnergyLabel** | **bool** | EU energy-efficiency label (fridges, TVs, lighting, appliances). | 
**Hazmat** | **bool** | Hazmat classification (battery/aerosol/flammable/liquid/chemical). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

