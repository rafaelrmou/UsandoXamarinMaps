using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace UsandoXamarinMaps
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //var Mapa = new Map();
            //Mapa.IsShowingUser = true;
            //Mapa.Pins.Add(
            //                new Pin()
            //                {
            //                    Position = new Position(-19.937053, -43.966040),
            //                    Label = "Pin Novo",
            //                    Type = PinType.Place,
            //                    Address = "Pin Novo"
            //                }
            //            );
            MainPage = new XamarinMaps();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
