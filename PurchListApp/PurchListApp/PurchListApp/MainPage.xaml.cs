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
       


        // Dark and Lightmode
        // void Switch_ChangeMode(object sender, EventArgs e)
        // {
        //     if (ModeSwitch.IsToggled == true)
        //     {
        //         Content.BackgroundColor = Color.Black;
        //         Titel.BackgroundColor = Color.DarkOrange;
        //         Titel.TextColor = Color.Black;              
        //     }
        //     else
        //     {
        //         Content.BackgroundColor = Color.White;
        //         Titel.BackgroundColor = Color.Black;
        //         Titel.TextColor = Color.White;
        //     }
        // }
    }
}
