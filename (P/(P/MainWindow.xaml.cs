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

            Characters funniest;
            using (var client = new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;

                funniest = JsonConvert.DeserializeObject<Characters>(results);
            }

            foreach (var funny in funniest.results)
            {
                cboCharacters.Items.Add(funny);
            }
        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var funny = (Funny)cboCharacters.SelectedItem;
            Info information;
            using (var client = new HttpClient())
            {
                var output = client.GetStringAsync(funny.url);

                information = JsonConvert.DeserializeObject<Info>(output);
            }
            foreach (var info in information)
            {
                cboCharacters.Items.Add(info);
            }
            var uri = new Uri(funny.image);
            var img = new BitmapImage(uri);
        }
    }
}
