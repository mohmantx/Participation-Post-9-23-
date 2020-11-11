using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _P__Classes_3
{
    /// <summary>
    /// Interaction logic for PopupWindow.xaml
    /// </summary>
    public partial class PopupWindow : Window
    {
        public Student Grad;
        public Address add;

        public PopupWindow()
        {
            InitializeComponent();
            
            
        }

        public MainWindow main { get; set; }

        public void Output(Student form)
        {
            string output = form.FirstName + form.LastName;

            tbkName.Text = output;
        }
    }
}
