using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace Controller
{
    public class Productos_Ctrl
    {
        Productos Model_PR = new Productos();

        public DataTable Read()
        {
            DataTable tabla = new DataTable();
            tabla = Model_PR.Mostrar();
            return tabla;
        }

        public void Create(string Nombre, string Codigo, string Stock, string Fecha, string Desc, string Categoria, string Estado )
        {
            Model_PR.Insertar(Nombre,  Convert.ToInt32(Codigo), Convert.ToInt32(Stock), Convert.ToDateTime(Fecha), Desc, Categoria, Estado);
        }

        public void Update(string Nombre, string Codigo, string Stock, string Fecha, string Desc, string Categoria, string Estado, string Id)
        {
            Model_PR.Editar(Nombre, Convert.ToInt32(Codigo), Convert.ToInt32(Stock), Convert.ToDateTime(Fecha), Desc, Categoria, Estado, Convert.ToInt32(Id));
        }

        public void Delete(string Id)
        {
            Model_PR.Eliminar(Convert.ToInt32(Id));
        }
    }

}
