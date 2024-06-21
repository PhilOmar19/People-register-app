using Cp_Entidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Cp_Datos
{
    public class D_Agenda
    {
        SqlConnection conexion = new SqlConnection("Server= DESKTOP-TFNBFUK; database= AGENDAX; integrated security= true");

        public DataTable D_ShowRecord()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ShowRecord", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
        public void D_DeleteRecord(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteRecord", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_agendax", id);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void D_AddRecord(string Nombre, string Apellido, string Dirección, DateTime Fecha_nacimiento, string Celular)
        {
            SqlCommand cmd = new SqlCommand("AddRecord", conexion);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Direccion", Dirección);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@Celular", Celular);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable D_GetRecord (int id) 
        {
            SqlCommand cmd = new SqlCommand("GetRecord", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_agendax", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
        public void D_UpdateRecord(int id, string Nombre, string Apellido, string Dirección, DateTime Fecha_nacimiento, string Celular)
        {
            SqlCommand cmd = new SqlCommand("UpdateRecord", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_agendax", id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Direccion", Dirección);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@Celular", Celular);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}