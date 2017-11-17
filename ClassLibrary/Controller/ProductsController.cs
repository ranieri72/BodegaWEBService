using System;
using ClassLibrary.Model;
using ClassLibrary.DAO;

namespace ClassLibrary.Controller
{
    public class ProductsController
    {
        public bool saveProduct(Products product)
        {
            try
            {
                ProductsDAO dao = new ProductsDAO();
                if (dao.countProduct(product) == 0)
                {
                    dao.insertProduct(product);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " saveProduct");
                throw;
            }
        }
    }
}
