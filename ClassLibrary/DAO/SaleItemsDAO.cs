using ClassLibrary.Model;
using Npgsql;
using System;

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
                string sql = "UPDATE negocio.itensvenda SET precounit = @unitPrice, qtd = @qtd WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", saleItem.Id));
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
                string sql = "DELETE FROM negocio.itensvenda WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", saleItem.Id));

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

        public void ChangeQtdSaleItem(SaleItems saleItem, int quantity)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.itensvenda SET qtd = qtd + @quantity WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", saleItem.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@quantity", quantity));

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
    }
}
