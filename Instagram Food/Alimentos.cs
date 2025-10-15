using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Food
{
    internal class Alimentos
    {
        public Alimentos(string nombre, string tipo, int precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            this.precio = precio;
        }

        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int precio { get; set; }

        public Alimentos() { }


    }
}
