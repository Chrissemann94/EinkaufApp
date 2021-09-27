using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PurchListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EinkaufsListePage : ContentPage
    {

        public EinkaufsListePage()
        {
            InitializeComponent();
            EinkaufsListView.ItemsSource = MainPage.artikelListeEinkaufsliste;
        }

        private void EinkaufsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var m = MainPage.artikelListeEinkaufsliste.Where(x => e.SelectedItem.Equals(x)).FirstOrDefault();
            m.Count = 1;
            MainPage.artikelListeEinkaufsliste.Remove(m);
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
        //         Titel.BackgroundColor = Color.LightGreen;
        //         Titel.TextColor = Color.Black;
        //     }
        // }
    }
}