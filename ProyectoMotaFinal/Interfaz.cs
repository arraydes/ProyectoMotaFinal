using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ProyectoMotaFinal
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private async void ProcesarMensajeDelServidor(string mensaje)
        {
            // Solo procesa si el mensaje es una lista JSON
            try
            {
                // Intentamos deserializar como un objeto con campos "evento" y "contenido"
                var objeto = JsonConvert.DeserializeObject<Dictionary<string, object>>(mensaje);

                if (objeto != null && objeto.ContainsKey("evento"))
                {
                    string evento = objeto["evento"].ToString();

                    switch (evento)
                    {
                        case "DATOS":
                            // Deserializamos el contenido como tabla
                            var datosJson = objeto["contenido"].ToString();
                            var tabla = JsonConvert.DeserializeObject<DataTable>(datosJson);
                            dgvInventario.Invoke(() => dgvInventario.DataSource = tabla);
                            break;

                        case "NOTIFICACION":
                            string texto = objeto["contenido"].ToString();
                            MessageBox.Show($"Notificación del servidor: {texto}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await WSCliente.Enviar("{\"evento\": \"GET_INSTRUMENTOS\"}");

                            break;

                        //case "AUTENTICACION_EXITOSA":
                        //    MessageBox.Show("Autenticación correcta.");
                        //    break;

                        //case "ERROR":
                        //    MessageBox.Show($"Error del servidor: {objeto["contenido"]}");
                        //    break;

                        // Agrega más eventos aquí...

                        default:
                            MessageBox.Show($"Evento desconocido: {evento}");
                            break;
                    }
                }
                else if (mensaje.Trim().StartsWith("["))
                {
                    // Mensaje JSON plano como lista (sin "evento")
                    var tabla = JsonConvert.DeserializeObject<DataTable>(mensaje);
                    dgvInventario.Invoke(() => dgvInventario.DataSource = tabla);
                }
                else
                {
                    MessageBox.Show("Mensaje recibido sin estructura reconocible: " + mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar mensaje del servidor:\n" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar ventanaInsertar = new Insertar();
            ventanaInsertar.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracion configuracionForm = new Configuracion();
            configuracionForm.ShowDialog();
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Config.Cargar(); // Carga IP, puerto, usuario, contraseña

                string url = $"ws://{Config.IP}:{Config.Puerto}";
                await WSCliente.Conectar(url);

                WSCliente.AlRecibirMensaje += ProcesarMensajeDelServidor;

                // Enviar credenciales de autenticación
                //var authPayload = new
                //{
                //    evento = "AUTENTICAR",
                //    usuario = Config.Usuario,
                //    contrasena = Config.Contrasena
                //};

                //string authJson = JsonConvert.SerializeObject(authPayload);
                //await WSCliente.Enviar(authJson);

                // Una vez autenticado, pides los datos
                await WSCliente.Enviar("{\"evento\": \"GET_INSTRUMENTOS\"}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}");
            }
        }

        // Se descontinua su función porque no siempre se llama al DataGridCellEvent
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ActBorrar ventanaActBorrar = new ActBorrar(
            //    Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells[0].Value),
            //    dgvInventario.Rows[e.RowIndex].Cells[1].Value.ToString(),
            //    dgvInventario.Rows[e.RowIndex].Cells[2].Value.ToString(),
            //    dgvInventario.Rows[e.RowIndex].Cells[3].Value.ToString(),
            //    Convert.ToDouble(dgvInventario.Rows[e.RowIndex].Cells[4].Value),
            //    Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells[5].Value));

            //ventanaActBorrar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvInventario.CurrentRow.Index;
            ActBorrar ventanaActBorrar = new ActBorrar(
                Convert.ToInt32(dgvInventario.Rows[i].Cells[0].Value),
                dgvInventario.Rows[i].Cells[1].Value.ToString(),
                dgvInventario.Rows[i].Cells[2].Value.ToString(),
                dgvInventario.Rows[i].Cells[3].Value.ToString(),
                Convert.ToDouble(dgvInventario.Rows[i].Cells[4].Value),
                Convert.ToInt32(dgvInventario.Rows[i].Cells[5].Value));

            ventanaActBorrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WSCliente.DesconectarWebSocketAsync();

            //Para que la tabla se vacíe
            dgvInventario.DataSource = null;
        }
    }
}
