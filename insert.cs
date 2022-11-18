using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace ado.net
{
    internal class insert
    {
        static void Main(string[] args)
        {


            SqlConnection con = new SqlConnection("data source = .; database = client; integrated security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" select * from dbo.employe;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Id = dr["Id"].ToString();
                string firstname = dr["firstname"].ToString();
                string lastname = dr["lastname"].ToString();
                string salary= dr["salary"].ToString();

                Console.WriteLine(Id + " " + firstname + " " + lastname + " " + salary);




            }
            dr.Close();
            con.Close();
            Console.ReadLine();


        }
    }
}
    

