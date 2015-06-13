using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UsandoXamarinMaps.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.FormsMaps.Init("7f98e64e-db5c-4573-a85f-fdc38353ff49", "4HUT7fOFwP_gHoQMkztuPQ");
            LoadApplication(new UsandoXamarinMaps.App());
        }
    }
}
