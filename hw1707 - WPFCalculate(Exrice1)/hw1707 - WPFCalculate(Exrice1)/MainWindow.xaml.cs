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

namespace hw1707___WPFCalculate_Exrice1_
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
        private void Calc()
        {
            SumTxtBlck.Text = (Int32.Parse(number1Txt.Text) + Int32.Parse(number2Txt.Text)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calc();
        }
    }
}
