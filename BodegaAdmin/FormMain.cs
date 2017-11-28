using BodegaAdmin.localhost;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormMain : Form
    {
        private WebService1 webService;

        public FormMain()
        {
            InitializeComponent();

            String welcome = string.Format("Seja bem vindo, {0}.", Program.user.Login);
            lbWelcome.Text = welcome;
            lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            listViewProducts.View = View.Details;
            listViewSales.View = View.Details;
            webService = new WebService1();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        // Produtos

        private void BtnSaveProd_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            FormProd formProd = new FormProd(p, FormProd.save);
            formProd.ShowDialog();
        }

        private void BtnUpdateProd_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = CheckProd();
                if (p != null)
                {   
                    FormProd formProd = new FormProd(p, FormProd.update);
                    formProd.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteProd_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = CheckProd();
                if (p != null)
                {
                    if (webService.DeleteProduct(p))
                    {
                        MessageBox.Show("Produto deletado com sucesso!");
                        listViewProducts.Items.Remove(listViewProducts.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar o produto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Products CheckProd()
        {
            try
            {
                if (listViewProducts.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewProducts.SelectedItems[0];
                    Products product = new Products();
                    bool error = false;

                    if (long.TryParse(item.SubItems[0].Text, out long idProd))
                    {
                        product.Id = idProd;
                    }
                    else
                    {
                        error = true;
                    }

                    product.Name = item.SubItems[1].Text;

                    if (double.TryParse(item.SubItems[2].Text, out double priceProd))
                    {
                        product.Price = priceProd;
                    }
                    else
                    {
                        error = true;
                    }

                    if (!error)
                    {   
                        return product;
                    }
                    else
                    {
                        MessageBox.Show("Produto inválido!");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto.");
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnListProd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Object> listProducts = new List<Object>(webService.ListProducts());
                string[] columnName = { "ID", "Nome", "Preço" };
                int[] columnWidth = { 50, 300, 50 };
                listViewProducts = GenerateList.GenerateListView(listViewProducts, listProducts, columnName, columnWidth);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Vendas

        private void BtnOpenSale_Click(object sender, EventArgs e)
        {
            try
            {
                Sales s = CheckSale();
                if (s != null)
                {
                    FormSale formSale = new FormSale(s);
                    formSale.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnChangeSale_Click(object sender, EventArgs e)
        {
            try
            {
                Sales s = CheckSale();
                if (s != null)
                {
                    if (webService.ChangeOpenedSale(s, !s.Open))
                    {
                        MessageBox.Show("Venda alterada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar a venda.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                Sales s = CheckSale();
                if (s != null)
                {
                    if (webService.DeleteSale(s))
                    {
                        MessageBox.Show("Venda deletada com sucesso!");
                        listViewSales.Items.Remove(listViewSales.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar a venda.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private Sales CheckSale()
        {
            try
            {
                if (listViewSales.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewSales.SelectedItems[0];
                    Sales sale = new Sales();
                    bool error = false;

                    if (long.TryParse(item.SubItems[0].Text, out long idSale))
                    {
                        sale.Id = idSale;
                    }
                    else
                    {
                        error = true;
                    }

                    sale.Open = item.SubItems[1].Text.Equals("True");
                    sale.User = Program.user;

                    if (!error)
                    {
                        return sale;
                    }
                    else
                    {
                        MessageBox.Show("Venda inválida!");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma venda.");
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnListSale_Click(object sender, EventArgs e)
        {
            try
            {
                List<Object> listSales = new List<Object>(webService.ListAllSales(Program.user));
                string[] columnName = { "ID", "Aberto", "dataabertura", "closedDateTime" };
                int[] columnWidth = { 40, 120, 120, 120 };
                listViewSales = GenerateList.GenerateListView(listViewSales, listSales, columnName, columnWidth);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateSale_Click(object sender, EventArgs e)
        {
            try
            {   
                Sales sale = new Sales
                {
                    User = Program.user
                };
                if (webService.SaveSale(sale) != null)
                {
                    MessageBox.Show("Venda criada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro durante a abertura da venda!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateSaleItem_Click(object sender, EventArgs e)
        {
            try
            {
                Products product = new Products
                {
                    Id = Int32.Parse(edtIdProd.Text)
                };
                Sales sale = new Sales
                {
                    User = Program.user,
                    Id = Int32.Parse(edtIdSale.Text)
                };
                SaleItems item = new SaleItems
                {
                    Qtd = Int32.Parse(edtQtdProd.Text),
                    Product = product,
                    Sale = sale
                };
                if (webService.InsertSaleItem(item))
                {
                    MessageBox.Show("Item salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro durante o cadastro do item!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnIncreaseProd_Click(object sender, EventArgs e)
        {
            try
            {
                Products product = new Products
                {
                    Id = Int32.Parse(edtIdProd.Text)
                };
                Sales sale = new Sales
                {
                    User = Program.user,
                    Id = Int32.Parse(edtIdSale.Text)
                };
                SaleItems item = new SaleItems
                {
                    Product = product,
                    Sale = sale
                };
                if (webService.IncreaseQtdSaleItem(item))
                {
                    MessageBox.Show("Item incrementado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro na incrementação do item!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
