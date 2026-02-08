using Microsoft.Data.SqlClient;
class StudentConnection
{
    public static void Main(String[] args)
    {
       string connectionString="Server=LocalHost\\SQLEXPRESS; Database=HealthCare; Trusted_Connection=true; TrustServerCertificate=true;";
       string query="SELECT * From PATIENT";
       using SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();
            System.Console.WriteLine("Connection established");
            SqlCommand command= new SqlCommand(query, connection);
            SqlDataReader reader=command.ExecuteReader();
            while (reader.Read())
            {
               System.Console.WriteLine(reader["patient_id"]+" "+reader["name"]+" "+reader["dob"]+" "+reader["phone"]+" "+reader["address"]+" "+reader["blood_group"]);
            }
            reader.Close();
            connection.Close();
    }
}