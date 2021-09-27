using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PurchListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public static ObservableCollection<Artikel> artikelListeEinkaufsliste = new ObservableCollection<Artikel>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_To_Einkaufsliste(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EinkaufsListePage());

        }
        private void Button_Clicked_To_Produktliste(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtikelListePage());
        }


        public void Handle_ModeChange(object sender, EventArgs e)
        {
            Theme themeRequested = App.AppTheme == Theme.Light ? Theme.Dark : Theme.Light;
            MessagingCenter.Send(this, "ModeChanged", themeRequested);
            SetIcon();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SetIcon();
        }

        void SetIcon()
        {
            if (App.AppTheme == Theme.Light)
            {
                ModeMenuItem.IconImageSource = "moon.png";
            }
            else
            {

                ModeMenuItem.IconImageSource = "sun.png";
            }
        }
    }
}
