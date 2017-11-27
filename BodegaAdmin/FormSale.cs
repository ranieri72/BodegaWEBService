using BodegaAdmin.localhost;
using System;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormSale : Form
    {
        private WebService1 webService;
        private Sales sale;

        public FormSale(Sales s)
        {
            InitializeComponent();
            webService = new WebService1();
            sale = s;
        }

        private void BtnDeleteSaleItem_Click(object sender, EventArgs e)
        {

        }
    }
}
