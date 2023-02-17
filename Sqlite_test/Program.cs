using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=C:\\Users\\Ben\\Documents\\SQL\\Sqlite_Test\\Sqlite_test";


            string query = "SELECT Feld FROM Tabelle";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Console.WriteLine(reader["Feld"]);


                        }
                    }
                }

                connection.Close();
            }

            Console.ReadKey();
        }
    }
}