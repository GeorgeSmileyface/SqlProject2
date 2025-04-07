

using System;
using System.Data.SqlClient;

string connectionString = "Server = localhost; Database = SqlTeachingDb; User Id = sa; Password = 1234; Trusted_Connection = True; TrustServerCertificate=True";

SqlConnection connection = new SqlConnection(connectionString);

SqlCommand command = connection.CreateCommand();
string sql = $"INSERT INTO Persons (PersonID, FirstName, LastName, Address, City) VALUES ({1}, 'Peter', 'Buron', 'Here 12', 'Vejle')";

command.CommandText = sql;

connection.Open();

command.ExecuteNonQuery();

Console.ReadKey();