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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdElementos.Children.Clear();
            grdElementos.Children.Add(new SeleccionTipo());

            btnAgregar.Visibility = Visibility.Hidden;
            btnOrdenarAscendienteAño.Visibility = Visibility.Hidden;
            btnOrdenarAscendienteTitulo.Visibility = Visibility.Hidden;
            btnOrdenarDescendenteAño.Visibility = Visibility.Hidden;
            btnOrdenarDescendenteTitulo.Visibility = Visibility.Hidden;
            btnAgregar.Visibility = Visibility.Hidden;
            btnAgregar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdElementos.Children.Clear();

            btnAgregar.Visibility = Visibility.Visible;
            btnOrdenarAscendienteAño.Visibility = Visibility.Visible;
            btnOrdenarAscendienteTitulo.Visibility = Visibility.Visible;
            btnOrdenarDescendenteAño.Visibility = Visibility.Visible;
            btnOrdenarDescendenteTitulo.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
        }

    }
}
