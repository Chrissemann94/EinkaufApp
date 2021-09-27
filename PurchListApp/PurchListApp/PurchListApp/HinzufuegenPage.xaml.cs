using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PurchListApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HinzufuegenPage : ContentPage
    {
        public HinzufuegenPage()
        {

            InitializeComponent();

        }

        async private void CreateArtikelButton_Clicked(object sender, EventArgs e)
        {


            PurchListApp.ArtikelListePage.artikelListe.Add(new Artikel()
            {
                Id = PurchListApp.ArtikelListePage.artikelListe.Count(),
                Name = EntryName.Text,
                Beschreibung = EntryBesch.Text,
                ImgLink = EntryImageLink.Text
            });
            string JsonString = JsonConvert.SerializeObject(ArtikelListePage.artikelListe);
            //Speichert im Arbeitsspeicher


            await Application.Current.SavePropertiesAsync();
            await Navigation.PopToRootAsync();
        }
    }
}