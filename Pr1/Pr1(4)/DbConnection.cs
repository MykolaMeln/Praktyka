using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Pr1_4_
{
    abstract class DbConnection
    {
        public string connectionString;
        public abstract string connect(string conn);
    }
    class SQLConnection : DbConnection
    {
        public SQLConnection() { connectionString = @"Data Source=.\SQLEXPRESS01; Initial Catalog=computer; Integrated Security=true;"; }
        public override string connect(string conn)
        {
        return  @"Data Source=.\SQLEXPRESS1; Initial Catalog="+conn+"; Integrated Security=true;";
        }
    } 
    class OLEDBConnection : DbConnection
    {
        public OLEDBConnection() { connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=База№1.accdb; Persist Security Info=False;"; }
        public override string connect(string conn)
        {
            return "Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+conn+"; Persist Security Info = False;";
        }
    }
}
