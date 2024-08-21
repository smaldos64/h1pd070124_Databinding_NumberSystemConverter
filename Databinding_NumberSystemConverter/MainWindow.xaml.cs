using Databinding_NumberSystemConverter.Constants;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToolsLibrary;

namespace Databinding_NumberSystemConverter
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

        private void txtCheckForValidPositiveNumberPressedForRadixSystem(object sender, KeyEventArgs e)
        {
            if (!(KeyHelper.IsKeyPressedValidInSpecifiedKeyArray(e.Key, Const.ValidSystemsKeyArray)))
            {
                if (!(KeyHelper.IsKeyPressedValidForCurrentNumberSystem(e.Key,
                                                                        Const.RadixNumberSystemsValidKeysArray,
                                                                        int.Parse(((TextBox)sender).Tag.ToString()))))
                {
                    SystemSounds.Beep.Play();
                    e.Handled = true;
                }
            }
        }
    }
}