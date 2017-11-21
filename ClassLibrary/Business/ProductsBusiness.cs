using System;
using ClassLibrary.Model;
using ClassLibrary.DAO;
using System.Collections.Generic;

namespace ClassLibrary.Business
{
    public class ProductsBusiness
    {
        public bool SaveProduct(Products product)
        {
            try
            {
                ProductsDAO dao = new ProductsDAO();
                bool error = false;

                if (product != null)
                {
                    if (product.Name.Equals(""))
                    {
                        error = true;
                    }
                    if (!error)
                    {
                        if (dao.CountProductName(product) == 0)
                        {
                            dao.InsertProduct(product);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o produto no banco de dados! " + e.Message);
            }
        }

        public bool UpdateProduct(Products product)
        {
            ProductsDAO dao = new ProductsDAO();
            Products p;
            bool error = false;

            if (product != null)
            {
                p = dao.SelectProduct(product);
                if (p != null)
                {
                    if (!product.Name.Equals(""))
                    {
                        if (!product.Name.Equals(p.Name))
                        {
                            if (dao.CountProductName(product) != 0)
                            {
                                error = true;
                            }
                        }
                    }

                    if (!error)
                    {
                        dao.UpdateProduct(product);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DeleteProduct(Products product)
        {
            ProductsDAO dao = new ProductsDAO();
            bool error = false;
            if (product != null)
            {
                if (dao.CountProductOrder(product) > 0)
                {
                    error = true;
                }
                if (dao.CountProductSales(product) > 0)
                {
                    error = true;
                }

                if (!error)
                {
                    dao.DeleteProduct(product);
                }
                else
                {
                    dao.ChangeProductActivated(product, false);
                }
                return true;
            }
            return false;
        }

        public List<Products> ListProducts()
        {
            ProductsDAO dao = new ProductsDAO();
            return dao.ListProducts();
        }
    }
}
