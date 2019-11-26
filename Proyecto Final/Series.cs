using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Series : Ambos
    {
        public int Temporadas { get; set; }

        public string tipo = "Serie";

        public Series(string titulo, string año, string productor, string genero, int temporadas, string descripcion, int rating)
        {
            Titulo = titulo;
            Año = año;
            Productor = productor;
            Genero = genero;
            Temporadas = temporadas;
            Descripcion = descripcion;
            Rating = rating;
        }

    }
}
