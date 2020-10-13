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
            string fname, lname, major;
            double gpa;
            int stnum, zip;
            string stname, city, state;

            fname = txtFirst.Text;
            lname = txtLast.Text;
            major = txtMajor.Text;
            gpa = Convert.ToDouble(txtGPA.Text);

            stnum = Convert.ToInt32(txtStreetNum.Text);
            stname = txtStreetName.Text;
            city = txtCity.Text;
            state = txtState.Text;
            zip = Convert.ToInt32(txtZip.Text);

            Address addy = new Address(stnum, stname, city, state, zip);

            Student form = new Student(fname, lname, major, gpa, addy);

            string output = form.ToString() + "\n" + form.CalculateDistinction();

            lstStudent.Items.Add(output);


            
        }

        private void lstStudent_OnSelected(object sender, RoutedEventArgs e)
        {
            ListBoxItem lst = e.Source as ListBoxItem;

            
        }
    }
}
