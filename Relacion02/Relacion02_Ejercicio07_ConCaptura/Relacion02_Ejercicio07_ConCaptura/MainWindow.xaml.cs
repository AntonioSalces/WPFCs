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

namespace Relacion02_Ejercicio07_ConCaptura
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonExcepcion_Click(object sender, RoutedEventArgs e)
        {
            int[] betisArray = new int[3];
            try
            {
                betisArray[10] = 1914;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("¡Error bético! Se intentó acceder a una posición inválida del array.\nDetalle: " + ex.Message,
                    "Excepción controlada", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
