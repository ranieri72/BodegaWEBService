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
            this.tabControl1.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageSales);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 738);
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
            this.tabPageProducts.Size = new System.Drawing.Size(552, 712);
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
            this.btnDeleteProd.Location = new System.Drawing.Point(12, 163);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteProd.TabIndex = 3;
            this.btnDeleteProd.Text = "Excluir Produto";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.BtnDeleteProd_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(12, 98);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateProd.TabIndex = 2;
            this.btnUpdateProd.Text = "Alterar Produto";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            this.btnUpdateProd.Click += new System.EventHandler(this.BtnUpdateProd_Click);
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(12, 34);
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
            this.listViewProducts.Size = new System.Drawing.Size(423, 700);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Location = new System.Drawing.Point(4, 22);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(942, 552);
            this.tabPageSales.TabIndex = 1;
            this.tabPageSales.Text = "Vendas";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "FormMain";
            this.Text = "BodegaAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

