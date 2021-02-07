namespace WindowsProject
{
    partial class ProductForm
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
            this.dgw_ProductTable = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_rct = new System.Windows.Forms.Label();
            this.btn_ClearInput = new System.Windows.Forms.Button();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txb_Count = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbx_productName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SearchByUser = new System.Windows.Forms.Button();
            this.lbl_CategoryS = new System.Windows.Forms.Label();
            this.lbl_Prices = new System.Windows.Forms.Label();
            this.lbl_CountS = new System.Windows.Forms.Label();
            this.lbl_UserIDS = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_SearchDetail = new System.Windows.Forms.ComboBox();
            this.txbSearchPrice = new System.Windows.Forms.TextBox();
            this.txbSerachCount = new System.Windows.Forms.TextBox();
            this.txb_UserId = new System.Windows.Forms.TextBox();
            this.txb_SearchDetailName = new System.Windows.Forms.TextBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.txb_SearchName = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.cmb_SearchByUserCategory = new System.Windows.Forms.ComboBox();
            this.txb_SearchNameByUSer = new System.Windows.Forms.TextBox();
            this.btn_SearchUSers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_ProductTable
            // 
            this.dgw_ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ProductTable.Location = new System.Drawing.Point(-4, 35);
            this.dgw_ProductTable.Name = "dgw_ProductTable";
            this.dgw_ProductTable.RowHeadersWidth = 62;
            this.dgw_ProductTable.RowTemplate.Height = 28;
            this.dgw_ProductTable.Size = new System.Drawing.Size(804, 227);
            this.dgw_ProductTable.TabIndex = 3;
            this.dgw_ProductTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ProductTable_CellClick_1);
            this.dgw_ProductTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ProductTable_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(806, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 258);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 504);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ForCrud";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_rct);
            this.groupBox1.Controls.Add(this.btn_ClearInput);
            this.groupBox1.Controls.Add(this.rtb_Description);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lbl_UserId);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.cmb_Category);
            this.groupBox1.Controls.Add(this.lbl_PhoneNumber);
            this.groupBox1.Controls.Add(this.txb_Count);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.txb_Price);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbx_productName);
            this.groupBox1.Location = new System.Drawing.Point(7, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1007, 445);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_rct
            // 
            this.lbl_rct.AutoSize = true;
            this.lbl_rct.Location = new System.Drawing.Point(-31, 273);
            this.lbl_rct.Name = "lbl_rct";
            this.lbl_rct.Size = new System.Drawing.Size(251, 20);
            this.lbl_rct.TabIndex = 21;
            this.lbl_rct.Text = "Deyisdikde ve ya sildikde Doldurun";
            this.lbl_rct.Visible = false;
            // 
            // btn_ClearInput
            // 
            this.btn_ClearInput.Location = new System.Drawing.Point(795, 46);
            this.btn_ClearInput.Name = "btn_ClearInput";
            this.btn_ClearInput.Size = new System.Drawing.Size(156, 46);
            this.btn_ClearInput.TabIndex = 20;
            this.btn_ClearInput.Text = "Xanaları Təmizlə";
            this.btn_ClearInput.UseVisualStyleBackColor = true;
            this.btn_ClearInput.Click += new System.EventHandler(this.btn_ClearInput_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(226, 249);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(254, 112);
            this.rtb_Description.TabIndex = 19;
            this.rtb_Description.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 46);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Dəyişin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(24, 417);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(58, 20);
            this.lbl_UserId.TabIndex = 4;
            this.lbl_UserId.Text = "USerid";
            this.lbl_UserId.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(795, 103);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(114, 46);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(175, 391);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(114, 46);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "Əlavə Edin";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SearchByUser);
            this.tabPage2.Controls.Add(this.lbl_CategoryS);
            this.tabPage2.Controls.Add(this.lbl_Prices);
            this.tabPage2.Controls.Add(this.lbl_CountS);
            this.tabPage2.Controls.Add(this.lbl_UserIDS);
            this.tabPage2.Controls.Add(this.lbl_Name);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.cmb_SearchDetail);
            this.tabPage2.Controls.Add(this.txbSearchPrice);
            this.tabPage2.Controls.Add(this.txbSerachCount);
            this.tabPage2.Controls.Add(this.txb_UserId);
            this.tabPage2.Controls.Add(this.txb_SearchDetailName);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_SearchByUser
            // 
            this.btn_SearchByUser.Location = new System.Drawing.Point(213, 364);
            this.btn_SearchByUser.Name = "btn_SearchByUser";
            this.btn_SearchByUser.Size = new System.Drawing.Size(114, 46);
            this.btn_SearchByUser.TabIndex = 33;
            this.btn_SearchByUser.Text = "Axtar";
            this.btn_SearchByUser.UseVisualStyleBackColor = true;
            this.btn_SearchByUser.Visible = false;
            this.btn_SearchByUser.Click += new System.EventHandler(this.btn_SearchByUser_Click);
            // 
            // lbl_CategoryS
            // 
            this.lbl_CategoryS.AutoSize = true;
            this.lbl_CategoryS.Location = new System.Drawing.Point(38, 252);
            this.lbl_CategoryS.Name = "lbl_CategoryS";
            this.lbl_CategoryS.Size = new System.Drawing.Size(84, 20);
            this.lbl_CategoryS.TabIndex = 32;
            this.lbl_CategoryS.Text = "Kateqoriya";
            // 
            // lbl_Prices
            // 
            this.lbl_Prices.AutoSize = true;
            this.lbl_Prices.Location = new System.Drawing.Point(38, 193);
            this.lbl_Prices.Name = "lbl_Prices";
            this.lbl_Prices.Size = new System.Drawing.Size(58, 20);
            this.lbl_Prices.TabIndex = 31;
            this.lbl_Prices.Text = "Qiymət";
            // 
            // lbl_CountS
            // 
            this.lbl_CountS.AutoSize = true;
            this.lbl_CountS.Location = new System.Drawing.Point(38, 144);
            this.lbl_CountS.Name = "lbl_CountS";
            this.lbl_CountS.Size = new System.Drawing.Size(36, 20);
            this.lbl_CountS.TabIndex = 30;
            this.lbl_CountS.Text = "Say";
            this.lbl_CountS.Click += new System.EventHandler(this.lbl_CountS_Click);
            // 
            // lbl_UserIDS
            // 
            this.lbl_UserIDS.AutoSize = true;
            this.lbl_UserIDS.Location = new System.Drawing.Point(6, 99);
            this.lbl_UserIDS.Name = "lbl_UserIDS";
            this.lbl_UserIDS.Size = new System.Drawing.Size(215, 20);
            this.lbl_UserIDS.TabIndex = 29;
            this.lbl_UserIDS.Text = "Məhsulu yerləşdirən istifadəçi";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(38, 51);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(85, 20);
            this.lbl_Name.TabIndex = 28;
            this.lbl_Name.Text = "Məhsul adı";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(213, 302);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(114, 46);
            this.btn_Search.TabIndex = 27;
            this.btn_Search.Text = "Axtar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_SearchDetail
            // 
            this.cmb_SearchDetail.FormattingEnabled = true;
            this.cmb_SearchDetail.Location = new System.Drawing.Point(213, 244);
            this.cmb_SearchDetail.Name = "cmb_SearchDetail";
            this.cmb_SearchDetail.Size = new System.Drawing.Size(300, 28);
            this.cmb_SearchDetail.TabIndex = 24;
            // 
            // txbSearchPrice
            // 
            this.txbSearchPrice.Location = new System.Drawing.Point(213, 193);
            this.txbSearchPrice.Name = "txbSearchPrice";
            this.txbSearchPrice.Size = new System.Drawing.Size(300, 26);
            this.txbSearchPrice.TabIndex = 26;
            // 
            // txbSerachCount
            // 
            this.txbSerachCount.Location = new System.Drawing.Point(213, 138);
            this.txbSerachCount.Name = "txbSerachCount";
            this.txbSerachCount.Size = new System.Drawing.Size(300, 26);
            this.txbSerachCount.TabIndex = 25;
            // 
            // txb_UserId
            // 
            this.txb_UserId.Location = new System.Drawing.Point(213, 93);
            this.txb_UserId.Name = "txb_UserId";
            this.txb_UserId.Size = new System.Drawing.Size(300, 26);
            this.txb_UserId.TabIndex = 23;
            // 
            // txb_SearchDetailName
            // 
            this.txb_SearchDetailName.Location = new System.Drawing.Point(213, 49);
            this.txb_SearchDetailName.Name = "txb_SearchDetailName";
            this.txb_SearchDetailName.Size = new System.Drawing.Size(300, 26);
            this.txb_SearchDetailName.TabIndex = 22;
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(806, 101);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(244, 46);
            this.btn_Buy.TabIndex = 20;
            this.btn_Buy.Text = "Al";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // txb_SearchName
            // 
            this.txb_SearchName.Location = new System.Drawing.Point(943, 37);
            this.txb_SearchName.Name = "txb_SearchName";
            this.txb_SearchName.Size = new System.Drawing.Size(177, 26);
            this.txb_SearchName.TabIndex = 21;
            this.txb_SearchName.TextChanged += new System.EventHandler(this.txb_SearchName_TextChanged);
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Location = new System.Drawing.Point(1156, 35);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(177, 28);
            this.cmb_SearchCategory.TabIndex = 22;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(806, 37);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(126, 46);
            this.btn_GetAll.TabIndex = 23;
            this.btn_GetAll.Text = "Siyahı";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // cmb_SearchByUserCategory
            // 
            this.cmb_SearchByUserCategory.FormattingEnabled = true;
            this.cmb_SearchByUserCategory.Location = new System.Drawing.Point(1156, 67);
            this.cmb_SearchByUserCategory.Name = "cmb_SearchByUserCategory";
            this.cmb_SearchByUserCategory.Size = new System.Drawing.Size(177, 28);
            this.cmb_SearchByUserCategory.TabIndex = 25;
            this.cmb_SearchByUserCategory.Visible = false;
            this.cmb_SearchByUserCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByUserCategory_SelectedIndexChanged);
            // 
            // txb_SearchNameByUSer
            // 
            this.txb_SearchNameByUSer.Location = new System.Drawing.Point(943, 69);
            this.txb_SearchNameByUSer.Name = "txb_SearchNameByUSer";
            this.txb_SearchNameByUSer.Size = new System.Drawing.Size(177, 26);
            this.txb_SearchNameByUSer.TabIndex = 24;
            this.txb_SearchNameByUSer.Visible = false;
            this.txb_SearchNameByUSer.TextChanged += new System.EventHandler(this.txb_SearchNameByUSer_TextChanged);
            // 
            // btn_SearchUSers
            // 
            this.btn_SearchUSers.Location = new System.Drawing.Point(806, 153);
            this.btn_SearchUSers.Name = "btn_SearchUSers";
            this.btn_SearchUSers.Size = new System.Drawing.Size(126, 46);
            this.btn_SearchUSers.TabIndex = 26;
            this.btn_SearchUSers.Text = "Siyahı";
            this.btn_SearchUSers.UseVisualStyleBackColor = true;
            this.btn_SearchUSers.Visible = false;
            this.btn_SearchUSers.Click += new System.EventHandler(this.btn_SearchUSers_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 807);
            this.Controls.Add(this.btn_SearchUSers);
            this.Controls.Add(this.cmb_SearchByUserCategory);
            this.Controls.Add(this.txb_SearchNameByUSer);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.txb_SearchName);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgw_ProductTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_ProductTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Count;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbx_productName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_ClearInput;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.TextBox txb_SearchName;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_SearchDetail;
        private System.Windows.Forms.TextBox txbSearchPrice;
        private System.Windows.Forms.TextBox txbSerachCount;
        private System.Windows.Forms.TextBox txb_UserId;
        private System.Windows.Forms.TextBox txb_SearchDetailName;
        private System.Windows.Forms.Label lbl_UserIDS;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_CountS;
        private System.Windows.Forms.Label lbl_CategoryS;
        private System.Windows.Forms.Label lbl_Prices;
        private System.Windows.Forms.Label lbl_rct;
        private System.Windows.Forms.Button btn_SearchByUser;
        private System.Windows.Forms.ComboBox cmb_SearchByUserCategory;
        private System.Windows.Forms.TextBox txb_SearchNameByUSer;
        private System.Windows.Forms.Button btn_SearchUSers;
    }
}