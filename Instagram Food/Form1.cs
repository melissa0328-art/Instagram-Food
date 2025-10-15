using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_Food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtCliente.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                !string.IsNullOrWhiteSpace(txtPedido.Text)
            )
            {
                int precio;
                if (!int.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.");
                    return;
                }

                if (acciones.AgregarPedido(
                        txtNombre.Text,
                        txtTipo.Text,
                        precio,
                        txtCliente.Text,
                        txtDireccion.Text,
                        txtPedido.Text))
                {
                    MessageBox.Show("Comida agregada: " + txtNombre.Text);
                    txtNombre.Clear();
                    txtTipo.Clear();
                    txtPrecio.Clear();
                    txtCliente.Clear();
                    txtDireccion.Clear();
                    txtPedido.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el pedido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = acciones.MostrarPedidos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPedido.Text))
            {
                if (acciones.EliminarPedido(txtPedido.Text))
                {
                    MessageBox.Show("Pedido eliminado: " + txtPedido.Text);
                    txtPedido.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el pedido: " + txtPedido.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el nombre de una comida.");
            }
        }

        private Acciones acciones = new Acciones();

        private void btnExportar_Click(object sender, EventArgs e)
        {
            acciones.ExportaraExcel("pedidos.xlsx");
            MessageBox.Show("Datos exportados a pedidos.xlsx");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(txtPedido.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtCliente.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text)
            )
            {
                int precio;
                if (!int.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.");
                    return;
                }

                if (acciones.ModificarPedido(
                        txtPedido.Text,
                        txtNombre.Text,
                        txtTipo.Text,
                        precio,
                        txtCliente.Text,
                        txtDireccion.Text))
                {
                    MessageBox.Show("Pedido modificado: " + txtPedido.Text);
                    txtPedido.Clear();
                    txtNombre.Clear();
                    txtTipo.Clear();
                    txtPrecio.Clear();
                    txtCliente.Clear();
                    txtDireccion.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el pedido: " + txtPedido.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos para modificar el pedido.");
            }
        }
    }
}
