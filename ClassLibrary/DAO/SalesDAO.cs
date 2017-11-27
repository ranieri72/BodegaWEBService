using ClassLibrary.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ClassLibrary.DAO
{
    public class SalesDAO
    {
        public Sales InsertSale(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "WITH rows AS (INSERT INTO negocio.vendas (dataabertura, horaabertura, iduser) VALUES (:openedDateTime, :openedDateTime, @iduser) RETURNING id) "
                    + "SELECT id FROM rows;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("openedDateTime", sale.OpenedDateTime));
                cmd.Parameters.Add(new NpgsqlParameter("@iduser", sale.User.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sale.Id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                }
                cmd.Dispose();
                return sale;
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
                string sql = "SELECT id, aberto, dataabertura, datafechamento, iduser FROM negocio.vendas WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", sale.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    User user = new User
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("iduser"))
                    };
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        User = user
                    };
                    if (!sale.Open)
                    {
                        sale.ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"));
                    }
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

        public bool CheckUserPermission(Sales sale)
        {
            NpgsqlConnection connection = Database.openConnection();
            Int32 count = 0;
            try
            {
                string sql = "SELECT COUNT(*) AS count FROM negocio.vendas WHERE id = @idSale AND iduser = @iduser";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idSale", sale.Id));
                cmd.Parameters.Add(new NpgsqlParameter("@iduser", sale.User.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    count = dataReader.GetInt32(dataReader.GetOrdinal("count"));
                }
                cmd.Dispose();
                return count == 1 ? true : false;
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
            User user;
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento, iduser FROM negocio.vendas ORDER BY datafechamento DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSales = new List<Sales>();
                while (dataReader.Read())
                {
                    user = new User
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("iduser"))
                    };
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        User = user
                    };
                    if (!sale.Open)
                    {
                        sale.ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"));
                    }
                    listSales.Add(sale);
                }
                cmd.Dispose();
                return listSales;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Sales> ListSales(User user)
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Sales> listSales;
            Sales sale;
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento, iduser FROM negocio.vendas WHERE iduser = @iduser ORDER BY datafechamento DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idUser", user.Id));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSales = new List<Sales>();
                while (dataReader.Read())
                {
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        User = user
                    };
                    if (!sale.Open)
                    {
                        sale.ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"));
                    }
                    listSales.Add(sale);
                }
                cmd.Dispose();
                return listSales;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Sales> ListSales(bool open)
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Sales> listSales;
            Sales sale;
            User user;
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento, iduser FROM negocio.vendas WHERE aberto = :opened ORDER BY datafechamento DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.Add(new NpgsqlParameter("opened", open));
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSales = new List<Sales>();
                while (dataReader.Read())
                {
                    user = new User
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("iduser"))
                    };
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        User = user
                    };
                    if (!open)
                    {
                        sale.ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"));
                    }
                    listSales.Add(sale);
                }
                cmd.Dispose();
                return listSales;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Sales> ListSales(User user, bool open)
        {
            NpgsqlConnection connection = Database.openConnection();
            List<Sales> listSales;
            Sales sale;
            try
            {
                string sql = "SELECT id, aberto, dataabertura, datafechamento, iduser FROM negocio.vendas WHERE aberto = :opened AND iduser = @iduser ORDER BY datafechamento DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@idUser", user.Id));
                cmd.Parameters.Add(new NpgsqlParameter("opened", open));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                listSales = new List<Sales>();
                while (dataReader.Read())
                {   
                    sale = new Sales
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Open = dataReader.GetBoolean(dataReader.GetOrdinal("aberto")),
                        OpenedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("dataabertura")),
                        User = user
                    };
                    if (!open)
                    {
                        sale.ClosedDateTime = dataReader.GetDateTime(dataReader.GetOrdinal("datafechamento"));
                    }
                    listSales.Add(sale);
                }
                cmd.Dispose();
                return listSales;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar as vendas do banco de dados! " + e.Message);
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
