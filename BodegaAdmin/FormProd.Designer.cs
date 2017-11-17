namespace BodegaAdmin
{
    partial class FormProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNameProd = new System.Windows.Forms.TextBox();
            this.edtPriceProd = new System.Windows.Forms.TextBox();
            this.btnConfirProd = new System.Windows.Forms.Button();
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // edtNameProd
            // 
            this.edtNameProd.Location = new System.Drawing.Point(53, 41);
            this.edtNameProd.Name = "edtNameProd";
            this.edtNameProd.Size = new System.Drawing.Size(219, 20);
            this.edtNameProd.TabIndex = 2;
            // 
            // edtPriceProd
            // 
            this.edtPriceProd.Location = new System.Drawing.Point(53, 84);
            this.edtPriceProd.Name = "edtPriceProd";
            this.edtPriceProd.Size = new System.Drawing.Size(100, 20);
            this.edtPriceProd.TabIndex = 3;
            // 
            // btnConfirProd
            // 
            this.btnConfirProd.Location = new System.Drawing.Point(28, 155);
            this.btnConfirProd.Name = "btnConfirProd";
            this.btnConfirProd.Size = new System.Drawing.Size(100, 23);
            this.btnConfirProd.TabIndex = 4;
            this.btnConfirProd.Text = "Salvar Produto";
            this.btnConfirProd.UseVisualStyleBackColor = true;
            this.btnConfirProd.Click += new System.EventHandler(this.btnConfirProd_Click);
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.Location = new System.Drawing.Point(151, 155);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(100, 23);
            this.btnCancelProd.TabIndex = 5;
            this.btnCancelProd.Text = "Fechar";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            this.btnCancelProd.Click += new System.EventHandler(this.btnCancelProd_Click);
            // 
            // FormProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.btnCancelProd);
            this.Controls.Add(this.btnConfirProd);
            this.Controls.Add(this.edtPriceProd);
            this.Controls.Add(this.edtNameProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProd";
            this.Text = "FormProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNameProd;
        private System.Windows.Forms.TextBox edtPriceProd;
        private System.Windows.Forms.Button btnConfirProd;
        private System.Windows.Forms.Button btnCancelProd;
    }
}