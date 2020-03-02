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
using System.Windows.Shapes;
using FemmeLib;
using JsonLib;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            //List<Femme> lstfm = new List<Femme>();
            //lstfm.Add(new Femme("Peppels", "Noémie", new DateTime(1999, 02, 16), "Le tyran"));
            //lstfm.Add(new Femme("Loiseau", "Margaux", new DateTime(2001, 12, 26), "Le coup de plusieurs soirs"));

            //Jfils.createJsonFemme(lstfm);
            IList<Femme> lstfm;
            lstfm = Jfils.createFemmeFromJson();
            ListeDesFemmes.ItemsSource = lstfm.ToString();
        }
    }
}
