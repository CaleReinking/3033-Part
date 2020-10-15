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

namespace WpfApp1
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
            Student Student1 = new Student();
            Student1.FirstName = txtFirstname.Text;
            Student1.LastName = txtLastname.Text;
            Student1.Major = txtMajor.Text;
            Student1.GPA = Convert.ToDouble(txtGpa.Text);
            lstStudents.Items.Add(Student1);
        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Address Address1 = new Address();
            Address1.StreetNumber = Convert.ToInt32(txtStreetnumber.Text);
            Address1.StreetName = txtStreetname.Text;
            Address1.State = txtState.Text;
            Address1.City = txtCity.Text;
            Address1.Zipcode = Convert.ToInt32(txtZipcode.Text);
            lstAddress.Items.Add(Address1);
            txtNames.Items.Add(Student1);
        }
    }
}
