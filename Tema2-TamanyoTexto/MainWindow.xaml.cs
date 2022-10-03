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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            medianoRadioButton.IsChecked = true;
        }

        private void medianoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            String a = (sender as RadioButton).Tag.ToString();
            objetivoTextBlock.FontSize = double.Parse(a);
        }
    }
}
