using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Food
{
    internal class Pedidos
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Pedido { get; set; }

        public Pedidos() { }
        public Pedidos(string nombre, string tipo, int precio, string cliente, string direccion, string pedido)
        {
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Cliente = cliente;
            Direccion = direccion;
            Pedido = pedido;
        }
    }
}
