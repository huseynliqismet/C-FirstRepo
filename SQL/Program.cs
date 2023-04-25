using System.Data.SqlClient;

string connectionString = "Server=localhost;Database=K401FirstDb;Trusted_Connection=True;MultipleActiveResultSets=true;";
SqlConnection sqlConnection = new SqlConnection(connectionString);

sqlConnection.Open();

   string query = "SELECT * FROM Products";

SqlCommand command = new SqlCommand(query, sqlConnection);


SqlDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    int productId = reader.GetInt32(0);
    string productName = reader.GetString(1);
    float productPrice = reader.GetFloat(2);

    Console.WriteLine($"Product id:{productId} | ProductName : {productName} | ProductPrice: {productPrice}  ");

}


reader.Close();
sqlConnection.Close();