📍 Add-In Street View for ArcGIS Pro v3.0

A custom ArcGIS Pro Add-In that allows users to open Google Street View directly from a clicked feature on the map.
> 🎯 Developed using ArcGIS Pro SDK for .NET (v3.0) and Visual Studio 2022  
> 🗺️ Ideal for quick visual inspection of features with geographic coordinates.


🚀 Features
- Open **Google Street View** with a single click on a feature layer
- Supports **WGS 84 (UTM Zone 48S)** projection (customizable)
- Lightweight and fast integration with ArcGIS Pro
- Customizable tool name and UI using `Config.daml`


🛠 Requirements
- ArcGIS Pro 3.0
- Visual Studio 2022 with:
  - ArcGIS Pro SDK for .NET (v3.0)
  - .NET Framework 4.8
- Internet connection (to open Street View)


📦 Installation
1. Clone the repository:
   ```bash
   git clone github.com/frastiwiwidya/Add-In-Street-View-for-ArcGOS-Pro-v-3.0/Streetview/bin/Release/net6.0-windows/Streetview.esriAddinX
2. Open the solution (Streetview.sln) in Visual Studio 2022.
3. Build the project in Release mode.
4. The compiled .esriAddInX file will appear in the bin\Release folder.
5. Double-click the Add-In or install it via ArcGIS Pro → Add-In Manager.

🧪 How to Use
1. Open ArcGIS Pro and load a map with a feature layer (points recommended).
2. Activate the Street View Tool from the Add-In tab.
3. Click on any feature → Your default browser will open Google Street View for that location.

📍 Coordinate Note
Ensure your features are in the correct coordinate system (e.g., WGS 84 UTM Zone 48S) to ensure accurate Street View results. Coordinates are automatically projected to WGS84 (lat/lon) using ArcGIS SDK.


📄 License
This project is licensed under the Apache 2.0 License

🙋‍♀️ Author
Frastiwi Widya Azkiyya
🔗 LinkedIn : https://www.linkedin.com/in/frastiwiwidya/



