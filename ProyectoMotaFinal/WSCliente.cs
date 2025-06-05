using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMotaFinal
{
    public static class WSCliente
    {
        private static ClientWebSocket socket = new ClientWebSocket();
        private static CancellationTokenSource cts = new CancellationTokenSource();


        public static event Action<string> AlRecibirMensaje;

        public static async Task Conectar(string url)
        {
            if (socket.State == WebSocketState.Open) return;

            await socket.ConnectAsync(new Uri(url), cts.Token);
            _ = EscucharMensajes(); // no esperamos su finalización
        }

        private static async Task EscucharMensajes()
        {
            var buffer = new byte[4096];

            while (socket.State == WebSocketState.Open)
            {
                var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), cts.Token);
                if (result.MessageType == WebSocketMessageType.Close) break;

                string mensaje = Encoding.UTF8.GetString(buffer, 0, result.Count);
                AlRecibirMensaje?.Invoke(mensaje);
            }
        }

        public static async Task Enviar(string mensaje)
        {
            if (socket.State != WebSocketState.Open) return;

            byte[] bytes = Encoding.UTF8.GetBytes(mensaje);
            await socket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, cts.Token);
        }

        public static bool EstaConectado(){
            if(socket.State == WebSocketState.Open) { return true; } else { return false; };
        }
    }
}
