using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Atividade04.Utils
{
    public class FuncoesMatematica
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["db_Math"].ConnectionString;
        public decimal Soma(Data.numeros numeros)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "Select (@numeroX + @numeroY) Resultado";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroX", numeros.numeroX);
                command.Parameters.AddWithValue("@numeroY", numeros.numeroY);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = decimal.Parse(reader["Resultado"].ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }
        public decimal Subtracao(Data.numeros numeros)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "Select (@numeroX - @numeroY) Resultado";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroX", numeros.numeroX);
                command.Parameters.AddWithValue("@numeroY", numeros.numeroY);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = decimal.Parse(reader["Resultado"].ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }
        public decimal Multiplicacao(Data.numeros numeros)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "Select (@numeroX * @numeroY) Resultado";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroX", numeros.numeroX);
                command.Parameters.AddWithValue("@numeroY", numeros.numeroY);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = decimal.Parse(reader["Resultado"].ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }
        public decimal Divisao(Data.numeros numeros)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "Select (@numeroX / @numeroY) Resultado";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroX", numeros.numeroX);
                command.Parameters.AddWithValue("@numeroY", numeros.numeroY);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = decimal.Parse(reader["Resultado"].ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }
    }
}
