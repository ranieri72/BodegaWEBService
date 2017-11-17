using BodegaAdmin.localhost;
using System;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormMain : Form
    {
        private WebService1 webService;

        public FormMain()
        {
            InitializeComponent();
            webService = new WebService1();
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            FormProd formProd = new FormProd();
            formProd.ShowDialog();
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {

        }

        private void btnListProd_Click(object sender, EventArgs e)
        {

        }
    }
}
