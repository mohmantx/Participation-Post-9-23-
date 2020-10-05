using System;
using Newtonsoft.Json;
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

namespace Chuck_Norris_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string URLCategory = @"https://api.chucknorris.io/jokes/categories";

            Quotes categories;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync(URLCategory).Result;
                categories = JsonConvert.DeserializeObject<Quotes>(json);
            }

            foreach (var cat in categories.categorylist)
            {
                cboCategory.Items.Add(cat);
            }
        }

        private void cboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
