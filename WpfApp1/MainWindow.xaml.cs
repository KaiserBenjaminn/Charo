using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        private void ButtonJeremCharo_Click(object sender, RoutedEventArgs e)
        {
            LabelCharo.Visibility = Visibility.Visible;
            ListFemme.Visibility = Visibility.Visible;
            ValiderFemme.Visibility = Visibility.Visible;
        }

        private void Liste_de_ses_femmes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = (string)ListFemme.SelectedItem;
            switch (temp)
            {
                case "Noémie":
                    LabelFemme.Content = "Jerem est sage ajd";
                    break;

                case "Margaux":
                    LabelFemme.Content = "Pas bien!!!";
                    break;
                default:
                    return;
            }

            ListFemme.IsEnabled = false;
            LabelFemme.Visibility = Visibility.Visible;
        }
        private void createJson()
        {
            List<Femme> colFem = new List<Femme>();

            colFem.Add(new Femme("Peppels", "Noémie", new DateTime(1999, 02, 16), "Le tyran"));
            colFem.Add(new Femme("Loiseau", "Margaux", new DateTime(2001, 12, 26), "Le coup de plusieurs soirs"));

            JsonSerializer serializer = new JsonSerializer();
            string output = JsonConvert.SerializeObject(colFem);
            using (StreamWriter writer = File.CreateText("data.json"))
                serializer.Serialize(writer, output);
        }
    }
}
