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
using System.Collections.ObjectModel;


namespace Proyecto_Final
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Ambos> ambos = new ObservableCollection<Ambos>();

        public MainWindow()
        {
            InitializeComponent();
            ambos.Add(new Series("NARUTO", "2002", "VIZ Media", "Animación", 9, "Joven que no era querido por otros encuentra nuevas amistades.", 5));
            lstElementos.ItemsSource = ambos;
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
            btnEditar.Visibility = Visibility.Visible;
        }

        private void LstElementos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdElementos.Children.Clear();
            grdElementos.Children.Add(new VisualizarParametros());

            btnOrdenarAscendienteAño.Visibility = Visibility.Hidden;
            btnOrdenarAscendienteTitulo.Visibility = Visibility.Hidden;
            btnOrdenarDescendenteAño.Visibility = Visibility.Hidden;
            btnOrdenarDescendenteTitulo.Visibility = Visibility.Hidden;
            btnAgregar.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnEliminar.Visibility = Visibility.Visible;

            var z = ((VisualizarParametros)(grdElementos.Children[0]));
            var y = ambos[lstElementos.SelectedIndex];
            z.txtNombre.Text = y.Titulo;
            z.txtAño.Text = y.Año;
            z.txtProductor.Text = y.Productor;
            z.cboxGenero.Text = y.Genero;
            z.txtDescripción.Text = y.Descripcion;
            z.txtRating.Text = int.Parse(y.Rating);

            z.txtNombre.IsEnabled = false;
            z.txtAño.IsEnabled = false;
            z.txtProductor.IsEnabled = false;
            z.cboxGenero.IsEnabled = false;
            z.txtDescripción.IsEnabled = false;
            z.txtRating.IsEnabled = false;


        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            var z = ((VisualizarParametros)(grdElementos.Children[0]));

            z.txtNombre.IsEnabled = true;
            z.txtAño.IsEnabled = true;
            z.txtProductor.IsEnabled = true;
            z.cboxGenero.IsEnabled = true;
            z.txtDescripción.IsEnabled = true;
            z.txtRating.IsEnabled = true;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            var z = ((VisualizarParametros)(grdElementos.Children[0]));
            var y = ambos[lstElementos.SelectedIndex];

            y.Titulo = z.txtNombre.Text;
            y.Año = z.txtAño.Text;
            y.Productor = z.txtProductor.Text;
            y.Genero = z.cboxGenero.Text;
            y.Descripcion = z.txtDescripción.Text;

            lstElementos.Items.Refresh();
        }
    }
}
