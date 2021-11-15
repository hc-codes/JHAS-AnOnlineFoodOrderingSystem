using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHAS
{
    class DBClass
    {
        internal static DataSet Select(string q)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hari\source\repos\JHAS\JHAS\JHAS.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();
            conn.Dispose();
            return data;
        }
        internal static DataSet SelectSingleItem(string q,string col)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hari\source\repos\JHAS\JHAS\JHAS.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataSet data = new DataSet();
            adapter.Fill(data,col);
            conn.Close();
            conn.Dispose();
            return data;
        }
        internal static void Insert(string q)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hari\source\repos\JHAS\JHAS\JHAS.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

        }

    }
}
