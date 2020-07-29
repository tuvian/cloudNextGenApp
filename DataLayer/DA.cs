using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DA
    {
        SqlConnection _conn;

        private void OpenConnection()
        {
            //string _connectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            string _connectionString = "Server = tcp:covidtuvian.database.windows.net,1433; Initial Catalog = covidindia; Persist Security Info = False; User ID = tuviandba; Password =Tu5!an8bA@786; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            _conn = new SqlConnection(_connectionString);
            _conn.Open();
        }

        public void ExecuteNonQuery(string sqlQuery)
        {
            try
            {
                OpenConnection();
                SqlCommand _dbCommand = new SqlCommand(sqlQuery, _conn);
                _dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable ExecuteDataTable(string sqlQuery)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand _dbCommandSelect = new SqlCommand(sqlQuery, _conn);

            using (SqlDataReader dr = _dbCommandSelect.ExecuteReader())
            {
                dt.Load(dr);
            }

            return dt;
        }
    }
}
