using BodegaAdmin.localhost;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormMain : Form
    {
        private WebService1 webService;

        public FormMain()
        {
            InitializeComponent();
            listViewProducts.View = View.Details;
            webService = new WebService1();
        }

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
                        MessageBox.Show("Não é possível deletar o produto.");
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
                List<Products> listProducts = new List<Products>(webService.ListProducts());
                string[] columnName = { "ID", "Nome", "Preço" };
                int[] columnWidth = { 50, 300, 50 };
                listViewProducts = GenerateListView(listViewProducts, listProducts, columnName, columnWidth);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ListView GenerateListView(ListView listView, List<Products> listObjects, string[] columnName, int[] columnWidth)
        {
            try
            {
                ListViewItem item;
                int columnIndex = 0;

                listView.Clear();
                PropertyInfo[] props = typeof(Products).GetProperties();

                foreach (PropertyInfo p in props)
                {
                    ColumnHeader col = new ColumnHeader();
                    listView.Columns.Add(col);
                    col.Text = columnName[columnIndex];
                    col.Width = columnWidth[columnIndex];
                    columnIndex++;
                }

                foreach (Products product in listObjects)
                {
                    item = listView.Items.Add("");

                    foreach (PropertyInfo p in props)
                    {
                        if (p == props[0])
                        {
                            item.Text = p.GetValue(product, null).ToString();
                        }
                        else
                        {
                            item.SubItems.Add(p.GetValue(product, null).ToString());
                        }
                    }
                }
                return listView;
            }
            catch (Exception)
            {   
                throw;
            }
        }
    }
}
