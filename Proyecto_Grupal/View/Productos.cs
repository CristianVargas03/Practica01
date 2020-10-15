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
    public partial class Productos : Form
    {
        Productos_Ctrl Control_PR = new Productos_Ctrl();
        private string IdProducto = null;
        private bool editar = false;

        public Productos()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            MostraProductos();
        }

        private void MostraProductos()
        {
            Productos_Ctrl Control = new Productos_Ctrl();
            dgProductos.DataSource = Control.Read();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (editar==false)
            {
                try
                {
                    Control_PR.Create(txt_nombre_producto.Text, txt_codigo.Text, txt_stock.Text, txt_fecha_vencimiento.Text, txt_Descripcion.Text, txt_categoria.Text, cb_Estado.Text);
                    MessageBox.Show("Producto Registrato!", "Notificacion");
                    MostraProductos();
                    Limpiar();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("No se pudo Guardar El Producto!" + ex.ToString(), "Error") ;
                }
            }
            if (editar == true)
            {
                try
                {
                    Control_PR.Update(txt_nombre_producto.Text, txt_codigo.Text, txt_stock.Text, txt_fecha_vencimiento.Text, txt_Descripcion.Text, txt_categoria.Text, cb_Estado.Text, IdProducto);
                    MessageBox.Show("Producto Editado", "Notificacion");
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
            if (dgProductos.SelectedRows.Count > 0)
            {
                editar = true;
                txt_nombre_producto.Text = dgProductos.CurrentRow.Cells["Nombre_Prod"].Value.ToString();
                txt_codigo.Text = dgProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                txt_stock.Text = dgProductos.CurrentRow.Cells["Stock"].Value.ToString();
                txt_fecha_vencimiento.Text = dgProductos.CurrentRow.Cells["Fecha_Vencimiento"].Value.ToString();
                txt_Descripcion.Text = dgProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txt_categoria.Text = dgProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                cb_Estado.Text = dgProductos.CurrentRow.Cells["Estado_Prod"].Value.ToString();
                IdProducto = dgProductos.CurrentRow.Cells["ID_Prod"].Value.ToString();
            }

            else
                MessageBox.Show("Seleccione una Fila, Por Favor!", "Atencion!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                IdProducto = dgProductos.CurrentRow.Cells["ID_Prod"].Value.ToString();
                Control_PR.Delete(IdProducto);
                MessageBox.Show("Producto Eliminado!", "Notificacion");
                MostraProductos();
            }
        }

        private void Limpiar()
        {
            txt_nombre_producto.Clear();
            txt_codigo.Clear();
            txt_stock.Clear();

            txt_Descripcion.Clear();
            txt_categoria.Text = "";
            cb_Estado.Text = "";
            IdProducto = null;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
