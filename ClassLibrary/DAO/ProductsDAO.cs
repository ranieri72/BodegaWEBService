using System;
using ClassLibrary.Model;
using Npgsql;
using System.Collections.Generic;

namespace ClassLibrary.DAO
{
    public class ProductsDAO
    {
        public void InsertProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {   
                string sql = "INSERT INTO negocio.produtos (nome, precosugerido) VALUES (:name, @price)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("name", product.Name));
                cmd.Parameters.Add(new NpgsqlParameter("@price", product.Price));
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao inserir o produto no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o produto no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.produtos SET nome = :name, precosugerido = @price WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("name", product.Name));
                cmd.Parameters.Add(new NpgsqlParameter("@price", product.Price));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o produto no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o produto no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "DELETE FROM negocio.produtos WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao deletar o produto no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar o produto no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Products SelectProduct(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "SELECT id, nome, precosugerido FROM negocio.produtos WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                
                if (dataReader.Read())
                {
                    product = new Products
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Name = dataReader.GetString(dataReader.GetOrdinal("nome")),
                        Price = dataReader.GetDouble(dataReader.GetOrdinal("precosugerido"))
                    };
                }
                else
                {
                    product = null;
                }
                cmd.Dispose();
                return product;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao selecionar o produto do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar o produto do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Products> ListProducts()
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Products> listProducts;
            Products product;
            try
            {
                string sql = "SELECT id, nome, precosugerido FROM negocio.produtos WHERE ativado = true ORDER BY nome ASC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listProducts = new List<Products>();
                while (dataReader.Read())
                {
                    product = new Products
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Name = dataReader.GetString(dataReader.GetOrdinal("nome")),
                        Price = dataReader.GetDouble(dataReader.GetOrdinal("precosugerido"))
                    };
                    listProducts.Add(product);
                }
                cmd.Dispose();
                return listProducts;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar os produtos do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os produtos do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ChangeProductActivated(Products product, bool active)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.produtos SET ativado = :active WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("active", active));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o produto no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o produto no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 CountProductName(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 0;
            try
            {
                string sql = "SELECT COUNT(id) AS count FROM negocio.produtos WHERE nome = :name";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                
                cmd.Parameters.Add(new NpgsqlParameter("name", product.Name));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 CountProductId(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 0;
            try
            {
                string sql = "SELECT COUNT(*) AS count FROM negocio.produtos WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 CountProductSales(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 0;
            try
            {
                string sql = "SELECT COUNT(*) AS count FROM negocio.itensvenda WHERE idproduto = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 CountProductOrder(Products product)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 0;
            try
            {
                string sql = "SELECT COUNT(*) AS count FROM negocio.itenspedido WHERE idproduto = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", product.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao contar o produto do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
