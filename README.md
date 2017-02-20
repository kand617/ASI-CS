# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (ASI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the ASI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

### 3. Add reference of the library project

In order to use the ASI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` ASI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```ASI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=ASI-CSharp&workspaceName=ASI&projectName=ASI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

ASIClient client = new ASIClient();
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ASIESPLookupsInfantToddlerController](#asiesp_lookups_infant_toddler_controller)
* [ASIESPLookupsPantsController](#asiesp_lookups_pants_controller)
* [ASIESPLookupsController](#asiesp_lookups_controller)
* [ASIESPLookupsCategoriesController](#asiesp_lookups_categories_controller)
* [ASIESPCarrierController](#asiesp_carrier_controller)
* [ASIESPLookupsColorsController](#asiesp_lookups_colors_controller)
* [ASIESPLookupsMaterialsController](#asiesp_lookups_materials_controller)
* [ASIESPLookupsBraController](#asiesp_lookups_bra_controller)
* [ASIESPLookupsDressShirtDressShirtController](#asiesp_lookups_dress_shirt_dress_shirt_controller)
* [ASIESPLookupsHoiseryController](#asiesp_lookups_hoisery_controller)
* [ASIESPLookupsSafetyWarningController](#asiesp_lookups_safety_warning_controller)
* [ASIESPLookupsReservedRestrictedController](#asiesp_lookups_reserved_restricted_controller)
* [ASIESPUpchargeLevelsController](#asiesp_upcharge_levels_controller)
* [MiscLoginController](#misc_login_controller)
* [MiscController](#misc_controller)

### <a name="asiesp_lookups_infant_toddler_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsInfantToddlerController") ASIESPLookupsInfantToddlerController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsInfantToddlerController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsInfantToddlerController aSIESPLookupsInfantToddler = client.ASIESPLookupsInfantToddler;
```

#### <a name="get_infant_toddler"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsInfantToddlerController.GetInfantToddler") GetInfantToddler

> *Tags:*  ``` Skips Authentication ``` 

> Infant Toddler


```csharp
Task GetInfantToddler()
```

#### Example Usage

```csharp

await aSIESPLookupsInfantToddler.GetInfantToddler();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_pants_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsPantsController") ASIESPLookupsPantsController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsPantsController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsPantsController aSIESPLookupsPants = client.ASIESPLookupsPants;
```

#### <a name="get_apparel_pants"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsPantsController.GetApparelPants") GetApparelPants

> *Tags:*  ``` Skips Authentication ``` 

> pants


```csharp
Task GetApparelPants()
```

#### Example Usage

```csharp

await aSIESPLookupsPants.GetApparelPants();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsController") ASIESPLookupsController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsController aSIESPLookups = client.ASIESPLookups;
```

#### <a name="get_standard_numbered"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetStandardNumbered") GetStandardNumbered

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetStandardNumbered()
```

#### Example Usage

```csharp

await aSIESPLookups.GetStandardNumbered();

```


#### <a name="get_volume_weight"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetVolumeWeight") GetVolumeWeight

> *Tags:*  ``` Skips Authentication ``` 

> Volume Weight


```csharp
Task GetVolumeWeight()
```

#### Example Usage

```csharp

await aSIESPLookups.GetVolumeWeight();

```


#### <a name="get_capacity"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetCapacity") GetCapacity

> *Tags:*  ``` Skips Authentication ``` 

> Capacity


```csharp
Task GetCapacity()
```

#### Example Usage

```csharp

await aSIESPLookups.GetCapacity();

```


#### <a name="get_other"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetOther") GetOther

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetOther()
```

#### Example Usage

```csharp

await aSIESPLookups.GetOther();

```


#### <a name="get_dimension"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetDimension") GetDimension

> *Tags:*  ``` Skips Authentication ``` 

> Dimension


```csharp
Task GetDimension()
```

#### Example Usage

```csharp

await aSIESPLookups.GetDimension();

```


#### <a name="get_shapes"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetShapes") GetShapes

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the Shape(s) of the product


```csharp
Task GetShapes()
```

#### Example Usage

```csharp

await aSIESPLookups.GetShapes();

```


#### <a name="get_themes1"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetThemes1") GetThemes1

> *Tags:*  ``` Skips Authentication ``` 

> Used to assign Themes to the product


```csharp
Task GetThemes1()
```

#### Example Usage

```csharp

await aSIESPLookups.GetThemes1();

```


#### <a name="get_packages"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetPackages") GetPackages

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetPackages()
```

#### Example Usage

```csharp

await aSIESPLookups.GetPackages();

```


#### <a name="get_compliances"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetCompliances") GetCompliances

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetCompliances()
```

#### Example Usage

```csharp

await aSIESPLookups.GetCompliances();

```


#### <a name="get_warranty"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetWarranty") GetWarranty

> *Tags:*  ``` Skips Authentication ``` 

> Specifies warranty availability, warranty length, warranty parts, warranty type


```csharp
Task GetWarranty()
```

#### Example Usage

```csharp

await aSIESPLookups.GetWarranty();

```


#### <a name="get_battery"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetBattery") GetBattery

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetBattery()
```

#### Example Usage

```csharp

await aSIESPLookups.GetBattery();

```


#### <a name="get_item_weight"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetItemWeight") GetItemWeight

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the weight of a single item.


```csharp
Task GetItemWeight()
```

#### Example Usage

```csharp

await aSIESPLookups.GetItemWeight();

```


#### <a name="get_shipping_weight"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetShippingWeight") GetShippingWeight

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetShippingWeight()
```

#### Example Usage

```csharp

await aSIESPLookups.GetShippingWeight();

```


#### <a name="get_availability_criterias"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetAvailabilityCriterias") GetAvailabilityCriterias

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetAvailabilityCriterias()
```

#### Example Usage

```csharp

await aSIESPLookups.GetAvailabilityCriterias();

```


#### <a name="get_upcharge_types"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetUpchargeTypes") GetUpchargeTypes

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetUpchargeTypes()
```

#### Example Usage

```csharp

await aSIESPLookups.GetUpchargeTypes();

```


#### <a name="get_discount_rates"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetDiscountRates") GetDiscountRates

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetDiscountRates()
```

#### Example Usage

```csharp

await aSIESPLookups.GetDiscountRates();

```


#### <a name="get_currencies"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetCurrencies") GetCurrencies

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetCurrencies()
```

#### Example Usage

```csharp

await aSIESPLookups.GetCurrencies();

```


#### <a name="get_price_modifiers"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetPriceModifiers") GetPriceModifiers

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetPriceModifiers()
```

#### Example Usage

```csharp

await aSIESPLookups.GetPriceModifiers();

```


#### <a name="get_selected_line_names"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetSelectedLineNames") GetSelectedLineNames

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetSelectedLineNames()
```

#### Example Usage

```csharp

await aSIESPLookups.GetSelectedLineNames();

```


#### <a name="get_fob_points"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetFOBPoints") GetFOBPoints

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetFOBPoints()
```

#### Example Usage

```csharp

await aSIESPLookups.GetFOBPoints();

```


#### <a name="get_origins"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetOrigins") GetOrigins

> *Tags:*  ``` Skips Authentication ``` 

> Country where product is made


```csharp
Task GetOrigins()
```

#### Example Usage

```csharp

await aSIESPLookups.GetOrigins();

```


#### <a name="get_imprint_methods"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetImprintMethods") GetImprintMethods

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the various methods that the supplier provides for imprinting the product


```csharp
Task GetImprintMethods()
```

#### Example Usage

```csharp

await aSIESPLookups.GetImprintMethods();

```


#### <a name="get_personalization"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetPersonalization") GetPersonalization

> *Tags:*  ``` Skips Authentication ``` 

> Criteria set for describing Personalization of the product


```csharp
Task GetPersonalization()
```

#### Example Usage

```csharp

await aSIESPLookups.GetPersonalization();

```


#### <a name="get_artworks"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetArtworks") GetArtworks

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetArtworks()
```

#### Example Usage

```csharp

await aSIESPLookups.GetArtworks();

```


#### <a name="get_criteria_codes"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetCriteriaCodes") GetCriteriaCodes

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetCriteriaCodes()
```

#### Example Usage

```csharp

await aSIESPLookups.GetCriteriaCodes();

```


#### <a name="get_base_price_criterias"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetBasePriceCriterias") GetBasePriceCriterias

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetBasePriceCriterias()
```

#### Example Usage

```csharp

await aSIESPLookups.GetBasePriceCriterias();

```


#### <a name="get_upcharge_criterias"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetUpchargeCriterias") GetUpchargeCriterias

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetUpchargeCriterias()
```

#### Example Usage

```csharp

await aSIESPLookups.GetUpchargeCriterias();

```


#### <a name="get_product_number_criterias"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetProductNumberCriterias") GetProductNumberCriterias

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetProductNumberCriterias()
```

#### Example Usage

```csharp

await aSIESPLookups.GetProductNumberCriterias();

```


#### <a name="get_shipping_dimension"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetShippingDimension") GetShippingDimension

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetShippingDimension()
```

#### Example Usage

```csharp

await aSIESPLookups.GetShippingDimension();

```


#### <a name="get_shipping_estimate"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetShippingEstimate") GetShippingEstimate

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the info used by the distributor to calculate shipping costs


```csharp
Task GetShippingEstimate()
```

#### Example Usage

```csharp

await aSIESPLookups.GetShippingEstimate();

```


#### <a name="get_media_ciatations"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsController.GetMediaCiatations") GetMediaCiatations

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetMediaCiatations()
```

#### Example Usage

```csharp

await aSIESPLookups.GetMediaCiatations();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_categories_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsCategoriesController") ASIESPLookupsCategoriesController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsCategoriesController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsCategoriesController aSIESPLookupsCategories = client.ASIESPLookupsCategories;
```

#### <a name="get_categories_list"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsCategoriesController.GetCategoriesList") GetCategoriesList

> *Tags:*  ``` Skips Authentication ``` 

> These are the ASI Categories that are attached to the product.


```csharp
Task GetCategoriesList()
```

#### Example Usage

```csharp

await aSIESPLookupsCategories.GetCategoriesList();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPCarrierController") ASIESPCarrierController

#### Get singleton instance

The singleton instance of the ``` ASIESPCarrierController ``` class can be accessed from the API Client.

```csharp
ASIESPCarrierController aSIESPCarrier = client.ASIESPCarrier;
```

#### <a name="get_carrier"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPCarrierController.GetCarrier") GetCarrier

> *Tags:*  ``` Skips Authentication ``` 

> Carrier


```csharp
Task GetCarrier()
```

#### Example Usage

```csharp

await aSIESPCarrier.GetCarrier();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_colors_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsColorsController") ASIESPLookupsColorsController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsColorsController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsColorsController aSIESPLookupsColors = client.ASIESPLookupsColors;
```

#### <a name="get_colors"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsColorsController.GetColors") GetColors

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the Color values for the product


```csharp
Task GetColors()
```

#### Example Usage

```csharp

await aSIESPLookupsColors.GetColors();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_materials_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsMaterialsController") ASIESPLookupsMaterialsController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsMaterialsController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsMaterialsController aSIESPLookupsMaterials = client.ASIESPLookupsMaterials;
```

#### <a name="get_materials"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsMaterialsController.GetMaterials") GetMaterials

> *Tags:*  ``` Skips Authentication ``` 

> Specifies the Material(s) that the product is made of.


```csharp
Task GetMaterials()
```

#### Example Usage

```csharp

await aSIESPLookupsMaterials.GetMaterials();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_bra_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsBraController") ASIESPLookupsBraController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsBraController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsBraController aSIESPLookupsBra = client.ASIESPLookupsBra;
```

#### <a name="get_apparel_bra"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsBraController.GetApparelBra") GetApparelBra

> *Tags:*  ``` Skips Authentication ``` 

> bra


```csharp
Task GetApparelBra()
```

#### Example Usage

```csharp

await aSIESPLookupsBra.GetApparelBra();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_dress_shirt_dress_shirt_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsDressShirtDressShirtController") ASIESPLookupsDressShirtDressShirtController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsDressShirtDressShirtController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsDressShirtDressShirtController aSIESPLookupsDressShirtDressShirt = client.ASIESPLookupsDressShirtDressShirt;
```

#### <a name="get_dress_shirt"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsDressShirtDressShirtController.GetDressShirt") GetDressShirt

> *Tags:*  ``` Skips Authentication ``` 

> Dress Shirt


```csharp
Task GetDressShirt()
```

#### Example Usage

```csharp

await aSIESPLookupsDressShirtDressShirt.GetDressShirt();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_hoisery_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsHoiseryController") ASIESPLookupsHoiseryController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsHoiseryController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsHoiseryController aSIESPLookupsHoisery = client.ASIESPLookupsHoisery;
```

#### <a name="get_hoisery_uniform"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsHoiseryController.GetHoiseryUniform") GetHoiseryUniform

> *Tags:*  ``` Skips Authentication ``` 

> Hoisery


```csharp
Task GetHoiseryUniform()
```

#### Example Usage

```csharp

await aSIESPLookupsHoisery.GetHoiseryUniform();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_safety_warning_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsSafetyWarningController") ASIESPLookupsSafetyWarningController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsSafetyWarningController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsSafetyWarningController aSIESPLookupsSafetyWarning = client.ASIESPLookupsSafetyWarning;
```

#### <a name="get_safety_warnings"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsSafetyWarningController.GetSafetyWarnings") GetSafetyWarnings

> *Tags:*  ``` Skips Authentication ``` 

> Safety warnings that may apply to the product Images These are the product images


```csharp
Task GetSafetyWarnings()
```

#### Example Usage

```csharp

await aSIESPLookupsSafetyWarning.GetSafetyWarnings();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_lookups_reserved_restricted_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPLookupsReservedRestrictedController") ASIESPLookupsReservedRestrictedController

#### Get singleton instance

The singleton instance of the ``` ASIESPLookupsReservedRestrictedController ``` class can be accessed from the API Client.

```csharp
ASIESPLookupsReservedRestrictedController aSIESPLookupsReservedRestricted = client.ASIESPLookupsReservedRestricted;
```

#### <a name="get_reserved"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPLookupsReservedRestrictedController.GetReserved") GetReserved

> *Tags:*  ``` Skips Authentication ``` 

> Reserved or Restricted word lookup


```csharp
Task GetReserved()
```

#### Example Usage

```csharp

await aSIESPLookupsReservedRestricted.GetReserved();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="asiesp_upcharge_levels_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.ASIESPUpchargeLevelsController") ASIESPUpchargeLevelsController

#### Get singleton instance

The singleton instance of the ``` ASIESPUpchargeLevelsController ``` class can be accessed from the API Client.

```csharp
ASIESPUpchargeLevelsController aSIESPUpchargeLevels = client.ASIESPUpchargeLevels;
```

#### <a name="get_upcharge_levels"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.ASIESPUpchargeLevelsController.GetUpchargeLevels") GetUpchargeLevels

> *Tags:*  ``` Skips Authentication ``` 

> Upcharge Levels


```csharp
Task GetUpchargeLevels()
```

#### Example Usage

```csharp

await aSIESPUpchargeLevels.GetUpchargeLevels();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="misc_login_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.MiscLoginController") MiscLoginController

#### Get singleton instance

The singleton instance of the ``` MiscLoginController ``` class can be accessed from the API Client.

```csharp
MiscLoginController miscLogin = client.MiscLogin;
```

#### <a name="create_asi_login_post_to_get_token"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.MiscLoginController.CreateAsiLoginPostToGetToken") CreateAsiLoginPostToGetToken

> *Tags:*  ``` Skips Authentication ``` 

> Login to get auth token


```csharp
Task CreateAsiLoginPostToGetToken()
```

#### Example Usage

```csharp

await miscLogin.CreateAsiLoginPostToGetToken();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="misc_controller"></a>![Class: ](https://apidocs.io/img/class.png "ASI.PCL.Controllers.MiscController") MiscController

#### Get singleton instance

The singleton instance of the ``` MiscController ``` class can be accessed from the API Client.

```csharp
MiscController misc = client.Misc;
```

#### <a name="get_trade_names"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.MiscController.GetTradeNames") GetTradeNames

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task GetTradeNames(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string q = "cab";

await misc.GetTradeNames(q);

```


#### <a name="getasi_product"></a>![Method: ](https://apidocs.io/img/method.png "ASI.PCL.Controllers.MiscController.GETASIProduct") GETASIProduct

> *Tags:*  ``` Skips Authentication ``` 

> Brand names associated with the product 573-5613789


```csharp
Task GETASIProduct(string authToken, string xid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| authToken |  ``` Required ```  | TODO: Add a parameter description |
| xid |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string authToken = "AuthToken";
string xid = "573-5613789";

await misc.GETASIProduct(authToken, xid);

```


[Back to List of Controllers](#list_of_controllers)



