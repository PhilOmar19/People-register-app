using System.Data;
using System.Data.SqlClient;
namespace C_Datos
{
    public class Record_Repository
    {
        private string connectionString;
        public Record_Repository (string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        public void AddRecord (String Record)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = SqlCommand("AddRecord", connection))
            }
        }
    }
}