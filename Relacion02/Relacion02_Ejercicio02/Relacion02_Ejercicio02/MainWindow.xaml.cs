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

namespace Relacion02_Ejercicio02
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Content = null;

            Grid grid = new Grid();

            Button botonBetis = new Button();
            botonBetis.FontWeight = FontWeights.Bold;
            botonBetis.HorizontalAlignment = HorizontalAlignment.Center;
            botonBetis.VerticalAlignment = VerticalAlignment.Center;

            WrapPanel panel = new WrapPanel();

            TextBlock txtVerde = new TextBlock();
            txtVerde.Text = "¡Viva el Betis!";
            txtVerde.Foreground = new SolidColorBrush(Colors.Green);
            txtVerde.Margin = new Thickness(2);

            TextBlock txtAzul = new TextBlock();
            txtAzul.Text = "Manque pierda";
            txtAzul.Foreground = new SolidColorBrush(Colors.Blue);
            txtAzul.Margin = new Thickness(2);

            TextBlock txtNormal = new TextBlock();
            txtNormal.Text = "Real Betis Balompié";
            txtNormal.Margin = new Thickness(2);

            panel.Children.Add(txtVerde);
            panel.Children.Add(txtAzul);
            panel.Children.Add(txtNormal);

            botonBetis.Content = panel;

            grid.Children.Add(botonBetis);

            this.Content = grid;
        }
    }
}
