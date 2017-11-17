using System;
using ClassLibrary.Model;
using Npgsql;
using System.Collections.Generic;

namespace ClassLibrary.DAO
{
    public class ProductsDAO
    {
        public void insertProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {   
                string sql = "INSERT INTO negocio.produtos (nome, precosugerido) VALUES (:name, @price)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("name", product.Name));
                cmd.Parameters.Add(new NpgsqlParameter("@price", product.Price));
                
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException npgEx)
            {
                Console.WriteLine(npgEx.Message + " insertProduct");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " insertProduct");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Products> selectProduct()
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Products> listProducts;
            Products product;
            try
            {
                string sql = "SELECT nome, precosugerido FROM negocio.produtos ORDER BY nome ASC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listProducts = new List<Products>();
                while (dataReader.Read())
                {
                    product = new Products();
                    product.Name = dataReader.GetString(dataReader.GetOrdinal("nome"));
                    product.Price = dataReader.GetDouble(dataReader.GetOrdinal("precosugerido"));
                    listProducts.Add(product);
                }
                return listProducts;
            }
            catch (NpgsqlException npgEx)
            {
                Console.WriteLine(npgEx.Message + " insertProduct");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " insertProduct");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 countProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 1;
            try
            {
                string sql = "SELECT COUNT(*) AS count FROM negocio.produtos WHERE nome = :name";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                
                cmd.Parameters.Add(new NpgsqlParameter("name", product.Name));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                Console.WriteLine(npgEx.Message + " countProduct");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " countProduct");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
