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
using System.Runtime.InteropServices;

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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

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

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restuarar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Restuarar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restuarar.Visible = false;
            Maximizar.Visible = true;

        }
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Menutop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ContenedorMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Wapper_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ContenedorMenu.Width == 250)
            {
                ContenedorMenu.Width = 71;
            }
            else
            {
                ContenedorMenu.Width = 250;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var login = new Menu();
            login.Show();
            this.Hide();
        }
         
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PNLContenedor.Controls.Count > 0)
                this.PNLContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PNLContenedor.Controls.Add(fh);
            this.PNLContenedor.Tag = fh;
            fh.Show(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Facturas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Rutas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reportes());
        }
    
    }
}
