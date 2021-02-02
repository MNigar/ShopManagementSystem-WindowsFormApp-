
namespace WindowsProject
{
    partial class CategoryForm
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
            this.tbc_Product = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb_Categoriya = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgw_Table = new System.Windows.Forms.DataGridView();
            this.tbc_Product.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_Categoriya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Product
            // 
            this.tbc_Product.Controls.Add(this.tabPage1);
            this.tbc_Product.Controls.Add(this.tabPage2);
            this.tbc_Product.Location = new System.Drawing.Point(84, 24);
            this.tbc_Product.Name = "tbc_Product";
            this.tbc_Product.SelectedIndex = 0;
            this.tbc_Product.Size = new System.Drawing.Size(893, 509);
            this.tbc_Product.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgw_Table);
            this.tabPage1.Controls.Add(this.grb_Categoriya);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grb_Categoriya
            // 
            this.grb_Categoriya.Controls.Add(this.btn_Insert);
            this.grb_Categoriya.Controls.Add(this.lbl_Name);
            this.grb_Categoriya.Controls.Add(this.txb_Name);
            this.grb_Categoriya.Location = new System.Drawing.Point(36, 260);
            this.grb_Categoriya.Name = "grb_Categoriya";
            this.grb_Categoriya.Size = new System.Drawing.Size(554, 184);
            this.grb_Categoriya.TabIndex = 3;
            this.grb_Categoriya.TabStop = false;
            this.grb_Categoriya.Text = "Kateqoriya";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(245, 103);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(114, 46);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Əlavə Edin";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(7, 52);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(111, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Kateqoriya Adı";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(144, 46);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(300, 26);
            this.txb_Name.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgw_Table
            // 
            this.dgw_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Table.Location = new System.Drawing.Point(237, 15);
            this.dgw_Table.Name = "dgw_Table";
            this.dgw_Table.RowHeadersWidth = 62;
            this.dgw_Table.RowTemplate.Height = 28;
            this.dgw_Table.Size = new System.Drawing.Size(609, 217);
            this.dgw_Table.TabIndex = 4;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 597);
            this.Controls.Add(this.tbc_Product);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.tbc_Product.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb_Categoriya.ResumeLayout(false);
            this.grb_Categoriya.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Product;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grb_Categoriya;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.DataGridView dgw_Table;
    }
}