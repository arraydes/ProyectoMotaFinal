using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoMotaFinal
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.command(
                "INSERT INTO Instrumentos(nombre, tipo, marca, precio, stock) VALUES ('" +
                txtNombre.Text + "', '" +
                txtTipo.Text + "', '" +
                txtMarca.Text + "', '" +
                txtPrecio.Text + "', '" +
                txtStock.Text + "');"
            );

            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
