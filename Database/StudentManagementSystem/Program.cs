using MySql.Data.MySqlClient;

public class Program
{
    public static void Main(string[] args)
    {
        string connectionString = "Server=localhost;Port=3306;Database=StudentDB;User=root;Password=password";

        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Database Connected");

            // ---------------- First Query ----------------
            string query1 = "SELECT Name FROM Student";

            MySqlCommand command1 = new MySqlCommand(query1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();

            Console.WriteLine("\n----- Student Names -----");

            while (reader1.Read())
            {
                Console.WriteLine(reader1["Name"]);
            }

            // Close the first reader before executing another query
            reader1.Close();

            // ---------------- Second Query ----------------
            string query2 = "SELECT * FROM Student";

            MySqlCommand command2 = new MySqlCommand(query2, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();

            Console.WriteLine("\n----- Student Details -----");

            while (reader2.Read())
            {
                Console.WriteLine($"ID   : {reader2["id"]}");
                Console.WriteLine($"Name : {reader2["Name"]}");
                Console.WriteLine("--------------------------");
            }

            reader2.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error : " + ex.Message);
        }
            connection.Close();
            Console.WriteLine("\nDatabase Closed");
        
    }
}