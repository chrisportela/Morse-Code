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

namespace Morse_Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MorseCode mc = new MorseCode(CodeTypes.International);

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnConvertToCode_Click_1(object sender, RoutedEventArgs e)
        {
            txtCode.Text = mc.ConvertToMorseCode(txtNormal.Text.ToUpper());
        }

        private void btnConvertToWords_Click_1(object sender, RoutedEventArgs e)
        {
            txtNormal.Text = mc.ConvertToNormal(txtCode.Text);
        }
    }
}
