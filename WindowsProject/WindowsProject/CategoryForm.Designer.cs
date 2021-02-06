
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
            this.btn_DeleteCategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.btn_DeletePr = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_UpdatePr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CountPr = new System.Windows.Forms.Label();
            this.txb_PrUpdateCount = new System.Windows.Forms.TextBox();
            this.lbl_PricePr = new System.Windows.Forms.Label();
            this.txb_PrUpdatePrice = new System.Windows.Forms.TextBox();
            this.lbl_CategoryPr = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl_NamePr = new System.Windows.Forms.Label();
            this.txb_PrUpdateName = new System.Windows.Forms.TextBox();
            this.dgw_ProductTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txb_Count = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbx_productName = new System.Windows.Forms.TextBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.tbc_Product.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_CategoryEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).BeginInit();
            this.grb_Categoriya.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Product
            // 
            this.tbc_Product.Controls.Add(this.tabPage1);
            this.tbc_Product.Controls.Add(this.tabPage2);
            this.tbc_Product.Location = new System.Drawing.Point(84, 17);
            this.tbc_Product.Name = "tbc_Product";
            this.tbc_Product.SelectedIndex = 0;
            this.tbc_Product.Size = new System.Drawing.Size(1448, 1160);
            this.tbc_Product.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_DeleteCategory);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_GetAll);
            this.tabPage1.Controls.Add(this.grb_CategoryEdit);
            this.tabPage1.Controls.Add(this.dgw_Table);
            this.tabPage1.Controls.Add(this.grb_Categoriya);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1440, 1127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteCategory
            // 
            this.btn_DeleteCategory.Location = new System.Drawing.Point(893, 102);
            this.btn_DeleteCategory.Name = "btn_DeleteCategory";
            this.btn_DeleteCategory.Size = new System.Drawing.Size(75, 62);
            this.btn_DeleteCategory.TabIndex = 9;
            this.btn_DeleteCategory.Text = "Sil";
            this.btn_DeleteCategory.UseVisualStyleBackColor = true;
            this.btn_DeleteCategory.Click += new System.EventHandler(this.btn_DeleteCategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 585);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 8;
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(782, 102);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(75, 62);
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
            this.grb_CategoryEdit.Location = new System.Drawing.Point(576, 260);
            this.grb_CategoryEdit.Name = "grb_CategoryEdit";
            this.grb_CategoryEdit.Size = new System.Drawing.Size(464, 185);
            this.grb_CategoryEdit.TabIndex = 5;
            this.grb_CategoryEdit.TabStop = false;
            this.grb_CategoryEdit.Text = "Kateqoriya";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(244, 103);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 46);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Dəyişin";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_UpdateName
            // 
            this.lbl_UpdateName.AutoSize = true;
            this.lbl_UpdateName.Location = new System.Drawing.Point(8, 52);
            this.lbl_UpdateName.Name = "lbl_UpdateName";
            this.lbl_UpdateName.Size = new System.Drawing.Size(111, 20);
            this.lbl_UpdateName.TabIndex = 0;
            this.lbl_UpdateName.Text = "Kateqoriya Adı";
            // 
            // txb_UpdateName
            // 
            this.txb_UpdateName.Location = new System.Drawing.Point(147, 52);
            this.txb_UpdateName.Name = "txb_UpdateName";
            this.txb_UpdateName.Size = new System.Drawing.Size(300, 26);
            this.txb_UpdateName.TabIndex = 1;
            // 
            // dgw_Table
            // 
            this.dgw_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Table.Location = new System.Drawing.Point(36, 23);
            this.dgw_Table.Name = "dgw_Table";
            this.dgw_Table.RowHeadersWidth = 62;
            this.dgw_Table.RowTemplate.Height = 28;
            this.dgw_Table.Size = new System.Drawing.Size(609, 217);
            this.dgw_Table.TabIndex = 4;
            this.dgw_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Table_CellClick);
            // 
            // grb_Categoriya
            // 
            this.grb_Categoriya.Controls.Add(this.btn_Insert);
            this.grb_Categoriya.Controls.Add(this.lbl_Name);
            this.grb_Categoriya.Controls.Add(this.txb_Name);
            this.grb_Categoriya.Location = new System.Drawing.Point(36, 260);
            this.grb_Categoriya.Name = "grb_Categoriya";
            this.grb_Categoriya.Size = new System.Drawing.Size(464, 185);
            this.grb_Categoriya.TabIndex = 3;
            this.grb_Categoriya.TabStop = false;
            this.grb_Categoriya.Text = "Kateqoriya";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(244, 103);
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
            this.lbl_Name.Location = new System.Drawing.Point(8, 52);
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
            this.tabPage2.Controls.Add(this.rtb_Description);
            this.tabPage2.Controls.Add(this.btn_Buy);
            this.tabPage2.Controls.Add(this.btn_DeletePr);
            this.tabPage2.Controls.Add(this.btnGetAll);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgw_ProductTable);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1440, 1127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeletePr
            // 
            this.btn_DeletePr.Location = new System.Drawing.Point(1043, 14);
            this.btn_DeletePr.Name = "btn_DeletePr";
            this.btn_DeletePr.Size = new System.Drawing.Size(173, 53);
            this.btn_DeletePr.TabIndex = 10;
            this.btn_DeletePr.Text = "Sil";
            this.btn_DeletePr.UseVisualStyleBackColor = true;
            this.btn_DeletePr.Click += new System.EventHandler(this.btn_DeletePr_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(934, 14);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 39);
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "Siyahı";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_UpdatePr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_CountPr);
            this.groupBox2.Controls.Add(this.txb_PrUpdateCount);
            this.groupBox2.Controls.Add(this.lbl_PricePr);
            this.groupBox2.Controls.Add(this.txb_PrUpdatePrice);
            this.groupBox2.Controls.Add(this.lbl_CategoryPr);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.lbl_NamePr);
            this.groupBox2.Controls.Add(this.txb_PrUpdateName);
            this.groupBox2.Location = new System.Drawing.Point(756, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(652, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmb_UpdatePr
            // 
            this.cmb_UpdatePr.FormattingEnabled = true;
            this.cmb_UpdatePr.Location = new System.Drawing.Point(160, 100);
            this.cmb_UpdatePr.Name = "cmb_UpdatePr";
            this.cmb_UpdatePr.Size = new System.Drawing.Size(300, 28);
            this.cmb_UpdatePr.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "USerid";
            this.label1.Visible = false;
            // 
            // lbl_CountPr
            // 
            this.lbl_CountPr.AutoSize = true;
            this.lbl_CountPr.Location = new System.Drawing.Point(24, 214);
            this.lbl_CountPr.Name = "lbl_CountPr";
            this.lbl_CountPr.Size = new System.Drawing.Size(36, 20);
            this.lbl_CountPr.TabIndex = 10;
            this.lbl_CountPr.Text = "Say";
            // 
            // txb_PrUpdateCount
            // 
            this.txb_PrUpdateCount.Location = new System.Drawing.Point(160, 208);
            this.txb_PrUpdateCount.Name = "txb_PrUpdateCount";
            this.txb_PrUpdateCount.Size = new System.Drawing.Size(300, 26);
            this.txb_PrUpdateCount.TabIndex = 11;
            // 
            // lbl_PricePr
            // 
            this.lbl_PricePr.AutoSize = true;
            this.lbl_PricePr.Location = new System.Drawing.Point(24, 157);
            this.lbl_PricePr.Name = "lbl_PricePr";
            this.lbl_PricePr.Size = new System.Drawing.Size(58, 20);
            this.lbl_PricePr.TabIndex = 8;
            this.lbl_PricePr.Text = "Qiymət";
            // 
            // txb_PrUpdatePrice
            // 
            this.txb_PrUpdatePrice.Location = new System.Drawing.Point(160, 151);
            this.txb_PrUpdatePrice.Name = "txb_PrUpdatePrice";
            this.txb_PrUpdatePrice.Size = new System.Drawing.Size(300, 26);
            this.txb_PrUpdatePrice.TabIndex = 9;
            // 
            // lbl_CategoryPr
            // 
            this.lbl_CategoryPr.AutoSize = true;
            this.lbl_CategoryPr.Location = new System.Drawing.Point(24, 105);
            this.lbl_CategoryPr.Name = "lbl_CategoryPr";
            this.lbl_CategoryPr.Size = new System.Drawing.Size(84, 20);
            this.lbl_CategoryPr.TabIndex = 6;
            this.lbl_CategoryPr.Text = "Kateqoriya";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 46);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Dəyişin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbl_NamePr
            // 
            this.lbl_NamePr.AutoSize = true;
            this.lbl_NamePr.Location = new System.Drawing.Point(24, 46);
            this.lbl_NamePr.Name = "lbl_NamePr";
            this.lbl_NamePr.Size = new System.Drawing.Size(85, 20);
            this.lbl_NamePr.TabIndex = 3;
            this.lbl_NamePr.Text = "Məhsul adı";
            // 
            // txb_PrUpdateName
            // 
            this.txb_PrUpdateName.Location = new System.Drawing.Point(160, 40);
            this.txb_PrUpdateName.Name = "txb_PrUpdateName";
            this.txb_PrUpdateName.Size = new System.Drawing.Size(300, 26);
            this.txb_PrUpdateName.TabIndex = 4;
            // 
            // dgw_ProductTable
            // 
            this.dgw_ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ProductTable.Location = new System.Drawing.Point(42, 14);
            this.dgw_ProductTable.Name = "dgw_ProductTable";
            this.dgw_ProductTable.RowHeadersWidth = 62;
            this.dgw_ProductTable.RowTemplate.Height = 28;
            this.dgw_ProductTable.Size = new System.Drawing.Size(804, 308);
            this.dgw_ProductTable.TabIndex = 1;
            this.dgw_ProductTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ProductTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_UserId);
            this.groupBox1.Controls.Add(this.cmb_Category);
            this.groupBox1.Controls.Add(this.lbl_PhoneNumber);
            this.groupBox1.Controls.Add(this.txb_Count);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.txb_Price);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbx_productName);
            this.groupBox1.Location = new System.Drawing.Point(42, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(652, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(22, 288);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(58, 20);
            this.lbl_UserId.TabIndex = 4;
            this.lbl_UserId.Text = "USerid";
            this.lbl_UserId.Visible = false;
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(160, 97);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(300, 28);
            this.cmb_Category.TabIndex = 16;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(24, 214);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(36, 20);
            this.lbl_PhoneNumber.TabIndex = 10;
            this.lbl_PhoneNumber.Text = "Say";
            // 
            // txb_Count
            // 
            this.txb_Count.Location = new System.Drawing.Point(160, 208);
            this.txb_Count.Name = "txb_Count";
            this.txb_Count.Size = new System.Drawing.Size(300, 26);
            this.txb_Count.TabIndex = 11;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(24, 157);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(58, 20);
            this.lbl_Price.TabIndex = 8;
            this.lbl_Price.Text = "Qiymət";
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(160, 151);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(300, 26);
            this.txb_Price.TabIndex = 9;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(24, 105);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(84, 20);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Kateqoriya";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(242, 262);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(114, 46);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Əlavə Edin";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Məhsul adı";
            // 
            // tbx_productName
            // 
            this.tbx_productName.Location = new System.Drawing.Point(160, 40);
            this.tbx_productName.Name = "tbx_productName";
            this.tbx_productName.Size = new System.Drawing.Size(300, 26);
            this.tbx_productName.TabIndex = 4;
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(987, 115);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 62);
            this.btn_Buy.TabIndex = 11;
            this.btn_Buy.Text = "Al";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(880, 709);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(307, 112);
            this.rtb_Description.TabIndex = 12;
            this.rtb_Description.Text = "";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1049);
            this.Controls.Add(this.tbc_Product);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.tbc_Product.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grb_CategoryEdit.ResumeLayout(false);
            this.grb_CategoryEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).EndInit();
            this.grb_Categoriya.ResumeLayout(false);
            this.grb_Categoriya.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbx_productName;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DataGridView dgw_ProductTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Count;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CountPr;
        private System.Windows.Forms.TextBox txb_PrUpdateCount;
        private System.Windows.Forms.Label lbl_PricePr;
        private System.Windows.Forms.TextBox txb_PrUpdatePrice;
        private System.Windows.Forms.Label lbl_CategoryPr;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbl_NamePr;
        private System.Windows.Forms.TextBox txb_PrUpdateName;
        private System.Windows.Forms.ComboBox cmb_UpdatePr;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btn_DeletePr;
        private System.Windows.Forms.Button btn_DeleteCategory;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.RichTextBox rtb_Description;
    }
}