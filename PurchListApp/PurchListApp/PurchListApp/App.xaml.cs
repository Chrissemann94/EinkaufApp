using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PurchListApp
{
    public partial class App : Application
    {
        public static Theme AppTheme { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }

    public enum Theme
    {
        Light,
        Dark
    }
}

