using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class Categorias
    {
        private Connection conexion = new Connection();
        SqlDataReader DR;
        DataTable DT = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Categoria";
            DR = comando.ExecuteReader();
            DT.Load(DR);
            conexion.CerrarConexion();
            return DT;

        }

        public void Insertar(string Nombre_Catg, string Estado_Catg)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert into Categoria values('" + Nombre_Catg + "', '" + Estado_Catg + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar(string Nombre_Catg,  string Estado_Catg, int ID_Catg)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre_Catg);
            comando.Parameters.AddWithValue("@estado", Estado_Catg);
            comando.Parameters.AddWithValue("@id", ID_Catg);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int ID_Catg)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Eliminar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcatg", ID_Catg);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
