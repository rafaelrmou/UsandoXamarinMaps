using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace UsandoXamarinMaps
{
    public partial class XamarinMaps : ContentPage
    {
        public XamarinMaps()
        {
            InitializeComponent();

            MeuMapa.Pins.Add(
                            new Pin()
                            {
                                Position = new Position(-19.937053, -43.966040),
                                Label = "Pin Novo",
                                Type = PinType.Place,
                                Address = "Endereço"
                            }
                        );
        }
    }
}
