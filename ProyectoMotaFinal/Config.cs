﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMotaFinal
{
    internal class Config
    {
        public static string IP { get; private set; }
        public static int Puerto { get; private set; }

        public static string Usuario { get; private set; }
        public static string Contrasena { get; private set; }



        // Por hacer: Hacer una interfaz visual sobre esto. 
        public static void Cargar()
        {
            string[] lineas = File.ReadAllLines("config.txt");
            Dictionary<string, string> datos = new Dictionary<string, string>();

            foreach (var linea in lineas)
            {
                if (linea.Contains("="))
                {
                    var partes = linea.Split('=');
                    datos[partes[0].Trim()] = partes[1].Trim();
                }
            }

            IP = datos.ContainsKey("ip") ? datos["ip"] : "127.0.0.1";
            Puerto = datos.ContainsKey("puerto") ? int.Parse(datos["puerto"]) : 8181;
            Usuario = datos.ContainsKey("usuario") ? datos["usuario"] : "";
            Contrasena = datos.ContainsKey("contrasena") ? datos["contrasena"] : "";
        }

    }
}
