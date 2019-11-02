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
    public partial class Menu : Form
    {

        UsuariosBl _usuariosBL;

        public Menu()
        {
            InitializeComponent();

            _usuariosBL = new UsuariosBl();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.CargarDatos(_usuariosBL);

            Login.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
