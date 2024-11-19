using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace JHAS
{
    class DBClass
    {
        internal static DataSet Select(string q)
        {

            string connectionString = @"Data Source=.;Initial Catalog=JHAS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
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

            string connectionString = @"Data Source=.;Initial Catalog=JHAS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
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
            string connectionString = @"Data Source=.;Initial Catalog=JHAS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

        }

    }
}
