namespace StoreApp.Category
{
	partial class AdminCategoryPage
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
			this.components = new System.ComponentModel.Container();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.grpAddCategory = new System.Windows.Forms.GroupBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.lblCategoryName = new System.Windows.Forms.Label();
			this.btnCategoryAdd = new System.Windows.Forms.Button();
			this.grpUpdateCategory = new System.Windows.Forms.GroupBox();
			this.btnUpdateCategory = new System.Windows.Forms.Button();
			this.lblCategoryNameUpdate = new System.Windows.Forms.Label();
			this.txtUpdateCategoryName = new System.Windows.Forms.TextBox();
			this.grpDeleteCategory = new System.Windows.Forms.GroupBox();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.lblSelectedId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
			this.grpAddCategory.SuspendLayout();
			this.grpUpdateCategory.SuspendLayout();
			this.grpDeleteCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCategory
			// 
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategory.Location = new System.Drawing.Point(279, 12);
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategory.Size = new System.Drawing.Size(363, 325);
			this.dgvCategory.TabIndex = 0;
			this.dgvCategory.SelectionChanged += new System.EventHandler(this.dgvCategory_SelectionChanged);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			// 
			// grpAddCategory
			// 
			this.grpAddCategory.Controls.Add(this.btnCategoryAdd);
			this.grpAddCategory.Controls.Add(this.lblCategoryName);
			this.grpAddCategory.Controls.Add(this.txtCategoryName);
			this.grpAddCategory.Location = new System.Drawing.Point(12, 12);
			this.grpAddCategory.Name = "grpAddCategory";
			this.grpAddCategory.Size = new System.Drawing.Size(250, 97);
			this.grpAddCategory.TabIndex = 1;
			this.grpAddCategory.TabStop = false;
			this.grpAddCategory.Text = "Kategori Ekle";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(9, 32);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(229, 20);
			this.txtCategoryName.TabIndex = 0;
			// 
			// lblCategoryName
			// 
			this.lblCategoryName.AutoSize = true;
			this.lblCategoryName.Location = new System.Drawing.Point(6, 16);
			this.lblCategoryName.Name = "lblCategoryName";
			this.lblCategoryName.Size = new System.Drawing.Size(64, 13);
			this.lblCategoryName.TabIndex = 1;
			this.lblCategoryName.Text = "Kategori Adı";
			// 
			// btnCategoryAdd
			// 
			this.btnCategoryAdd.BackColor = System.Drawing.Color.YellowGreen;
			this.btnCategoryAdd.Location = new System.Drawing.Point(9, 58);
			this.btnCategoryAdd.Name = "btnCategoryAdd";
			this.btnCategoryAdd.Size = new System.Drawing.Size(229, 23);
			this.btnCategoryAdd.TabIndex = 2;
			this.btnCategoryAdd.Text = "Kategori Ekle";
			this.btnCategoryAdd.UseVisualStyleBackColor = false;
			this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
			// 
			// grpUpdateCategory
			// 
			this.grpUpdateCategory.Controls.Add(this.btnUpdateCategory);
			this.grpUpdateCategory.Controls.Add(this.lblCategoryNameUpdate);
			this.grpUpdateCategory.Controls.Add(this.txtUpdateCategoryName);
			this.grpUpdateCategory.Location = new System.Drawing.Point(12, 131);
			this.grpUpdateCategory.Name = "grpUpdateCategory";
			this.grpUpdateCategory.Size = new System.Drawing.Size(250, 97);
			this.grpUpdateCategory.TabIndex = 3;
			this.grpUpdateCategory.TabStop = false;
			this.grpUpdateCategory.Text = "Kategori Güncelle";
			// 
			// btnUpdateCategory
			// 
			this.btnUpdateCategory.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnUpdateCategory.Location = new System.Drawing.Point(9, 58);
			this.btnUpdateCategory.Name = "btnUpdateCategory";
			this.btnUpdateCategory.Size = new System.Drawing.Size(229, 23);
			this.btnUpdateCategory.TabIndex = 2;
			this.btnUpdateCategory.Text = "Kategori Güncelle";
			this.btnUpdateCategory.UseVisualStyleBackColor = false;
			this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
			// 
			// lblCategoryNameUpdate
			// 
			this.lblCategoryNameUpdate.AutoSize = true;
			this.lblCategoryNameUpdate.Location = new System.Drawing.Point(6, 16);
			this.lblCategoryNameUpdate.Name = "lblCategoryNameUpdate";
			this.lblCategoryNameUpdate.Size = new System.Drawing.Size(64, 13);
			this.lblCategoryNameUpdate.TabIndex = 1;
			this.lblCategoryNameUpdate.Text = "Kategori Adı";
			// 
			// txtUpdateCategoryName
			// 
			this.txtUpdateCategoryName.Location = new System.Drawing.Point(9, 32);
			this.txtUpdateCategoryName.Name = "txtUpdateCategoryName";
			this.txtUpdateCategoryName.Size = new System.Drawing.Size(229, 20);
			this.txtUpdateCategoryName.TabIndex = 0;
			// 
			// grpDeleteCategory
			// 
			this.grpDeleteCategory.Controls.Add(this.lblSelectedId);
			this.grpDeleteCategory.Controls.Add(this.btnDeleteCategory);
			this.grpDeleteCategory.Location = new System.Drawing.Point(12, 249);
			this.grpDeleteCategory.Name = "grpDeleteCategory";
			this.grpDeleteCategory.Size = new System.Drawing.Size(250, 78);
			this.grpDeleteCategory.TabIndex = 4;
			this.grpDeleteCategory.TabStop = false;
			this.grpDeleteCategory.Text = "Kategori Sil";
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.BackColor = System.Drawing.Color.Crimson;
			this.btnDeleteCategory.Location = new System.Drawing.Point(9, 40);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(229, 23);
			this.btnDeleteCategory.TabIndex = 2;
			this.btnDeleteCategory.Text = "Kategori Sil";
			this.btnDeleteCategory.UseVisualStyleBackColor = false;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// lblSelectedId
			// 
			this.lblSelectedId.AutoSize = true;
			this.lblSelectedId.Location = new System.Drawing.Point(114, 21);
			this.lblSelectedId.Name = "lblSelectedId";
			this.lblSelectedId.Size = new System.Drawing.Size(0, 13);
			this.lblSelectedId.TabIndex = 3;
			// 
			// AdminCategoryPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(654, 349);
			this.Controls.Add(this.grpDeleteCategory);
			this.Controls.Add(this.grpUpdateCategory);
			this.Controls.Add(this.grpAddCategory);
			this.Controls.Add(this.dgvCategory);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminCategoryPage";
			this.Text = "AdminCategoryPage";
			this.Load += new System.EventHandler(this.AdminCategoryPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
			this.grpAddCategory.ResumeLayout(false);
			this.grpAddCategory.PerformLayout();
			this.grpUpdateCategory.ResumeLayout(false);
			this.grpUpdateCategory.PerformLayout();
			this.grpDeleteCategory.ResumeLayout(false);
			this.grpDeleteCategory.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCategory;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.GroupBox grpAddCategory;
		private System.Windows.Forms.Button btnCategoryAdd;
		private System.Windows.Forms.Label lblCategoryName;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.GroupBox grpUpdateCategory;
		private System.Windows.Forms.Button btnUpdateCategory;
		private System.Windows.Forms.GroupBox grpDeleteCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Label lblCategoryNameUpdate;
		private System.Windows.Forms.TextBox txtUpdateCategoryName;
		private System.Windows.Forms.Label lblSelectedId;
	}
}