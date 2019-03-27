using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Pr1_4_
{
    abstract class DbProviderFactory
    {
        public abstract DbConnection CreateConnection();
        public abstract DbCommand CreateCommand();
    }
    class SqlClientFactory : DbProviderFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SQLConnection();
        }
        public override DbCommand CreateCommand()
        {
            return new SQLCommand();
        }
    }
    class OleDbFactory : DbProviderFactory
    {
        public override DbConnection CreateConnection()
        {
            return new OLEDBConnection();
        }
        public override DbCommand CreateCommand()
        {
            return new OLEDBCommand();
        }
    }
}
