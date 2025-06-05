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
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoMotaFinal
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
   
            try
            {
                var nuevoProducto = new
                {
                    evento = "INSERTAR",
                    tabla = "Instrumentos", 
                    valores = new
                    {
                        nombre = txtNombre.Text,
                        tipo = txtTipo.Text,
                        marca = txtMarca.Text,
                        precio = Double.Parse(txtPrecio.Text),
                        stock = Double.Parse(txtStock.Text)    
                    }
                };

                string json = JsonConvert.SerializeObject(nuevoProducto);
                await WSCliente.Enviar(json);

                //MessageBox.Show("Producto insertado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto: " + ex.Message);
            }
        }
    }
}
