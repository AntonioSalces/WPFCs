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

namespace Relacion03_Ejercicio05
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

        private void cbTodos_Changed(object sender, RoutedEventArgs e)
        {
            bool? check = cbTodos.IsChecked;
            cbM1.IsChecked = check;
            cbM2.IsChecked = check;
            cbM3.IsChecked = check;
        }

        private void cbIndividual_Changed(object sender, RoutedEventArgs e)
        {
            int marcados = 0;
            int total = 3;
            if (cbM1.IsChecked == true) marcados++;
            if (cbM2.IsChecked == true) marcados++;
            if (cbM3.IsChecked == true) marcados++;

            if (marcados == total)
                cbTodos.IsChecked = true;
            else if (marcados == 0)
                cbTodos.IsChecked = false;
            else
                cbTodos.IsChecked = null;
        }
    }
}
