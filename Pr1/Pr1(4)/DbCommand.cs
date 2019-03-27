using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Pr1_4_
{
    abstract class DbCommand
    {
        public string command;
        public abstract string comman(string comm);
    }
    class SQLCommand : DbCommand
    {
        public SQLCommand() { command = "SELECT * FROM PC"; }
        public override string comman(string comm)
        {
            return "comm";
        }
    }

    class OLEDBCommand : DbCommand
    {
       public OLEDBCommand() { command = "SELECT НомерЗал, Прізвище FROM Особи"; }
        public override string comman(string comm)
        {
            return comm;
        }
    } 
}
