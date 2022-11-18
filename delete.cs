using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado.net
{
    internal class delete
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=smilyvm;Initial Catalog=client;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Enter Employee id tat you want to delete:");
            int Id = int.Parse(Console.ReadLine());
            string deleteQuery = "delete from employe where Id='" + Id + "'";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Data is deleted");
            Console.ReadKey();

            sqlConnection.Close();

        }
    }
}