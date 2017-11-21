using ClassLibrary.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ClassLibrary.DAO
{
    public class SalesDAO
    {
        public void InsertSale(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "INSERT INTO negocio.vendas (dataabertura, horaabertura) VALUES (:openedDateTime, :openedDateTime)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("openedDateTime", sale.OpenedDateTime));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao inserir a venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir a venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteSale(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "DELETE FROM negocio.vendas WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", sale.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao deletar a venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar a venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Sales SelectSale(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento FROM negocio.vendas WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", sale.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"))
                    };
                }
                else
                {
                    sale = null;
                }
                cmd.Dispose();
                return sale;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao selecionar a venda do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar a venda do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Sales> ListSales()
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Sales> listSales;
            Sales sale;
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento FROM negocio.vendas WHERE aberto = true ORDER BY datafechamento DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSales = new List<Sales>();
                while (dataReader.Read())
                {
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"))
                    };
                    listSales.Add(sale);
                }
                cmd.Dispose();
                return listSales;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar a venda do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar a venda do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ChangeOpenedSale(Sales sale, bool open)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE negocio.vendas SET aberto = :opened WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", sale.Id));
                cmd.Parameters.Add(new NpgsqlParameter("opened", open));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar a venda no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar a venda no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
