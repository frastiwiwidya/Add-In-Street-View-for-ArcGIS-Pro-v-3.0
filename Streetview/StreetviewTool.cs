using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping;
using ArcGIS.Core.Geometry;
using ArcGIS.Core.CIM;
using System.Diagnostics;
using System.Threading.Tasks;
using ArcGIS.Desktop.Editing;

namespace Streetview
{
    internal class StreetviewTool : MapTool
    {
        public StreetviewTool()
        {
            IsSketchTool = true; // Aktifkan mode sketch
            SketchType = SketchGeometryType.Point; // Hanya menerima titik
            SketchOutputMode = SketchOutputMode.Map; // Output titik di peta
        }

        protected override Task<bool> OnSketchCompleteAsync(Geometry geometry)
        {
            if (geometry is MapPoint mapPoint)
            {
                // Ambil koordinat dari MapPoint dalam sistem koordinat peta
                double x = mapPoint.X;
                double y = mapPoint.Y;

                // Periksa dan konversi koordinat jika sistem koordinat bukan WGS 84
                if (mapPoint.SpatialReference != SpatialReferences.WGS84)
                {
                    // Gunakan GeometryEngine untuk konversi koordinat ke WGS 84
                    mapPoint = GeometryEngine.Instance.Project(mapPoint, SpatialReferences.WGS84) as MapPoint;
                }

                // Ambil latitude dan longitude setelah konversi
                double lat = mapPoint.Y; // Latitude
                double lon = mapPoint.X; // Longitude

                // Debugging: Output koordinat ke jendela debug
                System.Diagnostics.Debug.WriteLine($"Latitude: {lat}, Longitude: {lon}");

                // Membentuk URL untuk Street View menggunakan koordinat
                string url = $"https://www.google.com/maps/@?api=1&map_action=pano&viewpoint={lat},{lon}";

                // Membuka URL di browser default
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }

            return base.OnSketchCompleteAsync(geometry);
        }
    }
}
