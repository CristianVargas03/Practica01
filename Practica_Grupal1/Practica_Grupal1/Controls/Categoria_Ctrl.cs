using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Grupal1.Controls
{
    class Categoria_Ctrl
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

        public int Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;

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
