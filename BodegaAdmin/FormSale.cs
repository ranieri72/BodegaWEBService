using BodegaAdmin.WebReferenceLocal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormSale : Form
    {
        private WebService1 webService;
        private Sales sale;

        public FormSale(Sales s)
        {
            try
            {
                InitializeComponent();
                webService = new WebService1();
                sale = s;
                GetSaleInfo();
                ListSaleItems();
                PopulateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopulateListBox()
        {
            if (FormMain.listProducts != null && FormMain.listProducts.Count > 0)
            {
                foreach (Products p in FormMain.listProducts)
                {
                    listBoxProducts.Items.Add(String.Format("R${0} - {1}", p.Price, p.Name));
                }
            }
        }

        private void GetSaleInfo()
        {
            try
            {
                sale = webService.SelectCompleteSale(sale);
                if (sale != null)
                {
                    lbIdSale.Text = sale.Id.ToString();
                    lbOpenedSale.Text = sale.Open.ToString();
                    lbUserSale.Text = sale.User.Login;
                    lbOpenDateSale.Text = sale.OpenedDateTime.ToString();
                    lbCloseDateSale.Text = sale.ClosedDateTime.ToString();
                    double total = 0;
                    foreach (SaleItems item in sale.ListSaleItems)
                    {
                        total += item.UnitPrice * item.Qtd;
                    }
                    lbTotalSale.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Erro na busca dos dados da venda no servidor!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ListSaleItems()
        {
            try
            {
                if (sale.ListSaleItems.Length > 0)
                {
                    List<Object> listSaleItems = new List<Object>(sale.ListSaleItems);
                    string[] columnName = { "qtd", "unitPrice", "product" };
                    int[] columnWidth = { 50, 50, 300 };
                    listViewSaleItems = GenerateList.GenerateListView(listViewSaleItems, listSaleItems, columnName, columnWidth);
                }
                else
                {
                    MessageBox.Show("Venda sem itens!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDeleteSaleItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaleItems item = CheckSaleItem();
                if (item != null)
                {
                    if (webService.DeleteSaleItem(item))
                    {
                        MessageBox.Show("Item deletado com sucesso!");
                        listViewSaleItems.Items.Remove(listViewSaleItems.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar o item.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private SaleItems CheckSaleItem()
        {
            try
            {
                if (listViewSaleItems.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewSaleItems.SelectedItems[0];
                    SaleItems itemSale = new SaleItems();
                    bool error = false;

                    if (int.TryParse(item.SubItems[0].Text, out int qtdItem))
                    {
                        itemSale.Qtd = qtdItem;
                    }
                    else
                    {
                        error = true;
                    }

                    if (double.TryParse(item.SubItems[1].Text, out double unitPrice))
                    {
                        itemSale.UnitPrice = unitPrice;
                    }
                    else
                    {
                        error = true;
                    }
                    itemSale.Product.Name = item.SubItems[2].Text;

                    if (!error)
                    {
                        return itemSale;
                    }
                    else
                    {
                        MessageBox.Show("Item inválido!");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item.");
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
                FormMain.listProducts = new List<Object>(webService.ListProducts());
                PopulateListBox();
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
                SaleItems item = GenerateSaleItem();
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

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaleItems item = GenerateSaleItem();
                item.Qtd = 1;
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

        private SaleItems GenerateSaleItem()
        {
            int ListProdIndex = listBoxProducts.SelectedIndex;
            Products product = (Products)FormMain.listProducts[ListProdIndex];

            SaleItems item = new SaleItems
            {
                Product = product,
                Sale = sale
            };
            return item;
        }
    }
}
