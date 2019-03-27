using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Pr2_4
{
    public class SettingsDB
    {
        public SettingsDB(string Name, int Val)
        {
            Update(Name, Val);
        }

        public void Update(string Name, int Val)
        { 
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=pr2_4;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE tabled SET volume=@val WHERE name=@name", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@val", Val);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable table()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=pr2_4;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT name, volume FROM tabled", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Volume");
            DataTable t;
            t = ds.Tables["Volume"];
            return t;
        }
    }
}
