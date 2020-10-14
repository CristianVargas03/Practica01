using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    class Connection
    {
        SqlConnection Conexion = new SqlConnection("Data source= DESKTOP-KL13RAS; Initial Catalog= Practica1; Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }

        public void Prueba()
        {
            try
            {
                Conexion.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch
            {
                Console.WriteLine("Conexion Fallida");
            }
            Conexion.Close();
        }



    }
}
