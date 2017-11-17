using System;
using BodegaAdmin.localhost;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormProd : Form
    {
        private WebService1 webService;

        public FormProd()
        {
            InitializeComponent();
            webService = new WebService1();
        }

        private void btnConfirProd_Click(object sender, EventArgs e)
        {
            try
            {
                Products product = new Products();
                string nameProd = edtNameProd.Text;
                double priceProd;

                product.Name = nameProd;
                if (Double.TryParse(edtPriceProd.Text, out priceProd))
                {
                    product.Price = priceProd;
                }

                if (webService.saveProduct(product))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " btnConfirProd");
                throw;
            }
        }

        private void btnCancelProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
