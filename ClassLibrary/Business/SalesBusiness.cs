using ClassLibrary.DAO;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;

namespace ClassLibrary.Business
{
    public class SalesBusiness
    {

        // Sales
        
        public Sales SaveSale(Sales sale)
        {
            try
            {
                SalesDAO dao = new SalesDAO();
                SaleItemsDAO itemsDAO = new SaleItemsDAO();

                if (sale != null)
                {
                    sale.OpenedDateTime = DateTime.Now;
                    sale = dao.InsertSale(sale);
                    foreach(SaleItems item in sale.ListSaleItems)
                    {
                        item.Sale = sale;
                        itemsDAO.InsertSaleItem(item);
                    }
                    return sale;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool DeleteSale(Sales sale)
        {
            try
            {
                SalesDAO dao = new SalesDAO();
                SaleItemsDAO itemsDAO = new SaleItemsDAO();
                UserDAO userDAO = new UserDAO();
                User u;

                if (sale != null)
                {
                    u = userDAO.CheckLogin(sale.User);
                    if (u == null)
                    {
                        return false;
                    }
                    if (u.Permission != User.admin)
                    {
                        if (!dao.CheckUserPermission(sale))
                        {
                            return false;
                        }
                    }
                    itemsDAO.DeleteSaleItem(sale);
                    dao.DeleteSale(sale);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Sales> ListSales(User user)
        {
            try
            {
                SalesDAO dao = new SalesDAO();
                UserDAO userDAO = new UserDAO();
                User u;

                if (user != null)
                {
                    u = userDAO.CheckLogin(user);
                    if (u == null)
                    {
                        return null;
                    }
                    if (u.Permission == User.admin)
                    {
                        return dao.ListSales();
                    }
                    else
                    {
                        return dao.ListSales(u);
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Sales> ListSales(User user, bool open)
        {
            try
            {
                SalesDAO dao = new SalesDAO();
                UserDAO userDAO = new UserDAO();
                User u;

                if (user != null)
                {
                    u = userDAO.CheckLogin(user);
                    if (u == null)
                    {
                        return null;
                    }
                    if (u.Permission == User.admin)
                    {
                        return dao.ListSales(open);
                    }
                    else
                    {
                        return dao.ListSales(u, open);
                    }   
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ChangeOpenedSale(Sales sale, bool open)
        {
            try
            {
                SalesDAO dao = new SalesDAO();
                UserDAO userDAO = new UserDAO();
                User u;

                if (sale != null)
                {
                    u = userDAO.CheckLogin(sale.User);
                    if (u == null)
                    {
                        return false;
                    }
                    if (u.Permission != User.admin)
                    {
                        if (!dao.CheckUserPermission(sale))
                        {
                            return false;
                        }
                    }
                    dao.ChangeOpenedSale(sale, open);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // SaleItem

        public bool SaveSaleItem(SaleItems item)
        {
            try
            {
                SalesDAO salesDAO = new SalesDAO();
                SaleItemsDAO itemsDAO = new SaleItemsDAO();
                ProductsDAO productsDAO = new ProductsDAO();
                UserDAO userDAO = new UserDAO();
                Products p;

                if (item != null)
                {
                    if (userDAO.CheckLogin(item.Sale.User) == null)
                    {
                        return false;
                    }
                    if (!salesDAO.CheckUserPermission(item.Sale))
                    {
                        return false;
                    }
                    p = productsDAO.SelectProduct(item.Product);
                    if (p == null)
                    {
                        return false;
                    }
                    if (item.Qtd < 1)
                    {
                        item.Qtd = 1;
                    }
                    if (itemsDAO.ChangeQtdSaleItem(item, item.Qtd) == 0)
                    {
                        item.UnitPrice = p.Price;
                        itemsDAO.InsertSaleItem(item);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IncreaseQtdSaleItem(SaleItems item)
        {
            try
            {
                SalesDAO salesDAO = new SalesDAO();
                SaleItemsDAO itemsDAO = new SaleItemsDAO();
                ProductsDAO productsDAO = new ProductsDAO();
                UserDAO userDAO = new UserDAO();
                Products p;

                if (item != null)
                {
                    if (userDAO.CheckLogin(item.Sale.User) == null)
                    {
                        return false;
                    }
                    if (!salesDAO.CheckUserPermission(item.Sale))
                    {
                        return false;
                    }
                    p = productsDAO.SelectProduct(item.Product);
                    if (p == null)
                    {
                        return false;
                    }
                    if (itemsDAO.IncreaseQtdSaleItem(item) > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
