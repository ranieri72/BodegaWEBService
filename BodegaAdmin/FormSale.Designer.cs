namespace BodegaAdmin
{
    partial class FormSale
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
            this.listViewSaleItems = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdSale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOpenedSale = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUserSale = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbOpenDateSale = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCloseDateSale = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalSale = new System.Windows.Forms.Label();
            this.btnDeleteSaleItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSaleItems
            // 
            this.listViewSaleItems.Location = new System.Drawing.Point(12, 70);
            this.listViewSaleItems.Name = "listViewSaleItems";
            this.listViewSaleItems.Size = new System.Drawing.Size(671, 400);
            this.listViewSaleItems.TabIndex = 0;
            this.listViewSaleItems.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // lbIdSale
            // 
            this.lbIdSale.AutoSize = true;
            this.lbIdSale.Location = new System.Drawing.Point(12, 39);
            this.lbIdSale.Name = "lbIdSale";
            this.lbIdSale.Size = new System.Drawing.Size(25, 13);
            this.lbIdSale.TabIndex = 2;
            this.lbIdSale.Text = "115";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // lbOpenedSale
            // 
            this.lbOpenedSale.AutoSize = true;
            this.lbOpenedSale.Location = new System.Drawing.Point(91, 39);
            this.lbOpenedSale.Name = "lbOpenedSale";
            this.lbOpenedSale.Size = new System.Drawing.Size(38, 13);
            this.lbOpenedSale.TabIndex = 4;
            this.lbOpenedSale.Text = "Aberta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuário";
            // 
            // lbUserSale
            // 
            this.lbUserSale.AutoSize = true;
            this.lbUserSale.Location = new System.Drawing.Point(190, 39);
            this.lbUserSale.Name = "lbUserSale";
            this.lbUserSale.Size = new System.Drawing.Size(68, 13);
            this.lbUserSale.TabIndex = 6;
            this.lbUserSale.Text = "Fulano de tal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data de Abertura";
            // 
            // lbOpenDateSale
            // 
            this.lbOpenDateSale.AutoSize = true;
            this.lbOpenDateSale.Location = new System.Drawing.Point(316, 39);
            this.lbOpenDateSale.Name = "lbOpenDateSale";
            this.lbOpenDateSale.Size = new System.Drawing.Size(83, 13);
            this.lbOpenDateSale.TabIndex = 8;
            this.lbOpenDateSale.Text = "15/11/17 21:57";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data de Encerramento";
            // 
            // lbCloseDateSale
            // 
            this.lbCloseDateSale.AutoSize = true;
            this.lbCloseDateSale.Location = new System.Drawing.Point(458, 39);
            this.lbCloseDateSale.Name = "lbCloseDateSale";
            this.lbCloseDateSale.Size = new System.Drawing.Size(83, 13);
            this.lbCloseDateSale.TabIndex = 10;
            this.lbCloseDateSale.Text = "15/11/17 23:35";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total";
            // 
            // lbTotalSale
            // 
            this.lbTotalSale.AutoSize = true;
            this.lbTotalSale.Location = new System.Drawing.Point(632, 39);
            this.lbTotalSale.Name = "lbTotalSale";
            this.lbTotalSale.Size = new System.Drawing.Size(51, 13);
            this.lbTotalSale.TabIndex = 12;
            this.lbTotalSale.Text = "R$ 95,15";
            // 
            // btnDeleteSaleItem
            // 
            this.btnDeleteSaleItem.Location = new System.Drawing.Point(584, 480);
            this.btnDeleteSaleItem.Name = "btnDeleteSaleItem";
            this.btnDeleteSaleItem.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteSaleItem.TabIndex = 13;
            this.btnDeleteSaleItem.Text = "Apagar Item";
            this.btnDeleteSaleItem.UseVisualStyleBackColor = true;
            this.btnDeleteSaleItem.Click += new System.EventHandler(this.BtnDeleteSaleItem_Click);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 515);
            this.Controls.Add(this.btnDeleteSaleItem);
            this.Controls.Add(this.lbTotalSale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCloseDateSale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbOpenDateSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbUserSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbOpenedSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbIdSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSaleItems);
            this.Name = "FormSale";
            this.Text = "Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSaleItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOpenedSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUserSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbOpenDateSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCloseDateSale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalSale;
        private System.Windows.Forms.Button btnDeleteSaleItem;
    }
}