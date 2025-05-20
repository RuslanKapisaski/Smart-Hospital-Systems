
namespace Hospital_System.DAL.DbConnection
{
    using Npgsql;
    using System.Configuration;

    public static class DBConnection
    {
        private static readonly string  conncectionString = @"Server=localhost;Username=postgres;Password=123r123k;Database=Hospital System;";
        //"Host=localhost;Username=postgres;Password=yourpassword;Database=hospitaldb;";

        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(conncectionString);
            connection.Open();
            return connection;
        }
    }
}
