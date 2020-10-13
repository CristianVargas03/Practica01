using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Grupal1.Controls
{
    public class Productos_Ctrl
    {
        public int ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public int Nombre_Producto
        {
            get
            {
                return Nombre_Producto;
            }
            set
            {
                Nombre_Producto = value;
            }
        }

        public int Codigo
        {
            get
            {
                return Codigo;
            }
            set
            {
                Codigo = value;
            }
        }
        public int Stock
        {
            get
            {
                return Stock;
            }
            set
            {
                Stock = value;
            }
        }

        public DateTime Fecha_Vencimiento
        {
            get
            {
                return Fecha_Vencimiento;
            }
            set
            {
                Fecha_Vencimiento = value;
            }
        }

        public int Descripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }

        public int Categoria
        {
            get
            {
                return Categoria;
            }
            set
            {
                Categoria = value;
            }
        }

        public int Estado
        {
            get
            {
                return Estado;
            }
            set
            {
                Estado = value;
            }
        }

        public void Read()
        {
            MessageBox.Show("Prueba del Boton Read!");
        }

        public void Created()
        {
            MessageBox.Show("Prueba del Boton Create!");
        }

        public void Update()
        {
            MessageBox.Show("Prueba del Boton Update!");
        }

        public void Delete()
        {
            MessageBox.Show("Prueba del Boton Delete");
        }
    }
}

