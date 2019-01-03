using System.Data;

namespace Diagnosticcenter
{
    internal class DatabaseConnection
    {
        internal string Connection_String;

        public DataSet GetConnection { get; internal set; }
        public string Sql { get; internal set; }
    }
}