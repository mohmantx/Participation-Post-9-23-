using Newtonsoft.Json;
using System;
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

namespace _P__PokeApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string ApiLink = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1100";

            Pokemon pkmnAPIResult;

            using (var client = new HttpClient())
            {
                var jsonresult = client.GetStringAsync(ApiLink).Result;

                pkmnAPIResult = JsonConvert.DeserializeObject<Pokemon>(jsonresult);
            }
            

            foreach (var character in pkmnAPIResult.pkmnlist)
            {
                cmbPkmn.Items.Add(character);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pkmn = (AllResults)cmbPkmn.SelectedItem;
            string URLPkmn = pkmn.url;

            Pokemon stat;

            using (var client = new HttpClient())
            {
                var statResult = client.GetStringAsync(URLPkmn).Result;

                stat = JsonConvert.DeserializeObject<Pokemon>(statResult);
            }

            foreach (var info in stat.statlist)
            {
                lstStats.Items.Add(info);
            }

            

        }
    }
}
