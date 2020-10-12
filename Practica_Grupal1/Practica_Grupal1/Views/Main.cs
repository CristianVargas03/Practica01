using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Grupal1.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(panel_menu.Width == 230)
            {
                panel_menu.Width = 76;
            }
            else
            {
                panel_menu.Width = 230;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abrirpanel(object Formhijo)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            abrirpanel(new Productos());
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            abrirpanel(new Categorias());
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            abrirpanel(new Lista());
        }
    }
}
