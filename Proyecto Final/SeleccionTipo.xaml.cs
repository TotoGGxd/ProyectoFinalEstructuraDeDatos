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

namespace Proyecto_Final
{
    /// <summary>
    /// Lógica de interacción para SeleccionTipo.xaml
    /// </summary>
    public partial class SeleccionTipo : UserControl
    {
        public SeleccionTipo()
        {
            InitializeComponent();
            rbtnPelícula.IsChecked = true;
        }

        private void RbtnPelícula_Checked(object sender, RoutedEventArgs e)
        {
            if(rbtnPelícula.IsChecked == true)
            {
                lProductorDirector.Content = "Director:";
                lDescipcionSinopsis.Content = "Sinópsis:";
                lTemporadas.Visibility = Visibility.Hidden;
                txtTemporadas.Visibility = Visibility.Hidden;

            }
        }

        private void RbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            if(rbtnSerie.IsChecked == true)
            {
                lProductorDirector.Content = "Productor:";
                lDescipcionSinopsis.Content = "Descipción:";
                lTemporadas.Visibility = Visibility.Visible;
                txtTemporadas.Visibility = Visibility.Visible;


            }
        }
    }
}
