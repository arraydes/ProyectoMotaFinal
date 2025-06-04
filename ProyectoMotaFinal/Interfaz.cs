using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace ProyectoMotaFinal
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet ds = datos.query("SELECT id AS 'ID', nombre AS 'Nombre', tipo AS 'Tipo', marca AS 'Marca', precio AS 'Precio ($)', stock AS 'Stock Disponible' FROM instrumentos;");

            if (ds != null)
            {
                dgvInventario.DataSource = ds.Tables[0];
            }
        }

        private void Interfaz_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar ventanaInsertar = new Insertar();
            ventanaInsertar.Show();
        }
    }
}
