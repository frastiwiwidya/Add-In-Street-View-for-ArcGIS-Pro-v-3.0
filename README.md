# 📍 Add-In: Street View for ArcGIS Pro v3.0

A custom ArcGIS Pro Add-In that allows users to open **Google Street View** directly from a clicked feature on the map.

> 🎯 Developed using **ArcGIS Pro SDK for .NET (v3.0)** and **Visual Studio 2022**  
> 🗺️ Ideal for quick visual inspection of geographic features.

---

## 🚀 Features

- Open **Google Street View** with a single click on a feature layer  
- Lightweight and fast integration with ArcGIS Pro  
- Customizable tool name and UI via `Config.daml`

---

## 📥 Quick Download & Installation

> No need to build from source — just download and install the Add-In directly:

🔗 **[Download Streetview.esriAddinX](https://github.com/frastiwiwidya/Add-In-Street-View-for-ArcGIS-Pro-v-3.0/blob/main/release/Streetview.esriAddinX?raw=true)**

### 🛠️ Installation Steps

1. Double-click the `Streetview.esriAddinX` file  
2. Or open ArcGIS Pro → `Add-In Manager` → `Options` → Add the Add-In manually

---

## 💻 For Developers (Build from Source)

If you want to build the Add-In manually from the source code:

### 🔧 Steps
1. Clone the repository
```bash
git clone https://github.com/frastiwiwidya/Add-In-Street-View-for-ArcGIS-Pro-v-3.0.git
```
2. Open the solution (Streetview.sln) in Visual Studio 2022.
3. Build the project in Release mode.
4. The compiled .esriAddInX file will appear in the bin\Release folder.
5. Double-click the Add-In or install it via ArcGIS Pro → Add-In Manager.

## 🛠 Requirements
- ArcGIS Pro 3.0
- Visual Studio 2022 with:
  - ArcGIS Pro SDK for .NET (v3.0)
  - .NET Framework 4.8
- Internet connection (to open Street View)


## 🧪 How to Use
1. Open ArcGIS Pro and load a map with a feature layer (points recommended).
2. Activate the Street View Tool from the Add-In tab.
3. Click on any feature → Your default browser will open Google Street View for that location.

##📍 Coordinate Note
Ensure your features are in the correct coordinate system (e.g., WGS 84 UTM Zone 48S) to ensure accurate Street View results. Coordinates are automatically projected to WGS84 (lat/lon) using ArcGIS SDK.


##📄 License
This project is licensed under the Apache 2.0 License

🙋‍♀️ Author
Frastiwi Widya Azkiyya
🔗 LinkedIn : https://www.linkedin.com/in/frastiwiwidya/



