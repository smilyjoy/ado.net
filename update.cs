using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado.net
{
    internal class update
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=smilyvm;Initial Catalog=client;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Enter Employee id");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the salary that you want to change");
            int salary = int.Parse(Console.ReadLine());
            string updateQuery = "update employe set salary='" + salary + "' where Id='" + Id + "'";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Data updated");
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}