namespace BodegaAdmin
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.btnListProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.edtQtdProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtIdSale = new System.Windows.Forms.TextBox();
            this.btnCreateSaleItem = new System.Windows.Forms.Button();
            this.edtIdProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.btnListSale = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnChangeSale = new System.Windows.Forms.Button();
            this.btnOpenSale = new System.Windows.Forms.Button();
            this.listViewSales = new System.Windows.Forms.ListView();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnIncreaseProd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageSales);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.btnListProd);
            this.tabPageProducts.Controls.Add(this.btnDeleteProd);
            this.tabPageProducts.Controls.Add(this.btnUpdateProd);
            this.tabPageProducts.Controls.Add(this.btnSaveProd);
            this.tabPageProducts.Controls.Add(this.listViewProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(556, 701);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Produtos";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // btnListProd
            // 
            this.btnListProd.Location = new System.Drawing.Point(12, 636);
            this.btnListProd.Name = "btnListProd";
            this.btnListProd.Size = new System.Drawing.Size(102, 23);
            this.btnListProd.TabIndex = 4;
            this.btnListProd.Text = "Listar Produtos";
            this.btnListProd.UseVisualStyleBackColor = true;
            this.btnListProd.Click += new System.EventHandler(this.BtnListProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(12, 147);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteProd.TabIndex = 3;
            this.btnDeleteProd.Text = "Excluir Produto";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.BtnDeleteProd_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(12, 82);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateProd.TabIndex = 2;
            this.btnUpdateProd.Text = "Alterar Produto";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            this.btnUpdateProd.Click += new System.EventHandler(this.BtnUpdateProd_Click);
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(12, 18);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(102, 23);
            this.btnSaveProd.TabIndex = 1;
            this.btnSaveProd.Text = "Cadastrar Produto";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            this.btnSaveProd.Click += new System.EventHandler(this.BtnSaveProd_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProducts.Location = new System.Drawing.Point(123, 6);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(427, 689);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.btnIncreaseProd);
            this.tabPageSales.Controls.Add(this.edtQtdProd);
            this.tabPageSales.Controls.Add(this.label3);
            this.tabPageSales.Controls.Add(this.label2);
            this.tabPageSales.Controls.Add(this.edtIdSale);
            this.tabPageSales.Controls.Add(this.btnCreateSaleItem);
            this.tabPageSales.Controls.Add(this.edtIdProd);
            this.tabPageSales.Controls.Add(this.label1);
            this.tabPageSales.Controls.Add(this.btnCreateSale);
            this.tabPageSales.Controls.Add(this.btnListSale);
            this.tabPageSales.Controls.Add(this.btnDeleteSale);
            this.tabPageSales.Controls.Add(this.btnChangeSale);
            this.tabPageSales.Controls.Add(this.btnOpenSale);
            this.tabPageSales.Controls.Add(this.listViewSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 22);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(556, 701);
            this.tabPageSales.TabIndex = 1;
            this.tabPageSales.Text = "Vendas";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // edtQtdProd
            // 
            this.edtQtdProd.Location = new System.Drawing.Point(51, 499);
            this.edtQtdProd.Name = "edtQtdProd";
            this.edtQtdProd.Size = new System.Drawing.Size(66, 20);
            this.edtQtdProd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "qtdProd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "codSale";
            // 
            // edtIdSale
            // 
            this.edtIdSale.Location = new System.Drawing.Point(51, 417);
            this.edtIdSale.Name = "edtIdSale";
            this.edtIdSale.Size = new System.Drawing.Size(66, 20);
            this.edtIdSale.TabIndex = 13;
            // 
            // btnCreateSaleItem
            // 
            this.btnCreateSaleItem.Location = new System.Drawing.Point(6, 525);
            this.btnCreateSaleItem.Name = "btnCreateSaleItem";
            this.btnCreateSaleItem.Size = new System.Drawing.Size(111, 23);
            this.btnCreateSaleItem.TabIndex = 12;
            this.btnCreateSaleItem.Text = "Novo Item";
            this.btnCreateSaleItem.UseVisualStyleBackColor = true;
            this.btnCreateSaleItem.Click += new System.EventHandler(this.BtnCreateSaleItem_Click);
            // 
            // edtIdProd
            // 
            this.edtIdProd.Location = new System.Drawing.Point(51, 443);
            this.edtIdProd.Name = "edtIdProd";
            this.edtIdProd.Size = new System.Drawing.Size(66, 20);
            this.edtIdProd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "codProd";
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Location = new System.Drawing.Point(6, 337);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(111, 23);
            this.btnCreateSale.TabIndex = 9;
            this.btnCreateSale.Text = "Nova Venda";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.BtnCreateSale_Click);
            // 
            // btnListSale
            // 
            this.btnListSale.Location = new System.Drawing.Point(6, 637);
            this.btnListSale.Name = "btnListSale";
            this.btnListSale.Size = new System.Drawing.Size(111, 23);
            this.btnListSale.TabIndex = 8;
            this.btnListSale.Text = "Listar Vendas";
            this.btnListSale.UseVisualStyleBackColor = true;
            this.btnListSale.Click += new System.EventHandler(this.BtnListSale_Click);
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Location = new System.Drawing.Point(6, 148);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteSale.TabIndex = 7;
            this.btnDeleteSale.Text = "Excluir Venda";
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.BtnDeleteSale_Click);
            // 
            // btnChangeSale
            // 
            this.btnChangeSale.Location = new System.Drawing.Point(6, 83);
            this.btnChangeSale.Name = "btnChangeSale";
            this.btnChangeSale.Size = new System.Drawing.Size(111, 23);
            this.btnChangeSale.TabIndex = 6;
            this.btnChangeSale.Text = "Abrir/Fechar Venda";
            this.btnChangeSale.UseVisualStyleBackColor = true;
            this.btnChangeSale.Click += new System.EventHandler(this.BtnChangeSale_Click);
            // 
            // btnOpenSale
            // 
            this.btnOpenSale.Location = new System.Drawing.Point(6, 19);
            this.btnOpenSale.Name = "btnOpenSale";
            this.btnOpenSale.Size = new System.Drawing.Size(111, 23);
            this.btnOpenSale.TabIndex = 5;
            this.btnOpenSale.Text = "Visualizar Venda";
            this.btnOpenSale.UseVisualStyleBackColor = true;
            this.btnOpenSale.Click += new System.EventHandler(this.BtnOpenSale_Click);
            // 
            // listViewSales
            // 
            this.listViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSales.Location = new System.Drawing.Point(123, 6);
            this.listViewSales.MultiSelect = false;
            this.listViewSales.Name = "listViewSales";
            this.listViewSales.Size = new System.Drawing.Size(427, 689);
            this.listViewSales.TabIndex = 1;
            this.listViewSales.UseCompatibleStateImageBehavior = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(348, 7);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(147, 13);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Seja bem vindo, fulano de tal.";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(501, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnIncreaseProd
            // 
            this.btnIncreaseProd.Location = new System.Drawing.Point(6, 469);
            this.btnIncreaseProd.Name = "btnIncreaseProd";
            this.btnIncreaseProd.Size = new System.Drawing.Size(111, 23);
            this.btnIncreaseProd.TabIndex = 17;
            this.btnIncreaseProd.Text = "Incrementar +1";
            this.btnIncreaseProd.UseVisualStyleBackColor = true;
            this.btnIncreaseProd.Click += new System.EventHandler(this.BtnIncreaseProd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "FormMain";
            this.Text = "BodegaAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            this.tabPageSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.Button btnListProd;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnSaveProd;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.Button btnListSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.Button btnChangeSale;
        private System.Windows.Forms.Button btnOpenSale;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.TextBox edtIdProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtIdSale;
        private System.Windows.Forms.Button btnCreateSaleItem;
        private System.Windows.Forms.TextBox edtQtdProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncreaseProd;
    }
}

