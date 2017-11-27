using ClassLibrary.DAO;
using ClassLibrary.Model;
using System;

namespace ClassLibrary.Business
{
    public class UserBusiness
    {

        public bool InsertUser(User user)
        {
            try
            {
                UserDAO dao = new UserDAO();

                if (user != null)
                {
                    dao.InsertUser(user);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                UserDAO dao = new UserDAO();

                if (user != null)
                {
                    dao.UpdateUser(user);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool DeleteUser(User user)
        {
            try
            {
                UserDAO dao = new UserDAO();

                if (user != null)
                {
                    dao.DeleteUser(user);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public User CheckLogin(User user)
        {
            try
            {
                UserDAO dao = new UserDAO();

                if (user != null)
                {   
                    return dao.CheckLogin(user);
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
