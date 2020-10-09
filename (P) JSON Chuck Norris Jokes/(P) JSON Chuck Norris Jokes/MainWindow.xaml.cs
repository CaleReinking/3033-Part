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
            

            string[] jokeCategories;

            using (var client = new HttpClient())
            {
                string datasetURL = @"https://api.chucknorris.io/jokes/categories";
                string json = client.GetStringAsync(datasetURL).Result;

                jokeCategories = JsonConvert.DeserializeObject<string[]>(json);
            }
            cboJokes.Items.Add("All");
            foreach (var item in jokeCategories)
            {
                cboJokes.Items.Add(item);
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var selectCat = cboJokes.SelectedItem;
            string categoryURL;
            if (selectCat.ToString() == "All")
            {
                categoryURL = "https://api.chucknorris.io/jokes/random";
            }
            else
            {
                categoryURL = "https://api.chucknorris.io/jokes/random?category=" + selectCat;
            }

            Jokes jokes;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(categoryURL).Result;
                jokes = JsonConvert.DeserializeObject<Jokes>(json);
            }
            string joke = jokes.ToString();
            MessageBox.Show(joke);
        }
    }
}
