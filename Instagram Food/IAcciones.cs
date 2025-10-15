using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Food
{
    internal interface IAcciones
    {
        List<Pedidos> MostrarPedidos();
        bool AgregarPedido(string nombre, string tipo, int precio, string cliente, string direccion, string pedido);
        bool EliminarPedido(string pedido);
        bool ModificarPedido(string pedido, string nombre, string tipo, int precio, string cliente, string direccion);
        bool ExportaraExcel(string ruta);
    }
}
