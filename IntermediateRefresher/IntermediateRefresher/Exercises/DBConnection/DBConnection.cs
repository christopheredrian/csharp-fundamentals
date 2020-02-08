using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.Exercises.DBConnection
{
    public abstract class DBConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Empty connection String");
            }

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
