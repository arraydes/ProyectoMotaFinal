using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoMotaFinal
{
    public partial class ActBorrar : Form
    {
        public ActBorrar(int id, string nombre, string tipo, string marca, double precio, int stock)
        {
            InitializeComponent();


            txtID.Text = id.ToString();
            txtNombre.Text = nombre;
            txtTipo.Text = tipo;
            txtMarca.Text = marca;
            txtPrecio.Text = precio.ToString();
            txtStock.Text = stock.ToString();
        }

        private async void ActBorrar_Load(object sender, EventArgs e)
        {


        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var payload = new
                {
                    evento = "ACTUALIZAR",
                    tabla = "Instrumentos", // Asegúrate de que la tabla sea correcta
                    condiciones = "id = " + Convert.ToInt32(txtID.Text), // Condición para identificar el registro a actualizar
                    valores = new
                    {

                        nombre = txtNombre.Text,
                        tipo = txtTipo.Text,
                        marca = txtMarca.Text,
                        precio = decimal.Parse(txtPrecio.Text),
                        stock = decimal.Parse(txtStock.Text)
                    }
                };

                string json = JsonConvert.SerializeObject(payload);
                await WSCliente.Enviar(json);

                //MessageBox.Show("Producto actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    var payload = new
                    {
                        evento = "ELIMINAR",
                        tabla = "Instrumentos", // Asegúrate de que la tabla sea correcta
                        condiciones = "id = " + Convert.ToInt32(txtID.Text) // Condición para identificar el registro a eliminar
                    };

                    string json = JsonConvert.SerializeObject(payload);
                    await WSCliente.Enviar(json);

                    //MessageBox.Show("Producto eliminado correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
