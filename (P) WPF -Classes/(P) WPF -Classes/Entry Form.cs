using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__WPF__Classes
{
    class Entry_Form
    {
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {


        }
        public Entry_Form()
        {

        }
        public Entry_Form(string name, string address, int zipcode)
        {
            name = Convert.ToString(txtName);
            address = Convert.ToString(txtAddress);
            zipcode = Convert.ToInt32(txtZipcode);
            string output = $"{name} at the address {address} in zipcode {zipcode}";
        }
        public override string ToString()
        {
            Console.WriteLine(output);
            return output.ToString();
        }
        void PrintText(object sender, SelectionChangedEventArgs)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            TextBlock.Text = Console.WriteLine(output);
        }
    }
}
