using ClassLibrary.Model;
using Npgsql;
using System;

namespace ClassLibrary.DAO
{
    class UserDAO
    {
        public void InsertUser(User user)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "INSERT INTO sistema.usuario (login, senha, permission) VALUES (:login, :password, @permission)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("login", user.Login));
                cmd.Parameters.Add(new NpgsqlParameter("password", user.Password));
                cmd.Parameters.Add(new NpgsqlParameter("@permission", user.Permission));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao inserir o usuário no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o usuário no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateUser(User user)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "UPDATE sistema.usuario SET login = :login, senha = :password, permission = @permission WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", user.Id));
                cmd.Parameters.Add(new NpgsqlParameter("login", user.Login));
                cmd.Parameters.Add(new NpgsqlParameter("password", user.Password));
                cmd.Parameters.Add(new NpgsqlParameter("@permission", user.Permission));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao atualizar o usuário no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o usuário no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteUser(User user)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "DELETE FROM sistema.usuario WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("@id", user.Id));

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao deletar o usuário no banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar o usuário no banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public User CheckLogin(User user)
        {
            NpgsqlConnection connection = Database.openConnection();
            try
            {
                string sql = "SELECT id, login, senha, permission FROM sistema.usuario WHERE login = :login AND senha = :password";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

                cmd.Parameters.Add(new NpgsqlParameter("login", user.Login));
                cmd.Parameters.Add(new NpgsqlParameter("password", user.Password));

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    user = new User
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                        Login = dataReader.GetString(dataReader.GetOrdinal("login")),
                        Password = dataReader.GetString(dataReader.GetOrdinal("senha")),
                        Permission = dataReader.GetInt32(dataReader.GetOrdinal("permission"))
                    };
                }
                else
                {
                    user = null;
                }
                cmd.Dispose();
                return user;
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Erro ao checar o usuário do banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao checar o usuário do banco de dados! " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
