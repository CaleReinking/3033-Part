using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _2__P__WPF__Classes_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Toy Toy1 = new Toy();
            if (string.IsNullOrEmpty(txtManufacturer.Text) || (string.IsNullOrEmpty(txtName.Text)))
            {
                MessageBox.Show("Manufacturer or Name was null or empty, please try again");
            }
            else
            {
                Toy1.Manufacturer = txtManufacturer.Text;
                Toy1.Name = txtName.Text;
                
            }
            if (!int.TryParse(txtPrice.Text, out var value))
            {
                MessageBox.Show("Price must be a whole number");
            }
            else
            {
                Toy1.Price = Convert.ToDouble(txtPrice.Text);
                
            }
            ListBox.Items.Add(Toy1);

            txtName.Text = "";
            txtManufacturer.Text = "";
            txtPrice.Text = "";

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)ListBox.SelectedItem;
            MessageBox.Show($"{selectedToy.GetAisle()}");
        }
    }
}
