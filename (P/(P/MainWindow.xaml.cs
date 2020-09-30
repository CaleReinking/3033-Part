using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

            //HttpClient client = new HttpClient();
            Characters characters;
            using (var client = new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;

                characters = JsonConvert.DeserializeObject<Characters>(results);
            }

            foreach (var character in characters.results)
            {
                cboCharacters.Items.Add(character);
            }
        }
    }
}
