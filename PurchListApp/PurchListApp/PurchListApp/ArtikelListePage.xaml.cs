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
    public partial class ArtikelListePage : ContentPage
    {

        public static ObservableCollection<Artikel> artikelListe = new ObservableCollection<Artikel>()
        {
            new Artikel()
            {
                Id = 1,
                Name = "Apfel",
                Beschreibung = "50 kcal",
                 ImgLink = "Product1.jpg"

            },

            new Artikel()
            {
                Id = 2,
                Name = "Birne",
                Beschreibung = "50 kcal",
                ImgLink = "Product2.jpg"
            },

             new Artikel()
            {
                Id = 3,
                Name = "Banane",
                Beschreibung = "70 kcal",
                 ImgLink = "Product3.jpg"
            },

              new Artikel()
            {
                Id = 4,
                Name = "Kiwi",
                Beschreibung = "40 kcal",
                  ImgLink = "Product4.jpg"
            },

                 new Artikel()
            {
                Id = 5,
                Name = "Wassermelone",
                Beschreibung = "20 kcal",
                  ImgLink = "Product5.jpg"
            }
        };

        public ArtikelListePage()
        {
            InitializeComponent();
            ProduktListView.ItemsSource = artikelListe;
        }


        private void ProduktListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem == null) return;



            var m = ((Artikel)e.SelectedItem);



            if (PurchListApp.MainPage.artikelListeEinkaufsliste.Contains(m))
            {
                m.Count = m.Count + 1;
            }
            else
            {
                PurchListApp.MainPage.artikelListeEinkaufsliste.Add((Artikel)m);
            }
            DisplayAlert(m.Name, $"wurde der Einkaufsliste hinzugefügt!", "Ok");
            ((ListView)sender).SelectedItem = null;
        }

        private void Button_Clicked_To_Hinzufuegen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HinzufuegenPage());
        }
    }
}