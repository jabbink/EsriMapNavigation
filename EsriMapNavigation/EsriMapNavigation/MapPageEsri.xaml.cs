using Esri.ArcGISRuntime.Mapping;
using Xamarin.Forms;

namespace EsriMapNavigation
{
    public partial class MapPageEsri : ContentPage
    {
        public MapPageEsri()
        {
            InitializeComponent();

            this.MyMapView.Map = new Map(BasemapStyle.ArcGISNavigation);
        }
    }
}
