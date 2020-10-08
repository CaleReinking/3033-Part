using Newtonsoft.Json;
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

namespace _P__JSON_Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string datasetURL = @"https://api.chucknorris.io/jokes/categories";

            Jokes.Joker jokes;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(datasetURL).Result;

                jokes = JsonConvert.DeserializeObject<Jokes.Joker>(json);
            }

            foreach (var item in jokes.results)
            {
                cboJokes.Items.Add(item);
            }
        }
    }
}
