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

namespace _P__Classes_3
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string firstname = txtFName.Text;
            string lastname = txtLName.Text;
            string major = txtMaj.Text;
            double gpa = Convert.ToDouble(txtGPA.Text);
            int streetnumber = Convert.ToInt32(txtStrNum.Text);
            string streetname = txtStrName.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            int zipcode = Convert.ToInt32(txtZipCode.Text);

            Address address = new Address(streetnumber, streetname, city, state, zipcode);
            Student form = new Student(firstname, lastname, major, gpa, address);

            string toForm = form.ToString() + "\n" + form.CalculateDistinction();
            lstStudent.Items.Add(toForm);
        }


        private void lstStudent_OnSelected(object sender, RoutedEventArgs e)
        {
            

            
        }
    }
}
