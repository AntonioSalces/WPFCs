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

namespace Relacion02_Ejercicio06
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            tbMain.Inlines.Clear();

            if (cbToggle.IsChecked == true)
            {
                var underline = new Underline();
                underline.Inlines.Add(new Run("Nuevo texto con parte subrayada."));
                tbMain.Inlines.Add(underline);

                tbMain.Inlines.Add(new Run(" Y también tiene "));

                var bold = new Bold();
                bold.Inlines.Add(new Run("una palabra en negrita."));
                tbMain.Inlines.Add(bold);
            }
            else
            {
                tbMain.Text = "Este es un texto simple sin formato después de la actualización.";
            }
        }
    }
}
