# Esri map with navigation crash example

Simple Xamarin Forms app created from the VS template demonstrating a bug with the Esri ArcGIS Xamarin Forms component

## Reproduction steps

1. Insert valid License/API keys for Esri ArcGIS in [MainActivity.cs](EsriMapNavigation/EsriMapNavigation.Android/MainActivity.cs)
and optionally (for comparison with a map component that does not crash) a Google Maps API key in [AndroidManifest.xml](EsriMapNavigation/EsriMapNavigation.Android/Properties/AndroidManifest.xml)

2. Create an Android Emulator on Android 9 (API 28), x86_64, 1GB memory  
  Alternatively an older actual Android device might show the same symptoms; reproduced on Samsung Galaxy S7

3. Click the top button (mentioning Esri), and the back button repeatedly; after about 10 back-and-forths the app becomes noticeably slower; 10-20 more and the app gets killed
