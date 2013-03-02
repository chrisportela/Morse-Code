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
        private void btnConvert(object sender, RoutedEventArgs e)
        {
            if (txtCode.Text.ToArray()[0] == '-' || txtCode.Text.ToArray()[0] == '.')
            {
                txtCode.Text = mc.ConvertToNormal(txtCode.Text);
                Clipboard.SetText(txtCode.Text);
            }
            else
            {
                txtCode.Text = mc.ConvertToMorseCode(txtCode.Text.ToUpper());
                Clipboard.SetText(txtCode.Text);
            }
        }

        private void btnConvertToWords_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
