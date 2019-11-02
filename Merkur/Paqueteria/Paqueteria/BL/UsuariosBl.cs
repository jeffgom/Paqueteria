using Paqueteria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paqueteria.BL
{
    public class UsuariosBl
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBl()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();
        }
        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "Admin", "123");
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerReportes = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerConsulta = true;
            usuarioAdmin.PuedeVerMapa = true;
            usuarioAdmin.PuedeVerTiposdeEnvio = true;

            var usuario1 = new Usuario(2, "Orlando Fuentes", "456");
            usuario1.PuedeVerConsulta = true;
            usuario1.PuedeVerMapa = true;
            usuario1.PuedeVerTiposdeEnvio = true;
            usuario1.PuedeVerFacturas = true;

            var usuario2 = new Usuario(3, "Ronaldo zelaya", "789");
            usuario2.PuedeVerConsulta = true;
            usuario2.PuedeVerMapa = true;
            usuario2.PuedeVerTiposdeEnvio = true;
            usuario2.PuedeVerFacturas = true;

            var usuario3 = new Usuario(4, "Eduardo Coello", "987");
            usuario3.PuedeVerConsulta = true;
            usuario3.PuedeVerMapa = true;
            usuario3.PuedeVerTiposdeEnvio = true;
            usuario3.PuedeVerFacturas = true;

            var usuario4 = new Usuario(5, "Jeffry Gomez", "654");
            usuario4.PuedeVerConsulta = true;
            usuario4.PuedeVerMapa = true;
            usuario4.PuedeVerTiposdeEnvio = true;
            usuario4.PuedeVerFacturas = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuario1);
            ListadeUsuarios.Add(usuario2);
            ListadeUsuarios.Add(usuario3);
            ListadeUsuarios.Add(usuario4);
        }
        public bool Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
