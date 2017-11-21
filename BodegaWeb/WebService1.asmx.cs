using System.Web.Script.Services;
using System.Web.Services;
using ClassLibrary.Business;
using ClassLibrary.Model;
using System.Collections.Generic;
using System;

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
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            //return JsonConvert.ExportToString("Hello World");
            return "Hello World";
        }

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

        [WebMethod]
        public bool SaveSale()
        {
            Sales sale = new Sales();

            SalesBusiness business = new SalesBusiness();
            return business.SaveSale(sale);
        }
    }
}
