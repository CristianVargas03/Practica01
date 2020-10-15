using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace Controller
{
    public class Categoria_Ctrl
    {
        Categorias Model_CT = new Categorias();

        public DataTable Read()
        {
            DataTable tabla = new DataTable();
            tabla = Model_CT.Mostrar();
            return tabla;
        }

        public void Create(string Categoria, string Estado)
        {
            Model_CT.Insertar(Categoria, Estado);
        }

        public void Update(string Categoria, string Estado, string Id)
        {
            Model_CT.Editar(Categoria, Estado, Convert.ToInt32(Id));
        }

        public void Delete(string Id)
        {
            Model_CT.Eliminar(Convert.ToInt32(Id));
        }
    }
}
