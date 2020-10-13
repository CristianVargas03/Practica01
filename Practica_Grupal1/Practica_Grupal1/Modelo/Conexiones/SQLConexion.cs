using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Grupal1.Modelo.Conexiones
{
    class SQLConexion
    {
        SqlConnection Conexion = new SqlConnection("Data source= DESKTOP-KL13RAS; Initial Catalog= Conectar; Integrated Security=True");
    }
}
