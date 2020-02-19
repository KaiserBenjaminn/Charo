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
            ListFemme.Items.Add("Noémie");
            ListFemme.Items.Add("Margaux");
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
            if (temp == "Noémie")
            {
                LabelFemme.Content = "Jerem est sage ajd";
                ListFemme.IsEnabled = false;
                LabelFemme.Visibility = Visibility.Visible;
            }
            else if(temp == "Margaux")
            {
                LabelFemme.Content = "Pas bien!!!";
                ListFemme.IsEnabled = false;
                LabelFemme.Visibility = Visibility.Visible;
            }      
        }
    }
}
