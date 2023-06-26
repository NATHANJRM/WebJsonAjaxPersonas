using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataPersonas
{
    public class Dpersonas
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable Obtener()
        {
            string query = "select * from personas";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataRow Obtenerid (int id)
        {
            string query = $"select * from Personas where id ={id}";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0];
        }

        public int agregar(string Nombre, string Paterno, string Materno, int Edad, DateTime Fechaalta)
        {
            string query = $"insert into Personas values ('{Nombre}', '{Edad}', '{DateTime.Now.ToString("yyyy/MM/dd")}', '{Paterno}', '{Materno}')";
            SqlCommand com = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();
                int fila = com.ExecuteNonQuery();
                conexion.Close();
                return fila;
            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }
        }

        public void Editar(string Nombre, string Paterno, string Materno, int Edad, DateTime Fechaalta, int id)
        {
            string query = $"update Personas set Nombre ='{Nombre}', Edad ='{Edad}', Fechaalta = '{DateTime.Now.ToString("yyyy/MM/dd")}', Paterno = '{Paterno}', Materno = '{Materno}' where id = {id} ";
            SqlCommand com = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();
                com.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }
        }

        public int Eliminar (int id)
        {
            string query = $"delete personas where id = {id}";
            SqlCommand com = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();
                int fila = com.ExecuteNonQuery();
                conexion.Close() ;
                return fila;
            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }
        }

        public DataTable Buscar(string palabra)
        {
            string query = $"select * from Personas where Nombre like '%{palabra}%' or Paterno like '%{palabra}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);            
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
    }

    
}
