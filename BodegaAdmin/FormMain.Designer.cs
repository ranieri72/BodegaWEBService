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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnListProd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnListProd);
            this.tabPage1.Controls.Add(this.btnDeleteProd);
            this.tabPage1.Controls.Add(this.btnUpdateProd);
            this.tabPage1.Controls.Add(this.btnSaveProd);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 494);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(34, 515);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(102, 23);
            this.btnSaveProd.TabIndex = 1;
            this.btnSaveProd.Text = "Cadastrar Produto";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            this.btnSaveProd.Click += new System.EventHandler(this.btnSaveProd_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(184, 515);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateProd.TabIndex = 2;
            this.btnUpdateProd.Text = "Alterar Produto";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(333, 515);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteProd.TabIndex = 3;
            this.btnDeleteProd.Text = "Excluir Produto";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnListProd
            // 
            this.btnListProd.Location = new System.Drawing.Point(804, 515);
            this.btnListProd.Name = "btnListProd";
            this.btnListProd.Size = new System.Drawing.Size(102, 23);
            this.btnListProd.TabIndex = 4;
            this.btnListProd.Text = "Listar Produtos";
            this.btnListProd.UseVisualStyleBackColor = true;
            this.btnListProd.Click += new System.EventHandler(this.btnListProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnListProd;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnSaveProd;
        private System.Windows.Forms.ListView listView1;
    }
}

