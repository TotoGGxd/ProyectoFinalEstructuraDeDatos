using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Series
    {
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Productor { get; set; }
        public string Genero { get; set; }
        public int Temporadas { get; set; }
        public string Descripcion { get; set; }
        public int Rating { get; set; }

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
