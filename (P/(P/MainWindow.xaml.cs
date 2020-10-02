// Cale J Reinking
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string webService = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=2000";

            Characters.Theory funniest;
            using (var client = new HttpClient())
            {
                var result = client.GetStringAsync(webService).Result;

                funniest = JsonConvert.DeserializeObject<Characters.Theory>(result);
            }

            foreach (var funny in funniest.results)
            {
                cboCharacters.Items.Add(funny);
            }
        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Characters.Funny selectedPokemon = (Characters.Funny)cboCharacters.SelectedItem;

            Characters.Loser pokemonurl;

            using (var client = new HttpClient())
            {
                string pokemonUrl = selectedPokemon.url;
                string json = client.GetStringAsync(pokemonUrl).Result;
                pokemonurl = JsonConvert.DeserializeObject<Characters.Loser>(json);
            }
            lstSpecs.Items.Add(pokemonurl);

           var uri = new Uri(selectedPokemon.image);
          var img = new BitmapImage(uri);
          imgCharacter.Source = img;
          
        }
    }
}
