
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.grb_CategoryEdit = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_UpdateName = new System.Windows.Forms.Label();
            this.txb_UpdateName = new System.Windows.Forms.TextBox();
            this.dgw_Table = new System.Windows.Forms.DataGridView();
            this.grb_Categoriya = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbc_Product.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_CategoryEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).BeginInit();
            this.grb_Categoriya.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Product
            // 
            this.tbc_Product.Controls.Add(this.tabPage1);
            this.tbc_Product.Controls.Add(this.tabPage2);
            this.tbc_Product.Location = new System.Drawing.Point(56, 11);
            this.tbc_Product.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_Product.Name = "tbc_Product";
            this.tbc_Product.SelectedIndex = 0;
            this.tbc_Product.Size = new System.Drawing.Size(965, 754);
            this.tbc_Product.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Delete);
            this.tabPage1.Controls.Add(this.btn_GetAll);
            this.tabPage1.Controls.Add(this.grb_CategoryEdit);
            this.tabPage1.Controls.Add(this.dgw_Table);
            this.tabPage1.Controls.Add(this.grb_Categoriya);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(753, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(607, 66);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(50, 40);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(521, 66);
            this.btn_GetAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(50, 40);
            this.btn_GetAll.TabIndex = 6;
            this.btn_GetAll.Text = "Siyahı";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // grb_CategoryEdit
            // 
            this.grb_CategoryEdit.Controls.Add(this.btn_Update);
            this.grb_CategoryEdit.Controls.Add(this.lbl_UpdateName);
            this.grb_CategoryEdit.Controls.Add(this.txb_UpdateName);
            this.grb_CategoryEdit.Location = new System.Drawing.Point(384, 169);
            this.grb_CategoryEdit.Margin = new System.Windows.Forms.Padding(2);
            this.grb_CategoryEdit.Name = "grb_CategoryEdit";
            this.grb_CategoryEdit.Padding = new System.Windows.Forms.Padding(2);
            this.grb_CategoryEdit.Size = new System.Drawing.Size(309, 120);
            this.grb_CategoryEdit.TabIndex = 5;
            this.grb_CategoryEdit.TabStop = false;
            this.grb_CategoryEdit.Text = "Kateqoriya";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(163, 67);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(76, 30);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Dəyişin";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_UpdateName
            // 
            this.lbl_UpdateName.AutoSize = true;
            this.lbl_UpdateName.Location = new System.Drawing.Point(5, 34);
            this.lbl_UpdateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UpdateName.Name = "lbl_UpdateName";
            this.lbl_UpdateName.Size = new System.Drawing.Size(75, 13);
            this.lbl_UpdateName.TabIndex = 0;
            this.lbl_UpdateName.Text = "Kateqoriya Adı";
            // 
            // txb_UpdateName
            // 
            this.txb_UpdateName.Location = new System.Drawing.Point(98, 34);
            this.txb_UpdateName.Margin = new System.Windows.Forms.Padding(2);
            this.txb_UpdateName.Name = "txb_UpdateName";
            this.txb_UpdateName.Size = new System.Drawing.Size(201, 20);
            this.txb_UpdateName.TabIndex = 1;
            // 
            // dgw_Table
            // 
            this.dgw_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Table.Location = new System.Drawing.Point(24, 15);
            this.dgw_Table.Margin = new System.Windows.Forms.Padding(2);
            this.dgw_Table.Name = "dgw_Table";
            this.dgw_Table.RowHeadersWidth = 62;
            this.dgw_Table.RowTemplate.Height = 28;
            this.dgw_Table.Size = new System.Drawing.Size(406, 141);
            this.dgw_Table.TabIndex = 4;
            this.dgw_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Table_CellClick);
            // 
            // grb_Categoriya
            // 
            this.grb_Categoriya.Controls.Add(this.btn_Insert);
            this.grb_Categoriya.Controls.Add(this.lbl_Name);
            this.grb_Categoriya.Controls.Add(this.txb_Name);
            this.grb_Categoriya.Location = new System.Drawing.Point(24, 169);
            this.grb_Categoriya.Margin = new System.Windows.Forms.Padding(2);
            this.grb_Categoriya.Name = "grb_Categoriya";
            this.grb_Categoriya.Padding = new System.Windows.Forms.Padding(2);
            this.grb_Categoriya.Size = new System.Drawing.Size(309, 120);
            this.grb_Categoriya.TabIndex = 3;
            this.grb_Categoriya.TabStop = false;
            this.grb_Categoriya.Text = "Kateqoriya";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(163, 67);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(76, 30);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Əlavə Edin";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(5, 34);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(75, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Kateqoriya Adı";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(96, 30);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(201, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(957, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(49, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 846);
            this.Controls.Add(this.tbc_Product);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.tbc_Product.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb_CategoryEdit.ResumeLayout(false);
            this.grb_CategoryEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).EndInit();
            this.grb_Categoriya.ResumeLayout(false);
            this.grb_Categoriya.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grb_CategoryEdit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_UpdateName;
        private System.Windows.Forms.TextBox txb_UpdateName;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}