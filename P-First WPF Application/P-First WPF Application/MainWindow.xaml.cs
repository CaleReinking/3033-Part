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

namespace P_First_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Clear();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            btnAge.Background = new SolidColorBrush(Colors.Beige);
        }
       
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, bday;
            name = txtName.Text;
            bday = txtBday.Text;

            DateTime birthdate = Convert.ToDateTime(bday); ;
            var howOld = DateTime.Now - birthdate;
            int age = Convert.ToInt32(howOld.TotalDays / 365);

            MessageBox.Show($"{name} is {age}");
        }

        private void txtBday_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

    }
}
