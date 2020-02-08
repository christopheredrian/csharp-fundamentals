using System;

namespace IntermediateRefresher.Exercises.DBConnection
{
    class SqlConnection : DBConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQLConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQLConnection");
        }
    }
}
