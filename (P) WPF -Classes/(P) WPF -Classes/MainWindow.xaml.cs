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

namespace _P__WPF__Classes
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
            

        }
        public EntryForm()
        {

        }
        public EntryForm(string name, string address, int zipcode)
        {
        name = Convert.ToString(txtName);
        address = Convert.ToString(txtAddress);
        zipcode = Convert.ToInt32(txtZipcode);
            string output = $"{name} at the address {address} in zipcode {zipcode}";
        }
        public override string ToString()
        {
            Console.WriteLine(output);
            return base.ToString();
        }
    }
}
