using ClassLibrary.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ClassLibrary.DAO
{
    public class SaleItemsDAO
    {
        public void InsertSaleItem(SaleItems saleItem)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "INSERT INTO negocio.itensvenda (precounit, qtd, idproduto, idvenda) VALUES (@unitPrice, @qtd, @idProduct, @idSale)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@unitPrice", saleItem.UnitPrice));
                cmd.Parameters.Add(new NpgsqlParameter("@qtd", saleItem.Qtd));
                cmd.Parameters.Add(new NpgsqlParameter("@idProduct", saleItem.Product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", saleItem.Sale.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao inserir o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateSaleItem(SaleItems saleItem)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.itensvenda SET precounit = @unitPrice, qtd = @qtd WHERE idvenda = @idSale AND idproduto = @idProduct";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idProduct", saleItem.Product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", saleItem.Sale.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@unitPrice", saleItem.UnitPrice));
                cmd.Parameters.Add(new NpgsqlParameter("@qtd", saleItem.Qtd));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteSaleItem(SaleItems saleItem)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "DELETE FROM negocio.itensvenda WHERE idvenda = @idSale AND idproduto = @idProduct";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idProduct", saleItem.Product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", saleItem.Sale.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao deletar o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteSaleItem(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "DELETE FROM negocio.itensvenda WHERE idvenda = @idSale";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idSale", sale.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao deletar o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<SaleItems> ListSaleItems(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            List<SaleItems> listSaleItems;
            SaleItems saleItems;
            Products product;
            try
            {
                string sql = "SELECT precounit, qtd, idproduto, idvenda FROM negocio.itensvenda WHERE idvenda = @idSale";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", sale.Id));
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSaleItems = new List<SaleItems>();
                while (dataReader.Read())
                {
                    product = new Products
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("idproduto"))
                    };
                    saleItems = new SaleItems
                    {
                        UnitPrice = dataReader.GetDouble(dataReader.GetOrdinal("precounit")),
                        Qtd = dataReader.GetInt32(dataReader.GetOrdinal("qtd")),
                        Product = product
                    };
                    listSaleItems.Add(saleItems);
                }
                cmd.Dispose();
                return listSaleItems;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar os itens da venda do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os itens da venda do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 ChangeQtdSaleItem(SaleItems saleItem, int quantity)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.itensvenda SET qtd = qtd + @quantity WHERE idvenda = @idSale AND idproduto = @idProduct";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idProduct", saleItem.Product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", saleItem.Sale.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@quantity", quantity));

                Int32 count = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Int32 IncreaseQtdSaleItem(SaleItems saleItem)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.itensvenda SET qtd = qtd + 1 WHERE idvenda = @idSale AND idproduto = @idProduct";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idProduct", saleItem.Product.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@idSale", saleItem.Sale.Id));

                Int32 count = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return count;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o item da venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
