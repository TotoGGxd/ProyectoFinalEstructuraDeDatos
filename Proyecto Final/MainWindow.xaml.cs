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
            ambos.Add(new Series("NARUTO", 2002, "VIZ Media", "Drama", 9, "Joven que no era querido por otros encuentra nuevas amistades.", 5));
            ambos.Add(new Peliculas("Alvin y las ardillas", 2009, "Warner", "Cómedia", "Son unas ardillas jaja", 2));
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
            btnEditar.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            btnActualizar.Visibility = Visibility.Hidden;
        }

        private void LstElementos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstElementos.SelectedIndex != -1)
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
                btnActualizar.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;

                var z = ((VisualizarParametros)(grdElementos.Children[0]));
                var y = ambos[lstElementos.SelectedIndex];

                z.txtNombre.Text = y.Titulo;
                z.txtAño.Text = y.Año.ToString();
                z.txtProductor.Text = y.Productor;
                z.cboxGenero.Text = y.Genero;
                z.txtDescripción.Text = y.Descripcion;
                z.lClase.Text = y.Tipo;
                z.txtTemporadas.Text = y.Temporadas.ToString();
                z.txtRating.Text = y.Rating.ToString();

                #region Estrellas
                if (y.Rating == 0)
                {
                    z.Estrella0.Visibility = Visibility.Visible;
                }
                if (y.Rating == 1)
                {
                    z.Estrella1.Visibility = Visibility.Visible;
                }
                if (y.Rating == 2)
                {
                    z.Estrella2.Visibility = Visibility.Visible;
                }
                if (y.Rating == 3)
                {
                    z.Estrella3.Visibility = Visibility.Visible;
                }
                if (y.Rating == 4)
                {
                    z.Estrella4.Visibility = Visibility.Visible;
                }
                if (y.Rating == 5)
                {
                    z.Estrella5.Visibility = Visibility.Visible;
                }
                #endregion

                if (y.Tipo == "Serie")
                {
                    z.lTemporada.Visibility = Visibility.Visible;
                    z.txtTemporadas.Visibility = Visibility.Visible;
                }

                z.txtNombre.IsEnabled = false;
                z.txtAño.IsEnabled = false;
                z.txtProductor.IsEnabled = false;
                z.cboxGenero.IsEnabled = false;
                z.txtDescripción.IsEnabled = false;
                z.txtTemporadas.IsEnabled = false;
                z.txtRating.IsEnabled = false;

            }


        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            var z = ((VisualizarParametros)(grdElementos.Children[0]));
            var y = ambos[lstElementos.SelectedIndex];


            z.txtNombre.IsEnabled = true;
            z.txtAño.IsEnabled = true;
            z.txtProductor.IsEnabled = true;
            z.cboxGenero.IsEnabled = true;
            z.txtDescripción.IsEnabled = true;
            z.txtRating.IsEnabled = true;
            z.txtTemporadas.IsEnabled = true;
            z.lRating.Visibility = Visibility.Visible;
            z.txtRating.Visibility = Visibility.Visible;

            #region EstrellasEscondidas
            if (y.Rating == 0)
            {
                z.Estrella0.Visibility = Visibility.Hidden;
            }
            if (y.Rating == 1)
            {
                z.Estrella1.Visibility = Visibility.Hidden;
            }
            if (y.Rating == 2)
            {
                z.Estrella2.Visibility = Visibility.Hidden;
            }
            if (y.Rating == 3)
            {
                z.Estrella3.Visibility = Visibility.Hidden;
            }
            if (y.Rating == 4)
            {
                z.Estrella4.Visibility = Visibility.Hidden;
            }
            if (y.Rating == 5)
            {
                z.Estrella5.Visibility = Visibility.Hidden;
            }
            #endregion

            btnEditar.Visibility = Visibility.Hidden;
            btnActualizar.Visibility = Visibility.Visible;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            var z = ((SeleccionTipo)(grdElementos.Children[0]));
             
            
            if(z.rbtnPelícula.IsChecked == true)
            {
                if (z.txtTitulo.Text == string.Empty || z.txtAño.Text == null || z.txtProductorDirector.Text == string.Empty || z.cboxGenero.Text == string.Empty || z.txtDescripcionSinopsis.Text == string.Empty || z.txtRating.Text == string.Empty)
                {
                    z.lAdvertencia.Visibility = Visibility.Visible;
                }
                else
                {
                    ambos.Add(new Peliculas(z.txtTitulo.Text, Convert.ToInt32(z.txtAño.Text), z.txtProductorDirector.Text, z.cboxGenero.Text, z.txtDescripcionSinopsis.Text, Convert.ToInt32(z.txtRating.Text)));

                    btnAgregar.Visibility = Visibility.Visible;
                    btnOrdenarAscendienteAño.Visibility = Visibility.Visible;
                    btnOrdenarAscendienteTitulo.Visibility = Visibility.Visible;
                    btnOrdenarDescendenteAño.Visibility = Visibility.Visible;
                    btnOrdenarDescendenteTitulo.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Hidden;
                    btnGuardar.Visibility = Visibility.Hidden;
                    btnEditar.Visibility = Visibility.Hidden;
                    btnEliminar.Visibility = Visibility.Hidden;

                    grdElementos.Children.Clear();

                }
            }
            if (z.rbtnSerie.IsChecked == true)
            {
                if (z.txtTitulo.Text == string.Empty || z.txtAño.Text == null || z.txtProductorDirector.Text == string.Empty || z.cboxGenero.Text == string.Empty|| z.txtTemporadas.Text == string.Empty || z.txtDescripcionSinopsis.Text == string.Empty || z.txtRating.Text == string.Empty)
                {
                    z.lAdvertencia.Visibility = Visibility.Visible;
                }
                else
                {
                    ambos.Add(new Series(z.txtTitulo.Text, Convert.ToInt32(z.txtAño.Text), z.txtProductorDirector.Text, z.cboxGenero.Text, Convert.ToInt32(z.txtTemporadas.Text), z.txtDescripcionSinopsis.Text, Convert.ToInt32(z.txtRating.Text)));

                    z.lAdvertencia.Visibility = Visibility.Hidden;


                    btnAgregar.Visibility = Visibility.Visible;
                    btnOrdenarAscendienteAño.Visibility = Visibility.Visible;
                    btnOrdenarAscendienteTitulo.Visibility = Visibility.Visible;
                    btnOrdenarDescendenteAño.Visibility = Visibility.Visible;
                    btnOrdenarDescendenteTitulo.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Hidden;
                    btnGuardar.Visibility = Visibility.Hidden;
                    btnEditar.Visibility = Visibility.Hidden;
                    btnEliminar.Visibility = Visibility.Hidden;

                    grdElementos.Children.Clear();

                }
            }

        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var z = ((VisualizarParametros)(grdElementos.Children[0]));
            var y = ambos[lstElementos.SelectedIndex];

            if (z.txtNombre.Text == string.Empty || z.txtAño.Text == null || z.txtProductor.Text == string.Empty || z.cboxGenero.Text == string.Empty || z.txtDescripción.Text == string.Empty || z.txtRating.Text == string.Empty && y.Tipo == "Película")
            {
                z.lAdvertecia.Visibility = Visibility.Visible;
            }
            if(z.txtNombre.Text == string.Empty || z.txtAño.Text == null || z.txtProductor.Text == string.Empty || z.cboxGenero.Text == string.Empty || z.txtDescripción.Text == string.Empty || z.txtRating.Text == string.Empty && y.Tipo == "Serie")
            {
                z.lAdvertecia.Visibility = Visibility.Visible;
            }
            else
            {
                y.Titulo = z.txtNombre.Text;
                y.Año = Convert.ToInt32(z.txtAño.Text);
                y.Productor = z.txtProductor.Text;
                y.Genero = z.cboxGenero.Text;
                y.Descripcion = z.txtDescripción.Text;
                y.Rating = Convert.ToInt32(z.txtRating.Text);
                lstElementos.Items.Refresh();

                z.txtNombre.IsEnabled = false;
                z.txtAño.IsEnabled = false;
                z.txtProductor.IsEnabled = false;
                z.cboxGenero.IsEnabled = false;
                z.txtDescripción.IsEnabled = false;
                z.txtTemporadas.IsEnabled = false;
                z.txtRating.IsEnabled = false;

                btnActualizar.Visibility = Visibility.Hidden;
                btnEditar.Visibility = Visibility.Visible;

            }

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstElementos.SelectedIndex != -1)
            {
                ambos.RemoveAt(lstElementos.SelectedIndex);
            }

            grdElementos.Children.Clear();
            lstElementos.Items.Refresh();

            btnAgregar.Visibility = Visibility.Visible;
            btnOrdenarAscendienteAño.Visibility = Visibility.Visible;
            btnOrdenarAscendienteTitulo.Visibility = Visibility.Visible;
            btnOrdenarDescendenteAño.Visibility = Visibility.Visible;
            btnOrdenarDescendenteTitulo.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;

        }

        private void BtnOrdenarDescendenteTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (ambos.Count - 1); i++)
                {
                    if (string.Compare(ambos[i].Titulo, ambos[i + 1].Titulo) > 0)
                    {
                        var temp = ambos[i];
                        ambos[i] = ambos[i + 1];
                        ambos[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnOrdenarAscendienteTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (ambos.Count - 1); i++)
                {
                    if (string.Compare(ambos[i].Titulo, ambos[i + 1].Titulo) < 0)
                    {
                        var temp = ambos[i];
                        ambos[i] = ambos[i + 1];
                        ambos[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);

        }

        private void BtnOrdenarDescendenteAño_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < ambos.Count - 1; i++)
                {
                    if (ambos[i].Año > ambos[i + 1].Año)
                    {
                        var temp = ambos[i];
                        ambos[i] = ambos[i + 1];
                        ambos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        private void BtnOrdenarAscendienteAño_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < ambos.Count - 1; i++)
                {
                    if (ambos[i].Año < ambos[i + 1].Año)
                    {
                        var temp = ambos[i];
                        ambos[i] = ambos[i + 1];
                        ambos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }

    
}