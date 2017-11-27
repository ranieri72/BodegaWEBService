using System.Web.Script.Services;
using System.Web.Services;
using System.Collections.Generic;

using ClassLibrary.Business;
using ClassLibrary.Model;

namespace BodegaWeb
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            //return JsonConvert.ExportToString("Hello World");
            return "Hello World";
        }

        // Products

        [WebMethod]
        public bool SaveProduct(Products product)
        {
            ProductsBusiness business = new ProductsBusiness();
            return business.SaveProduct(product);
        }

        [WebMethod]
        public bool UpdateProduct(Products product)
        {
            ProductsBusiness business = new ProductsBusiness();
            return business.UpdateProduct(product);
        }

        [WebMethod]
        public bool DeleteProduct(Products product)
        {
            ProductsBusiness business = new ProductsBusiness();
            return business.DeleteProduct(product);
        }

        [WebMethod]
        public List<Products> ListProducts()
        {
            ProductsBusiness business = new ProductsBusiness();
            return business.ListProducts();
        }

        // Sales

        [WebMethod]
        public Sales SaveSale(Sales sale)
        {
            SalesBusiness business = new SalesBusiness();
            return business.SaveSale(sale);
        }

        [WebMethod]
        public bool DeleteSale(Sales sale)
        {   
            SalesBusiness business = new SalesBusiness();
            return business.DeleteSale(sale);
        }

        [WebMethod]
        public List<Sales> ListAllSales(User user)
        {
            SalesBusiness business = new SalesBusiness();
            return business.ListSales(user);
        }

        [WebMethod]
        public List<Sales> ListSales(User user, bool open)
        {
            SalesBusiness business = new SalesBusiness();
            return business.ListSales(user, open);
        }

        [WebMethod]
        public bool ChangeOpenedSale(Sales sale, bool open)
        {
            SalesBusiness business = new SalesBusiness();
            return business.ChangeOpenedSale(sale, open);
        }

        // SaleItems

        [WebMethod]
        public bool InsertSaleItem(SaleItems item)
        {
            SalesBusiness business = new SalesBusiness();
            return business.SaveSaleItem(item);
        }

        [WebMethod]
        public bool IncreaseQtdSaleItem(SaleItems item)
        {
            SalesBusiness business = new SalesBusiness();
            return business.IncreaseQtdSaleItem(item);
        }

        // User

        [WebMethod]
        public bool InsertUser(User user)
        {
            UserBusiness business = new UserBusiness();
            return business.InsertUser(user);
        }

        [WebMethod]
        public bool UpdateUser(User user)
        {
            UserBusiness business = new UserBusiness();
            return business.UpdateUser(user);
        }

        [WebMethod]
        public bool DeleteUser(User user)
        {
            UserBusiness business = new UserBusiness();
            return business.DeleteUser(user);
        }

        [WebMethod]
        public User CheckLogin(User user)
        {
            UserBusiness business = new UserBusiness();
            return business.CheckLogin(user);
        }
    }
}
