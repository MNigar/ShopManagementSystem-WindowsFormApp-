
namespace WindowsProject.Controls
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
            this.btn_DeleteCategory = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgw_Table = new System.Windows.Forms.DataGridView();
            this.grb_Categoriya = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).BeginInit();
            this.grb_Categoriya.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DeleteCategory
            // 
            this.btn_DeleteCategory.Location = new System.Drawing.Point(782, 85);
            this.btn_DeleteCategory.Name = "btn_DeleteCategory";
            this.btn_DeleteCategory.Size = new System.Drawing.Size(75, 62);
            this.btn_DeleteCategory.TabIndex = 14;
            this.btn_DeleteCategory.Text = "Sil";
            this.btn_DeleteCategory.UseVisualStyleBackColor = true;
            this.btn_DeleteCategory.Click += new System.EventHandler(this.btn_DeleteCategory_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(701, 85);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(75, 62);
            this.btn_GetAll.TabIndex = 13;
            this.btn_GetAll.Text = "Siyahı";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(231, 103);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 46);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Dəyişin";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dgw_Table
            // 
            this.dgw_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Table.Location = new System.Drawing.Point(63, 24);
            this.dgw_Table.Name = "dgw_Table";
            this.dgw_Table.RowHeadersWidth = 62;
            this.dgw_Table.RowTemplate.Height = 28;
            this.dgw_Table.Size = new System.Drawing.Size(609, 217);
            this.dgw_Table.TabIndex = 11;
            this.dgw_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Table_CellClick);
            // 
            // grb_Categoriya
            // 
            this.grb_Categoriya.Controls.Add(this.btn_Update);
            this.grb_Categoriya.Controls.Add(this.btn_Insert);
            this.grb_Categoriya.Controls.Add(this.lbl_Name);
            this.grb_Categoriya.Controls.Add(this.txb_Name);
            this.grb_Categoriya.Location = new System.Drawing.Point(63, 261);
            this.grb_Categoriya.Name = "grb_Categoriya";
            this.grb_Categoriya.Size = new System.Drawing.Size(464, 185);
            this.grb_Categoriya.TabIndex = 10;
            this.grb_Categoriya.TabStop = false;
            this.grb_Categoriya.Text = "Kateqoriya";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(83, 103);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(114, 46);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Əlavə Edin";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click_1);
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
            this.txb_Name.TextChanged += new System.EventHandler(this.txb_Name_TextChanged);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 723);
            this.Controls.Add(this.btn_DeleteCategory);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.dgw_Table);
            this.Controls.Add(this.grb_Categoriya);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Table)).EndInit();
            this.grb_Categoriya.ResumeLayout(false);
            this.grb_Categoriya.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteCategory;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dgw_Table;
        private System.Windows.Forms.GroupBox grb_Categoriya;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Name;
    }
}