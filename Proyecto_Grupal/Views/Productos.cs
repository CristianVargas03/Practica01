using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_Grupal1.Controls;

namespace Practica_Grupal1.Views
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            Productos_Ctrl PR = new Productos_Ctrl();
            PR.Read();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Productos_Ctrl PR = new Productos_Ctrl();
            PR.Created();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Productos_Ctrl PR = new Productos_Ctrl();
            PR.Update();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Productos_Ctrl PR = new Productos_Ctrl();
            PR.Delete();
        }
    }
}
