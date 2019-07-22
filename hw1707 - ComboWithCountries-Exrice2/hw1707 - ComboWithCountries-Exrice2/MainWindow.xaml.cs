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

namespace hw1707___ComboWithCountries_Exrice2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Country Israel = new Country() { Name = "Israel", Capital = "Jerusalem", ResourceFlagUrl = "/Resource/israel.png" };
            Country usa = new Country() { Name = "USA", Capital = "Washington", ResourceFlagUrl = "/Resource/usa.png" };
            InitializeComponent();
            myCmbx.ItemsSource = new List<Country> { Israel, usa };
            
        }

        private void myCmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
