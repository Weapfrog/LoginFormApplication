using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form_App.Core
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly SqlConnection connection;
        public DatabaseHelper()
        {
            this.connection = new SqlConnection(@"///");
        }
        public (int RowCount, bool Success, string Message) GetLogin(Dictionary<string, dynamic> parameters)
        {

            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Users";
                cmd.Connection = connection;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var UserID = reader.GetInt32(0);
                    var Username = reader.GetString(1);
                    var Password = reader.GetString(2);

                    if (Username == parameters["Username"] && Password == parameters["Password"])
                    {
                        this.connection.Close();
                        this.connection.Close();
                        return (1, true, "Success!");
                    }
                }

            }
            catch (Exception ex)
            {
                this.connection.Close();
                this.connection.Close();
                return (-1, false, ex.ToString());
            }
            this.connection.Close();
            this.connection.Close();
            return (-1, false, "Failed!");
        }
        public (int RowCount, bool Success, string Message, List<Product> db) Search(string value,int category)
        {
            string selectedCategory="ProductName";
            if (category == 0)
                selectedCategory = "ProductName";
            else if (category == 1)
                selectedCategory = "ProductCategory";
            List<Product> db = new List<Product>();
            string query = "SELECT * FROM Products WHERE " + selectedCategory + " LIKE '%" + value + "%';";
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var ProductID = reader.GetInt32(0);
                    var ProductName = reader.GetString(1);
                    var ProductCategory = reader.GetString(2);

                    Product product = new Product()
                    {
                        ProductID = ProductID,
                        ProductName = ProductName,
                        ProductCategory = ProductCategory
                    };
                    db.Add(product);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                return (-1, false, "Query failed. \n " + ex.ToString(), db);
            }

            connection.Close();
            return (1, true, "Query ended succesfully.", db);
        }
        public (int RowCount, bool Success, string Message) Insert(Dictionary<string, dynamic> parameters)
        {
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }
                string query = @"INSERT INTO Users(Username,Password) VALUES(@Username,@Password)";
                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }

                cmd.CommandText = query;
                cmd.Connection = this.connection;

                var execute = cmd.ExecuteNonQuery();
                if (execute == 1)
                    return (execute, true, "Başarıyla eklendi!");
                else
                    return (execute, false, "Bir hata meydana geldi!");

                this.connection.Close();
                this.connection.Dispose();

            }
            catch (Exception ex)
            {
                return (-1, false, ex.ToString());
            }
        }
        public (int RowCount, bool Success, string Message) InsertProduct(Dictionary<string, dynamic> parameters)
        {
            if (this.connection.State == System.Data.ConnectionState.Closed)
                this.connection.Open();
            string query = "INSERT INTO Products(ProductName,ProductCategory) VALUES(@ProductName,@ProductCategory);";
            SqlCommand cmd = new SqlCommand();
            foreach (var item in parameters)
            {
                cmd.Parameters.Add($"{item.Key}", item.Value);
            }
            cmd.CommandText = query;
            cmd.Connection = connection;

            var exception = cmd.ExecuteNonQuery();

            if (exception == 1)
            {
                return (1, true, "Product added succesfully.");
            }
            else
            {
                connection.Close();
                connection.Dispose();
                return (-1, false, "Failed.");
            }
            connection.Close();
            connection.Dispose();

        }
        public (int RowCount, bool Success, string Message) DeleteSelected(int value)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("ProductID", value);
                cmd.CommandText = query;
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();

                if (exception == 1)
                {
                    return (exception, true, "Deleted succesfully.");
                }
                else
                {
                    return (exception, false, "Failed.");
                }
            }
            catch (Exception ex)
            {
                return (-1, false, ex.ToString());
                
            }

            connection.Close();
            connection.Dispose();
        }
    }
}
