using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Galeri_Otomasyonu_LastVersion
{
    class last_version
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5FITBD3;Initial Catalog=Galeri_Otomasyonu_LastVersion;Integrated Security=True");
        DataTable table;
        public DataTable make_a_list(SqlDataAdapter kkk,string query)
        {
            table = new DataTable();
            kkk = new SqlDataAdapter(query, connection); 
            kkk.Fill(table);
            connection.Close();
            return table; 
            // Her seferinde güncellemesi için return tablo diyorum
        }
        public void add(SqlCommand command, string query)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
