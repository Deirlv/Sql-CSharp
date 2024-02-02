using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ConsoleApp1
{
    internal class Program
    {

        public static string StrConn => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2;Integrated Security=True;Connect Timeout=30;";

        private SqlConnection _conn;

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First Name");
            //string? FirstName = Console.ReadLine();

            //Console.WriteLine("Enter Last Name");
            //string? LastName = Console.ReadLine();

            //Console.WriteLine("Enter Email");
            //string? Email = Console.ReadLine();

            //Console.WriteLine("Enter Date of Birth");
            //string? Date = Console.ReadLine();

            //_conn = SqlConnection(StrConn);

            using(SqlConnection conn = new SqlConnection(StrConn))
            {
                var query = "SELECT * FROM Users";
                var cmd = new SqlCommand(query, conn);

                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader["FirstName"]}, {reader["LastName"]}, {reader["Email"]}, {reader["DateOfBirth"]}");
                    }
                }
                conn.Close();
            }

            //InsertQuery(FirstName, LastName, Email, Date);

            // Data Source=DESKTOP-7P700PI\SQLEXPRESS;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;
            // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2;Integrated Security=True;Connect Timeout=30;User ID=123;Password=12312;

           
        }

        static void InsertQuery(string? FirstName, string? LastName, string? Email, string? Date)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
