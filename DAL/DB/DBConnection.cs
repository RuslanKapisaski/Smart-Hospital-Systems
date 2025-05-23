
//namespace Hospital_System.DAL.DbConnection
//{
//    using Npgsql;
//    using System;
//    using System.Configuration;
//    using System.Data;

//    public static class DBConnection
//    {
//        private static NpgsqlConnection connection;
//        private static readonly string conncectionString = @"Server=localhost;Username=postgres;Password=123r123k;Database=Hospital System;";


//        //Create a conncetion with PostrgeSql
//        private static void CreateConnection()
//        {
//            if (connection == null || connection.State == ConnectionState.Closed)
//            {
//                connection = new NpgsqlConnection(conncectionString);
//                connection.Open();  
//            }
         
//        }

//        public static void Close()
//        {
//            if (connection != null && connection.State != ConnectionState.Closed)
//            {
//                connection.Close();
//            }
//        }

//        public static NpgsqlConnection GetConnection()
//        {
//            var connection = new NpgsqlConnection(conncectionString);
//            connection.Open();
//            return connection;
//        }

//        public static int ExecuteDataAdapter(DataTable tblName, string strSelectSql)
//        {
//            try
//            {
//                //initilize before checking (NullRefException otherwise)
//                CreateConnection();

//                var adapter = new NpgsqlDataAdapter(strSelectSql, (NpgsqlConnection)connection);
//                var builder = new NpgsqlCommandBuilder(adapter);

//                return adapter.Update(tblName);
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//        }


//    }
//}


