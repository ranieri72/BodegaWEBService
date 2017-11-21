using System;
using BodegaAdmin.localhost;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormProd : Form
    {
        public static readonly int save = 0;
        public static readonly int update = 1;

        private WebService1 webService;
        private Products product;
        private int codForm;
        
        public FormProd(Products p, int cod)
        {
            InitializeComponent();
            product = p;
            codForm = (product == null) ? 0 : cod;
            ReadCod();
            webService = new WebService1();
        }

        private void ReadCod()
        {
            string text = "";
            switch (codForm)
            {
                case 0:
                    text = "Salvar Produto";
                    break;
                case 1:
                    text = "Alterar Produto";
                    ChangeTextFields();
                    break;
                default:
                    text = "Salvar Produto";
                    break;
            }
            Text = text;
            btnConfirProd.Text = text;
        }

        private void BtnConfirProd_Click(object sender, EventArgs e)
        {
            try
            {   
                bool error = false;

                string nameProd = edtNameProd.Text;
                if (!nameProd.Equals(""))
                {
                    product.Name = nameProd;
                }
                else
                {
                    error = true;
                }

                if (Double.TryParse(edtPriceProd.Text, out double priceProd))
                {
                    product.Price = priceProd;
                }
                else
                {
                    error = true;
                }

                if (!error)
                {
                    switch (codForm)
                    {
                        case 0:
                            SaveProd();
                            break;
                        case 1:
                            UpdateProd();
                            break;
                        default:
                            SaveProd();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Campos inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveProd()
        {
            try
            {
                if (webService.SaveProduct(product))
                {   
                    MessageBox.Show("Produto salvo com sucesso!");
                    ErraseFields();
                }
                else
                {
                    MessageBox.Show("Não é possível salvar o produto.");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar ao WebService! " + e.Message);
            }
        }

        private void UpdateProd()
        {
            try
            {
                if (webService.UpdateProduct(product))
                {   
                    MessageBox.Show("Produto atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não é possível atualizar o produto.");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar ao WebService! " + e.Message);
            }
        }

        private void ErraseFields()
        {
            edtNameProd.Text = "";
            edtPriceProd.Text = "";
        }

        private void ChangeTextFields()
        {
            try
            {
                if (product != null)
                {
                    edtNameProd.Text = product.Name;
                    edtPriceProd.Text = product.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Produto nulo! Você será direcionado para a janela de Salvar Produto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}