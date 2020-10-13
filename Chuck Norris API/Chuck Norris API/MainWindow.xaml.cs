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

            string[] categories;

            using (var client = new HttpClient())
            {
                var jsonResults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Result;
                categories = JsonConvert.DeserializeObject<string[]>(jsonResults);
            }
            cboCategory.Items.Add("All");

            foreach (var category in categories)
            {
                cboCategory.Items.Add(category);
            }
        }
        //For some reason I can't get my image of chuck norris to work
        private void btnJoke_Click(object sender, RoutedEventArgs e)
        {
            var norris = cboCategory.SelectedItem;

            string URLcat;

            if (norris.ToString() == "All")
            {
                URLcat = "https://api.chucknorris.io/jokes/random";
            }
            else
            {
                URLcat = "https://api.chucknorris.io/jokes/random?category=" + norris;
            }

            Quotes API;

            using (var client = new HttpClient())
            {
                string convJson = client.GetStringAsync(URLcat).Result;
                API = JsonConvert.DeserializeObject<Quotes>(convJson);
            }
            string randJoke = API.ToString();
            MessageBox.Show(randJoke);
            
        }

        private void cboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
