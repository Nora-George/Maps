using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace MapGo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicacion",
                Address = "5 de Mayo, Tecamac,Edo.Mex",
                Position = new Position(19.7128800 , - 98.9689500),
                Tag = "id_miubi",
            };
            map.Pins.Add(MiUbi);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(500)));
        }
    }
}
