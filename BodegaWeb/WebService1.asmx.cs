using System.Web.Script.Services;
using System.Web.Services;
using ClassLibrary.Controller;
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
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool saveProduct(Products product)
        {
            ProductsController controller = new ProductsController();
            return controller.saveProduct(product) ? true : false;// JsonConvert.ExportToString("Hello World");
        }

        [WebMethod]
        public bool saveSale()
        {
            return false;
        }

    }
}
