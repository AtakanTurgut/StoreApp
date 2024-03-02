namespace StoreApp.Product
{
	partial class AdminProductPage
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
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.grpAddProduct = new System.Windows.Forms.GroupBox();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.cmbCategoryName = new System.Windows.Forms.ComboBox();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblBarcode = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblProduct = new System.Windows.Forms.Label();
			this.grpUpdateProduct = new System.Windows.Forms.GroupBox();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.cmbUpdateCategoryName = new System.Windows.Forms.ComboBox();
			this.txtUpdateBarcode = new System.Windows.Forms.TextBox();
			this.txtUpdatePrice = new System.Windows.Forms.TextBox();
			this.txtUpdateProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grpDeleteProduct = new System.Windows.Forms.GroupBox();
			this.lblSelectedId = new System.Windows.Forms.Label();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnMainPage = new System.Windows.Forms.Button();
			this.btnStopCamera = new System.Windows.Forms.Button();
			this.btnStartCamera = new System.Windows.Forms.Button();
			this.txtBarcodeResult = new System.Windows.Forms.TextBox();
			this.cmbCamera = new System.Windows.Forms.ComboBox();
			this.pcbCamera = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.grpAddProduct.SuspendLayout();
			this.grpUpdateProduct.SuspendLayout();
			this.grpDeleteProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(277, 12);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(562, 535);
			this.dgvProduct.TabIndex = 0;
			this.dgvProduct.SelectionChanged += new System.EventHandler(this.dgvProduct_SelectionChanged);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			// 
			// grpAddProduct
			// 
			this.grpAddProduct.Controls.Add(this.btnAddProduct);
			this.grpAddProduct.Controls.Add(this.cmbCategoryName);
			this.grpAddProduct.Controls.Add(this.txtBarcode);
			this.grpAddProduct.Controls.Add(this.txtPrice);
			this.grpAddProduct.Controls.Add(this.txtProductName);
			this.grpAddProduct.Controls.Add(this.lblBarcode);
			this.grpAddProduct.Controls.Add(this.lblCategory);
			this.grpAddProduct.Controls.Add(this.lblPrice);
			this.grpAddProduct.Controls.Add(this.lblProduct);
			this.grpAddProduct.Location = new System.Drawing.Point(12, 12);
			this.grpAddProduct.Name = "grpAddProduct";
			this.grpAddProduct.Size = new System.Drawing.Size(247, 213);
			this.grpAddProduct.TabIndex = 1;
			this.grpAddProduct.TabStop = false;
			this.grpAddProduct.Text = "Ürün Ekle";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.BackColor = System.Drawing.Color.YellowGreen;
			this.btnAddProduct.Location = new System.Drawing.Point(9, 174);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(229, 23);
			this.btnAddProduct.TabIndex = 9;
			this.btnAddProduct.Text = "Ürün Ekle";
			this.btnAddProduct.UseVisualStyleBackColor = false;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// cmbCategoryName
			// 
			this.cmbCategoryName.FormattingEnabled = true;
			this.cmbCategoryName.Location = new System.Drawing.Point(9, 147);
			this.cmbCategoryName.Name = "cmbCategoryName";
			this.cmbCategoryName.Size = new System.Drawing.Size(229, 21);
			this.cmbCategoryName.TabIndex = 8;
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(9, 107);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(229, 20);
			this.txtBarcode.TabIndex = 7;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(9, 68);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(229, 20);
			this.txtPrice.TabIndex = 6;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(9, 29);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(229, 20);
			this.txtProductName.TabIndex = 5;
			// 
			// lblBarcode
			// 
			this.lblBarcode.AutoSize = true;
			this.lblBarcode.Location = new System.Drawing.Point(6, 91);
			this.lblBarcode.Name = "lblBarcode";
			this.lblBarcode.Size = new System.Drawing.Size(73, 13);
			this.lblBarcode.TabIndex = 4;
			this.lblBarcode.Text = "Ürün Barkodu";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(6, 131);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(79, 13);
			this.lblCategory.TabIndex = 3;
			this.lblCategory.Text = "Ürün Kategorisi";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(6, 52);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(57, 13);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "Ürün Fiyatı";
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(6, 16);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(48, 13);
			this.lblProduct.TabIndex = 0;
			this.lblProduct.Text = "Ürün Adı";
			// 
			// grpUpdateProduct
			// 
			this.grpUpdateProduct.Controls.Add(this.btnUpdateProduct);
			this.grpUpdateProduct.Controls.Add(this.cmbUpdateCategoryName);
			this.grpUpdateProduct.Controls.Add(this.txtUpdateBarcode);
			this.grpUpdateProduct.Controls.Add(this.txtUpdatePrice);
			this.grpUpdateProduct.Controls.Add(this.txtUpdateProductName);
			this.grpUpdateProduct.Controls.Add(this.label1);
			this.grpUpdateProduct.Controls.Add(this.label2);
			this.grpUpdateProduct.Controls.Add(this.label3);
			this.grpUpdateProduct.Controls.Add(this.label4);
			this.grpUpdateProduct.Location = new System.Drawing.Point(12, 251);
			this.grpUpdateProduct.Name = "grpUpdateProduct";
			this.grpUpdateProduct.Size = new System.Drawing.Size(247, 213);
			this.grpUpdateProduct.TabIndex = 10;
			this.grpUpdateProduct.TabStop = false;
			this.grpUpdateProduct.Text = "Ürün Güncelle";
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnUpdateProduct.Location = new System.Drawing.Point(9, 174);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(229, 23);
			this.btnUpdateProduct.TabIndex = 9;
			this.btnUpdateProduct.Text = "Ürün Güncelle";
			this.btnUpdateProduct.UseVisualStyleBackColor = false;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// cmbUpdateCategoryName
			// 
			this.cmbUpdateCategoryName.FormattingEnabled = true;
			this.cmbUpdateCategoryName.Location = new System.Drawing.Point(9, 147);
			this.cmbUpdateCategoryName.Name = "cmbUpdateCategoryName";
			this.cmbUpdateCategoryName.Size = new System.Drawing.Size(229, 21);
			this.cmbUpdateCategoryName.TabIndex = 8;
			// 
			// txtUpdateBarcode
			// 
			this.txtUpdateBarcode.Location = new System.Drawing.Point(9, 107);
			this.txtUpdateBarcode.Name = "txtUpdateBarcode";
			this.txtUpdateBarcode.Size = new System.Drawing.Size(229, 20);
			this.txtUpdateBarcode.TabIndex = 7;
			// 
			// txtUpdatePrice
			// 
			this.txtUpdatePrice.Location = new System.Drawing.Point(9, 68);
			this.txtUpdatePrice.Name = "txtUpdatePrice";
			this.txtUpdatePrice.Size = new System.Drawing.Size(229, 20);
			this.txtUpdatePrice.TabIndex = 6;
			// 
			// txtUpdateProductName
			// 
			this.txtUpdateProductName.Location = new System.Drawing.Point(9, 29);
			this.txtUpdateProductName.Name = "txtUpdateProductName";
			this.txtUpdateProductName.Size = new System.Drawing.Size(229, 20);
			this.txtUpdateProductName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ürün Barkodu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ürün Kategorisi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ürün Fiyatı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ürün Adı";
			// 
			// grpDeleteProduct
			// 
			this.grpDeleteProduct.Controls.Add(this.lblSelectedId);
			this.grpDeleteProduct.Controls.Add(this.btnDeleteCategory);
			this.grpDeleteProduct.Location = new System.Drawing.Point(12, 488);
			this.grpDeleteProduct.Name = "grpDeleteProduct";
			this.grpDeleteProduct.Size = new System.Drawing.Size(247, 78);
			this.grpDeleteProduct.TabIndex = 11;
			this.grpDeleteProduct.TabStop = false;
			this.grpDeleteProduct.Text = "Ürün Sil";
			// 
			// lblSelectedId
			// 
			this.lblSelectedId.AutoSize = true;
			this.lblSelectedId.Location = new System.Drawing.Point(114, 21);
			this.lblSelectedId.Name = "lblSelectedId";
			this.lblSelectedId.Size = new System.Drawing.Size(0, 13);
			this.lblSelectedId.TabIndex = 3;
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.BackColor = System.Drawing.Color.Crimson;
			this.btnDeleteCategory.Location = new System.Drawing.Point(9, 40);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(229, 23);
			this.btnDeleteCategory.TabIndex = 2;
			this.btnDeleteCategory.Text = "Ürün Sil";
			this.btnDeleteCategory.UseVisualStyleBackColor = false;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// btnMainPage
			// 
			this.btnMainPage.BackColor = System.Drawing.SystemColors.Control;
			this.btnMainPage.Location = new System.Drawing.Point(277, 553);
			this.btnMainPage.Name = "btnMainPage";
			this.btnMainPage.Size = new System.Drawing.Size(562, 23);
			this.btnMainPage.TabIndex = 4;
			this.btnMainPage.Text = "Ana Sayfa";
			this.btnMainPage.UseVisualStyleBackColor = false;
			this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
			// 
			// btnStopCamera
			// 
			this.btnStopCamera.Location = new System.Drawing.Point(1074, 517);
			this.btnStopCamera.Name = "btnStopCamera";
			this.btnStopCamera.Size = new System.Drawing.Size(191, 49);
			this.btnStopCamera.TabIndex = 16;
			this.btnStopCamera.Text = "Kamera Durdur";
			this.btnStopCamera.UseVisualStyleBackColor = true;
			this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
			// 
			// btnStartCamera
			// 
			this.btnStartCamera.Location = new System.Drawing.Point(859, 517);
			this.btnStartCamera.Name = "btnStartCamera";
			this.btnStartCamera.Size = new System.Drawing.Size(209, 49);
			this.btnStartCamera.TabIndex = 15;
			this.btnStartCamera.Text = "Kamera Başlat";
			this.btnStartCamera.UseVisualStyleBackColor = true;
			this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
			// 
			// txtBarcodeResult
			// 
			this.txtBarcodeResult.Location = new System.Drawing.Point(859, 490);
			this.txtBarcodeResult.Name = "txtBarcodeResult";
			this.txtBarcodeResult.Size = new System.Drawing.Size(406, 20);
			this.txtBarcodeResult.TabIndex = 14;
			// 
			// cmbCamera
			// 
			this.cmbCamera.FormattingEnabled = true;
			this.cmbCamera.Location = new System.Drawing.Point(859, 14);
			this.cmbCamera.Name = "cmbCamera";
			this.cmbCamera.Size = new System.Drawing.Size(406, 21);
			this.cmbCamera.TabIndex = 13;
			// 
			// pcbCamera
			// 
			this.pcbCamera.Location = new System.Drawing.Point(859, 41);
			this.pcbCamera.Name = "pcbCamera";
			this.pcbCamera.Size = new System.Drawing.Size(406, 443);
			this.pcbCamera.TabIndex = 12;
			this.pcbCamera.TabStop = false;
			// 
			// AdminProductPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1277, 588);
			this.Controls.Add(this.btnStopCamera);
			this.Controls.Add(this.btnStartCamera);
			this.Controls.Add(this.txtBarcodeResult);
			this.Controls.Add(this.cmbCamera);
			this.Controls.Add(this.pcbCamera);
			this.Controls.Add(this.btnMainPage);
			this.Controls.Add(this.grpDeleteProduct);
			this.Controls.Add(this.grpUpdateProduct);
			this.Controls.Add(this.grpAddProduct);
			this.Controls.Add(this.dgvProduct);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminProductPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminProductPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminProductPage_FormClosing);
			this.Load += new System.EventHandler(this.AdminProductPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.grpAddProduct.ResumeLayout(false);
			this.grpAddProduct.PerformLayout();
			this.grpUpdateProduct.ResumeLayout(false);
			this.grpUpdateProduct.PerformLayout();
			this.grpDeleteProduct.ResumeLayout(false);
			this.grpDeleteProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCamera)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduct;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.GroupBox grpAddProduct;
		private System.Windows.Forms.Label lblBarcode;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.ComboBox cmbCategoryName;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.GroupBox grpUpdateProduct;
		private System.Windows.Forms.Button btnUpdateProduct;
		private System.Windows.Forms.ComboBox cmbUpdateCategoryName;
		private System.Windows.Forms.TextBox txtUpdateBarcode;
		private System.Windows.Forms.TextBox txtUpdatePrice;
		private System.Windows.Forms.TextBox txtUpdateProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox grpDeleteProduct;
		private System.Windows.Forms.Label lblSelectedId;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnMainPage;
		private System.Windows.Forms.Button btnStopCamera;
		private System.Windows.Forms.Button btnStartCamera;
		private System.Windows.Forms.TextBox txtBarcodeResult;
		private System.Windows.Forms.ComboBox cmbCamera;
		private System.Windows.Forms.PictureBox pcbCamera;
	}
}