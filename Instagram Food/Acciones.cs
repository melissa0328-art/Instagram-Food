using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Instagram_Food
{
    internal class Acciones : IAcciones
    {
        List<Pedidos> listapedidos = new List<Pedidos>();

        public bool AgregarPedido(string nombre, string tipo, int precio, string cliente, string direccion, string pedido)
        {
            try
            {
                listapedidos.Add(new Pedidos(nombre, tipo, precio, cliente, direccion, pedido));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarPedido(string pedido)
        {
            var pedidoAEliminar = listapedidos.FirstOrDefault(p => p.Pedido == pedido);
            if (pedidoAEliminar != null)
            {
                listapedidos.Remove(pedidoAEliminar);
                return true;
            }
            return false;
        }

        public List<Pedidos> MostrarPedidos()
        {
            return listapedidos;
        }

        public bool ModificarPedido(string pedido, string nombre, string tipo, int precio, string cliente, string direccion)
        {
            try
            {
                var pedidoExistente = listapedidos.FirstOrDefault(p => p.Pedido == pedido);
                if (pedidoExistente != null)
                {
                    pedidoExistente.Nombre = nombre;
                    pedidoExistente.Tipo = tipo;
                    pedidoExistente.Precio = precio;
                    pedidoExistente.Cliente = cliente;
                    pedidoExistente.Direccion = direccion;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExportaraExcel(string ruta)
        {
            ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook();
            var hoja = wb.Worksheets.Add("Pedidos");
            hoja.Cell(1, 1).Value = "Tipo";
            hoja.Cell(1, 2).Value = "Nombre";
            hoja.Cell(1, 3).Value = "Precio";
            hoja.Cell(1, 4).Value = "Cliente";
            hoja.Cell(1, 5).Value = "Direccion";
            hoja.Cell(1, 6).Value = "Pedido";
            int fila = 2;
            foreach (var pedidos in listapedidos)
            {
                hoja.Cell(fila, 1).Value = pedidos.Nombre;
                hoja.Cell(fila, 2).Value = pedidos.Tipo;
                hoja.Cell(fila, 3).Value = pedidos.Precio;
                hoja.Cell(fila, 4).Value = pedidos.Cliente;
                hoja.Cell(fila, 5).Value = pedidos.Direccion;
                hoja.Cell(fila, 6).Value = pedidos.Pedido;
                fila++;
            }
            try
            {
                wb.SaveAs(ruta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Pedidos> Mostrarpedidos()
        {
            return listapedidos;

        }
    }
}

