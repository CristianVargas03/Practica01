using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    class Productos
    {
        private Connection conexion = new Connection();
        SqlDataReader DR;
        DataTable DT = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Productos";
            DR = comando.ExecuteReader();
            DT.Load(DR);
            conexion.CerrarConexion();
            return DT;

        }

        public void Insertar(string Nombre_Prod, int Codigo, int Stock, DateTime Fecha_Vencimiento, string Descripcion, string Categoria, string Estado_Prod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert into Productos values('" + Nombre_Prod + "', '" + Codigo + "', '" + Codigo + "', '" + Stock + "', '" + Fecha_Vencimiento + "', '" + Descripcion + "', '" + Categoria + "', '" + Estado_Prod + "')";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar(string Nombre_Prod, int Codigo, int Stock, DateTime Fecha_Vencimiento, string Descripcion, string Categoria, string Estado_Prod, int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar_Productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre_Prod);
            comando.Parameters.AddWithValue("@codigo", Codigo);
            comando.Parameters.AddWithValue("@stock", Stock);
            comando.Parameters.AddWithValue("@fecha_vencimiento", Fecha_Vencimiento);
            comando.Parameters.AddWithValue("@descripcion", Descripcion);
            comando.Parameters.AddWithValue("@categoria", Categoria);
            comando.Parameters.AddWithValue("@estado", Estado_Prod);
            comando.Parameters.AddWithValue("@id", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Eliminar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
