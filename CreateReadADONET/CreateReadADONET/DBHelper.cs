using Microsoft.Data.SqlClient;

/*
    1. Connection (Program -> MSSQL)
    2. Write SQL Command
    3. Create SQL Command var
    4. Send SQL Command
    (.Open() / .Close())
*/

namespace CreateReadADONET
{
    internal class DBHelper
    {
        private readonly string connectionStr;
        
        public DBHelper()
        {
            this.connectionStr = "Data Source=localhost,1436;Initial Catalog=CRDB;User ID=sa;Password=Zulimp33#;TrustServerCertificate=True";
        }

        
        public void Add(string name, string category, decimal price) // public void Add(Product product)
        {
            SqlConnection sqlConnection = new SqlConnection(this.connectionStr);

            string query = $"INSERT INTO products(name, category, price) VALUES ('{name}', '{category}', '{price}')";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

    }
}