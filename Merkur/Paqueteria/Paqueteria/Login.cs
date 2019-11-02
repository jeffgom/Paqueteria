using Paqueteria.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paqueteria
{
    public partial class Login : Form
    {
        UsuariosBl _usuriosBL;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text;
            var contrasena = textBox2.Text;
            var resutado = _usuriosBL.Autenticar(nombre, contrasena);

            if (resutado== true)
            {
                this.Close();
            }   else
            {
                MessageBox.Show("Usuario o contraseña Incorrecta");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void CargarDatos(UsuariosBl usuariosBl)
        {
            _usuriosBL = usuariosBl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
