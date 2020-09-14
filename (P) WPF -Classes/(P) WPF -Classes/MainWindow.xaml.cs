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
            string name = Convert.ToString(txtName);
            string address = Convert.ToString(txtAddress);
            int zipcode = Convert.ToInt32(txtZipcode);

        }
        public EntryForm()
        {

        }
        public EntryForm(string name, string address, int zipcode)
        {

        }
        public override string ToString()
        {

            return base.ToString();
        }
    }
}
