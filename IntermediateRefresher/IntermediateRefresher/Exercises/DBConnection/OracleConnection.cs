using System;

namespace IntermediateRefresher.Exercises.DBConnection
{
    class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing OracleConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening OracleConnectio");
        }
    }
}
