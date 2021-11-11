using System;
using Microsoft.Data.SqlClient;
namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=Mercado;User ID=sa;Password=1q2w3e4r@#$";
            
            using (var connection = new SqlConnection(connectionString)){
            
                connection.Open();
                using(var command = new SqlCommand()){
            
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT [IdCategoria], Nome FROM [CATEGORIA]";
                    SqlDataReader reader = command.ExecuteReader(); // Pra leitura
                    
                    //SqlDataReader reader = command.ExecuteNonQuery(); // Pra inserções, updates e deletes, retorna as linhas afetadas
                    while(reader.Read()){ //cursor

                        Console.WriteLine($"{reader.GetInt32(0)} - {reader.GetString(1)}"); //informar sempre a coluna onde está a coluna e o tipo certo, senão da erro de conversão de tipo
                    }
                }
            }
        }
    }
}
