using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Categoria : Form
    {
        Categoria_Ctrl Control_CT = new Categoria_Ctrl();
        private string IdCategoria = null;
        private bool editar = false;
        public Categoria()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            MostraProductos();
        }

        private void MostraProductos()
        {
            Categoria_Ctrl Control = new Categoria_Ctrl();
            dgCategoria.DataSource = Control.Read();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    Control_CT.Create(txt_Nombre_Categoria.Text, cb_estado_categoria.Text);
                    MessageBox.Show("Categoria Registrata!", "Notificacion");
                    MostraProductos();
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Guardar El Producto!", "Error");
                }
            }
            if (editar == true)
            {
                try
                {
                    Control_CT.Update(txt_Nombre_Categoria.Text, cb_estado_categoria.Text, IdCategoria);
                    MessageBox.Show("Categoria Editada!", "Notificacion");
                    MostraProductos();
                    editar = false;
                    Limpiar();
                }

                catch (Exception)
                {
                    MessageBox.Show("No se pudo Editar El Producto!", "Error");
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgCategoria.SelectedRows.Count > 0)
            {
                editar = true;
                txt_Nombre_Categoria.Text = dgCategoria.CurrentRow.Cells["Nombre_Catg"].Value.ToString();
                cb_estado_categoria.Text = dgCategoria.CurrentRow.Cells["Estado_Catg"].Value.ToString();
                IdCategoria = dgCategoria.CurrentRow.Cells["ID_Catg"].Value.ToString();
                editar = false;

            }

            else
                MessageBox.Show("Seleccione una Fila, Por Favor!", "Atencion!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (dgCategoria.SelectedRows.Count > 0)
            {
                IdCategoria = dgCategoria.CurrentRow.Cells["ID_Catg"].Value.ToString();
                Control_CT.Delete(IdCategoria);
                MessageBox.Show("Categoria Eliminada!", "Notificacion");
                MostraProductos();
            }
        }

        private void Limpiar()
        {
            txt_Nombre_Categoria.Clear();
            cb_estado_categoria.Text="";
            IdCategoria = null;
        }
    }
}
