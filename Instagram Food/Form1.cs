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
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                string.IsNullOrWhiteSpace(txtTipo.Text);
            string.IsNullOrWhiteSpace(txtPrecio.Text);
            string.IsNullOrWhiteSpace(txtCliente.Text);
            string.IsNullOrWhiteSpace(txtDireccion.Text);
            string.IsNullOrWhiteSpace(txtPedido.Text);
            {
              MessageBox.Show("Comida agregada: " + txtNombre.Text);
                txtNombre.Clear();
            }
           
            {
                MessageBox.Show("Por favor, ingresa el nombre de una comida.");
            }
        }
    }
}
