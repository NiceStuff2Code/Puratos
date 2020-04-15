using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Puratos_UI.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //methode to initalise the Xamarin.Forms.Maps library for UWP
            Xamarin.FormsMaps.Init("ZFXK30mtfx07CUrgz2eV~I47UbjRvkThUA-ovorGFgw~AmcdnacYFcAhCkpiSYd7q2ARrHjgqYA7WUYFYWmAe1NVrurb0IpuToYKT3KvaXYX");
            LoadApplication(new Puratos_UI.App());
        }
    }
}
