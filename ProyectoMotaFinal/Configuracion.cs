using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMotaFinal
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var lineas = new List<string>
            {
                $"ip={txtIP.Text}",
                $"puerto={txtPuerto.Text}",
                $"usuario={txtUsuario.Text}",
                $"contrasena={txtContrasena.Text}"
            };

            File.WriteAllLines("config.txt", lineas);
            MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            Config.Cargar(); // ya tienes esta función
            txtIP.Text = Config.IP;
            txtPuerto.Text = Config.Puerto.ToString();
            txtUsuario.Text = Config.Usuario;
            txtContrasena.Text = Config.Contrasena;
        }
    }
}
