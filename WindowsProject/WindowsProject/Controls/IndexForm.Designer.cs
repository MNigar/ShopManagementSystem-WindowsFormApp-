namespace WindowsProject
{
    partial class IndexForm
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
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_YourProduct = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(208, 154);
            this.btn_GetAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(191, 70);
            this.btn_GetAll.TabIndex = 0;
            this.btn_GetAll.Text = "Bütün məhsullar";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(114, 377);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(51, 20);
            this.lbl_UserId.TabIndex = 1;
            this.lbl_UserId.Text = "label1";
            this.lbl_UserId.Click += new System.EventHandler(this.lbl_UserId_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 417);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 23;
            this.textBox1.UseWaitCursor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(519, 154);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(191, 70);
            this.btn_Report.TabIndex = 24;
            this.btn_Report.Text = "Hesabat";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_YourProduct
            // 
            this.btn_YourProduct.Location = new System.Drawing.Point(811, 154);
            this.btn_YourProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_YourProduct.Name = "btn_YourProduct";
            this.btn_YourProduct.Size = new System.Drawing.Size(191, 70);
            this.btn_YourProduct.TabIndex = 25;
            this.btn_YourProduct.Text = "Əlavə etdiyiniz məhsullar";
            this.btn_YourProduct.UseVisualStyleBackColor = true;
            this.btn_YourProduct.Click += new System.EventHandler(this.btn_YourProduct_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(519, 268);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(191, 70);
            this.btn_Category.TabIndex = 26;
            this.btn_Category.Text = "Kateqoriyalar";
            this.btn_Category.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_Category);
            this.Controls.Add(this.btn_YourProduct);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_UserId);
            this.Controls.Add(this.btn_GetAll);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_YourProduct;
        private System.Windows.Forms.Button btn_Category;
    }
}