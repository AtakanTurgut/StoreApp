namespace StoreApp
{
	partial class StoreApp
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProduct = new System.Windows.Forms.Button();
			this.btnCategory = new System.Windows.Forms.Button();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pcbCamera = new System.Windows.Forms.PictureBox();
			this.cmbCamera = new System.Windows.Forms.ComboBox();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.btnStartCamera = new System.Windows.Forms.Button();
			this.btnStopCamera = new System.Windows.Forms.Button();
			this.rtxtTotal = new System.Windows.Forms.RichTextBox();
			this.btnResetTotal = new System.Windows.Forms.Button();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnDecrement = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
			this.panel1.Controls.Add(this.btnStopCamera);
			this.panel1.Controls.Add(this.btnProduct);
			this.panel1.Controls.Add(this.btnStartCamera);
			this.panel1.Controls.Add(this.btnCategory);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 517);
			this.panel1.TabIndex = 0;
			// 
			// btnProduct
			// 
			this.btnProduct.Location = new System.Drawing.Point(12, 91);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(178, 47);
			this.btnProduct.TabIndex = 1;
			this.btnProduct.Text = "Ürün İşlemleri";
			this.btnProduct.UseVisualStyleBackColor = true;
			this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
			// 
			// btnCategory
			// 
			this.btnCategory.Location = new System.Drawing.Point(12, 39);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(178, 46);
			this.btnCategory.TabIndex = 0;
			this.btnCategory.Text = "Kategori İşlemleri";
			this.btnCategory.UseVisualStyleBackColor = true;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			// 
			// pcbCamera
			// 
			this.pcbCamera.Location = new System.Drawing.Point(223, 39);
			this.pcbCamera.Name = "pcbCamera";
			this.pcbCamera.Size = new System.Drawing.Size(573, 439);
			this.pcbCamera.TabIndex = 1;
			this.pcbCamera.TabStop = false;
			// 
			// cmbCamera
			// 
			this.cmbCamera.FormattingEnabled = true;
			this.cmbCamera.Location = new System.Drawing.Point(223, 12);
			this.cmbCamera.Name = "cmbCamera";
			this.cmbCamera.Size = new System.Drawing.Size(573, 21);
			this.cmbCamera.TabIndex = 2;
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(223, 484);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(573, 20);
			this.txtBarcode.TabIndex = 3;
			// 
			// btnStartCamera
			// 
			this.btnStartCamera.Location = new System.Drawing.Point(12, 374);
			this.btnStartCamera.Name = "btnStartCamera";
			this.btnStartCamera.Size = new System.Drawing.Size(178, 49);
			this.btnStartCamera.TabIndex = 4;
			this.btnStartCamera.Text = "Kamera Başlat";
			this.btnStartCamera.UseVisualStyleBackColor = true;
			this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
			// 
			// btnStopCamera
			// 
			this.btnStopCamera.Location = new System.Drawing.Point(12, 429);
			this.btnStopCamera.Name = "btnStopCamera";
			this.btnStopCamera.Size = new System.Drawing.Size(178, 49);
			this.btnStopCamera.TabIndex = 5;
			this.btnStopCamera.Text = "Kamera Durdur";
			this.btnStopCamera.UseVisualStyleBackColor = true;
			this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
			// 
			// rtxtTotal
			// 
			this.rtxtTotal.Location = new System.Drawing.Point(813, 39);
			this.rtxtTotal.Name = "rtxtTotal";
			this.rtxtTotal.Size = new System.Drawing.Size(306, 384);
			this.rtxtTotal.TabIndex = 4;
			this.rtxtTotal.Text = "";
			// 
			// btnResetTotal
			// 
			this.btnResetTotal.Location = new System.Drawing.Point(813, 429);
			this.btnResetTotal.Name = "btnResetTotal";
			this.btnResetTotal.Size = new System.Drawing.Size(306, 31);
			this.btnResetTotal.TabIndex = 5;
			this.btnResetTotal.Text = "İşlemi Bitir";
			this.btnResetTotal.UseVisualStyleBackColor = true;
			this.btnResetTotal.Click += new System.EventHandler(this.btnResetTotal_Click);
			// 
			// btnIncrement
			// 
			this.btnIncrement.BackColor = System.Drawing.Color.GreenYellow;
			this.btnIncrement.Location = new System.Drawing.Point(813, 466);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(150, 38);
			this.btnIncrement.TabIndex = 6;
			this.btnIncrement.Text = "Miktar Arttır +1   +";
			this.btnIncrement.UseVisualStyleBackColor = false;
			this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
			// 
			// btnDecrement
			// 
			this.btnDecrement.BackColor = System.Drawing.Color.Crimson;
			this.btnDecrement.Location = new System.Drawing.Point(969, 467);
			this.btnDecrement.Name = "btnDecrement";
			this.btnDecrement.Size = new System.Drawing.Size(150, 38);
			this.btnDecrement.TabIndex = 7;
			this.btnDecrement.Text = "Miktar Azalt -1   -";
			this.btnDecrement.UseVisualStyleBackColor = false;
			this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
			// 
			// StoreApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1131, 517);
			this.Controls.Add(this.btnDecrement);
			this.Controls.Add(this.btnIncrement);
			this.Controls.Add(this.btnResetTotal);
			this.Controls.Add(this.rtxtTotal);
			this.Controls.Add(this.txtBarcode);
			this.Controls.Add(this.cmbCamera);
			this.Controls.Add(this.pcbCamera);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StoreApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Store App";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreApp_FormClosing);
			this.Load += new System.EventHandler(this.StoreApp_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbCamera)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.Button btnProduct;
		private System.Windows.Forms.Button btnStartCamera;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.ComboBox cmbCamera;
		private System.Windows.Forms.PictureBox pcbCamera;
		private System.Windows.Forms.Button btnStopCamera;
		private System.Windows.Forms.RichTextBox rtxtTotal;
		private System.Windows.Forms.Button btnResetTotal;
		private System.Windows.Forms.Button btnDecrement;
		private System.Windows.Forms.Button btnIncrement;
	}
}

