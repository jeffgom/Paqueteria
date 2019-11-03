using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paqueteria.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeVerClientes { get; set; }
        public bool PuedeVerReportes { get; set; }
        public bool PuedeVerFacturas { get; set; }
        public bool PuedeVerTiposdeEnvio { get; set; }
        public bool PuedeVerMapa { get; set; }
        public bool PuedeVerConsulta { get; set; }



        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id; 
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
