
namespace WindowsProject
{
    partial class ReportForm
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
            this.dgw_Reporttable = new System.Windows.Forms.DataGridView();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.lbl_CategoryS = new System.Windows.Forms.Label();
            this.lbl_CountS = new System.Windows.Forms.Label();
            this.lbl_UserIDS = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_SearchDetail = new System.Windows.Forms.ComboBox();
            this.txbSerachCount = new System.Windows.Forms.TextBox();
            this.txb_SearchDetailName = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.textBStatus = new System.Windows.Forms.TextBox();
            this.cmb_UserSearch = new System.Windows.Forms.ComboBox();
            this.btn_GetAllUser = new System.Windows.Forms.Button();
            this.lbl_Prices = new System.Windows.Forms.Label();
            this.txbSearchPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Reporttable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Reporttable
            // 
            this.dgw_Reporttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Reporttable.Location = new System.Drawing.Point(1, 1);
            this.dgw_Reporttable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_Reporttable.Name = "dgw_Reporttable";
            this.dgw_Reporttable.RowHeadersWidth = 62;
            this.dgw_Reporttable.RowTemplate.Height = 28;
            this.dgw_Reporttable.Size = new System.Drawing.Size(515, 377);
            this.dgw_Reporttable.TabIndex = 0;
            this.dgw_Reporttable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Reporttable_CellContentClick);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(565, 341);
            this.lbl_UserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(35, 13);
            this.lbl_UserId.TabIndex = 1;
            this.lbl_UserId.Text = "label1";
            this.lbl_UserId.Visible = false;
            // 
            // lbl_CategoryS
            // 
            this.lbl_CategoryS.AutoSize = true;
            this.lbl_CategoryS.Location = new System.Drawing.Point(557, 127);
            this.lbl_CategoryS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CategoryS.Name = "lbl_CategoryS";
            this.lbl_CategoryS.Size = new System.Drawing.Size(57, 13);
            this.lbl_CategoryS.TabIndex = 54;
            this.lbl_CategoryS.Text = "Kateqoriya";
            // 
            // lbl_CountS
            // 
            this.lbl_CountS.AutoSize = true;
            this.lbl_CountS.Location = new System.Drawing.Point(557, 98);
            this.lbl_CountS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CountS.Name = "lbl_CountS";
            this.lbl_CountS.Size = new System.Drawing.Size(25, 13);
            this.lbl_CountS.TabIndex = 52;
            this.lbl_CountS.Text = "Say";
            // 
            // lbl_UserIDS
            // 
            this.lbl_UserIDS.AutoSize = true;
            this.lbl_UserIDS.Location = new System.Drawing.Point(557, 66);
            this.lbl_UserIDS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserIDS.Name = "lbl_UserIDS";
            this.lbl_UserIDS.Size = new System.Drawing.Size(49, 13);
            this.lbl_UserIDS.TabIndex = 51;
            this.lbl_UserIDS.Text = "İstifadəçi";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(557, 38);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(58, 13);
            this.lbl_Name.TabIndex = 50;
            this.lbl_Name.Text = "Məhsul adı";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(799, 248);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(76, 30);
            this.btn_Search.TabIndex = 49;
            this.btn_Search.Text = "Axtar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_SearchDetail
            // 
            this.cmb_SearchDetail.FormattingEnabled = true;
            this.cmb_SearchDetail.Items.AddRange(new object[] {
            "select"});
            this.cmb_SearchDetail.Location = new System.Drawing.Point(673, 127);
            this.cmb_SearchDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_SearchDetail.Name = "cmb_SearchDetail";
            this.cmb_SearchDetail.Size = new System.Drawing.Size(201, 21);
            this.cmb_SearchDetail.TabIndex = 46;
            // 
            // txbSerachCount
            // 
            this.txbSerachCount.Location = new System.Drawing.Point(674, 94);
            this.txbSerachCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSerachCount.Name = "txbSerachCount";
            this.txbSerachCount.Size = new System.Drawing.Size(201, 20);
            this.txbSerachCount.TabIndex = 47;
            // 
            // txb_SearchDetailName
            // 
            this.txb_SearchDetailName.Location = new System.Drawing.Point(674, 36);
            this.txb_SearchDetailName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_SearchDetailName.Name = "txb_SearchDetailName";
            this.txb_SearchDetailName.Size = new System.Drawing.Size(201, 20);
            this.txb_SearchDetailName.TabIndex = 44;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(564, 167);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 56;
            this.lbl_Status.Text = "Status";
            // 
            // textBStatus
            // 
            this.textBStatus.Location = new System.Drawing.Point(673, 163);
            this.textBStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBStatus.Name = "textBStatus";
            this.textBStatus.Size = new System.Drawing.Size(201, 20);
            this.textBStatus.TabIndex = 55;
            // 
            // cmb_UserSearch
            // 
            this.cmb_UserSearch.FormattingEnabled = true;
            this.cmb_UserSearch.Items.AddRange(new object[] {
            "select"});
            this.cmb_UserSearch.Location = new System.Drawing.Point(674, 61);
            this.cmb_UserSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_UserSearch.Name = "cmb_UserSearch";
            this.cmb_UserSearch.Size = new System.Drawing.Size(201, 21);
            this.cmb_UserSearch.TabIndex = 57;
            this.cmb_UserSearch.SelectedIndexChanged += new System.EventHandler(this.cmb_UserSearch_SelectedIndexChanged);
            // 
            // btn_GetAllUser
            // 
            this.btn_GetAllUser.Location = new System.Drawing.Point(684, 248);
            this.btn_GetAllUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GetAllUser.Name = "btn_GetAllUser";
            this.btn_GetAllUser.Size = new System.Drawing.Size(76, 30);
            this.btn_GetAllUser.TabIndex = 58;
            this.btn_GetAllUser.Text = " Siyahı";
            this.btn_GetAllUser.UseVisualStyleBackColor = true;
            this.btn_GetAllUser.Click += new System.EventHandler(this.btn_GetAllUser_Click);
            // 
            // lbl_Prices
            // 
            this.lbl_Prices.AutoSize = true;
            this.lbl_Prices.Location = new System.Drawing.Point(567, 213);
            this.lbl_Prices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Prices.Name = "lbl_Prices";
            this.lbl_Prices.Size = new System.Drawing.Size(39, 13);
            this.lbl_Prices.TabIndex = 60;
            this.lbl_Prices.Text = "Qiymət";
            // 
            // txbSearchPrice
            // 
            this.txbSearchPrice.Location = new System.Drawing.Point(673, 206);
            this.txbSearchPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchPrice.Name = "txbSearchPrice";
            this.txbSearchPrice.Size = new System.Drawing.Size(201, 20);
            this.txbSearchPrice.TabIndex = 59;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 644);
            this.Controls.Add(this.lbl_Prices);
            this.Controls.Add(this.txbSearchPrice);
            this.Controls.Add(this.btn_GetAllUser);
            this.Controls.Add(this.cmb_UserSearch);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.textBStatus);
            this.Controls.Add(this.lbl_CategoryS);
            this.Controls.Add(this.lbl_CountS);
            this.Controls.Add(this.lbl_UserIDS);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_SearchDetail);
            this.Controls.Add(this.txbSerachCount);
            this.Controls.Add(this.txb_SearchDetailName);
            this.Controls.Add(this.lbl_UserId);
            this.Controls.Add(this.dgw_Reporttable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Reporttable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Reporttable;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Label lbl_CategoryS;
        private System.Windows.Forms.Label lbl_CountS;
        private System.Windows.Forms.Label lbl_UserIDS;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_SearchDetail;
        private System.Windows.Forms.TextBox txbSerachCount;
        private System.Windows.Forms.TextBox txb_SearchDetailName;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox textBStatus;
        private System.Windows.Forms.ComboBox cmb_UserSearch;
        private System.Windows.Forms.Button btn_GetAllUser;
        private System.Windows.Forms.Label lbl_Prices;
        private System.Windows.Forms.TextBox txbSearchPrice;
    }
}