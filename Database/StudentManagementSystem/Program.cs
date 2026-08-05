using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;
using Org.BouncyCastle.Tls;
public class Program
{
    public static void Main(string[] args)

    {
        string connectionString = "Server=localhost; Port=3306; Database=StudentDB; Password=password";
        MySqlConnection connection = new MySqlConnection(connectionString);

        string query = "SELECT * FROM Student";

        MySqlCommand command = new MySqlCommand(query);

        MySqlReader =
       
        

    }
}