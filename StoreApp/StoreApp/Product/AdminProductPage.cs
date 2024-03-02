using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreApp.DataAccess;
using StoreApp.Category;
using AForge.Video.DirectShow;
using ZXing;

namespace StoreApp.Product
{
	public partial class AdminProductPage : Form
	{
		public AdminProductPage()
		{
			InitializeComponent();
		}

		public void LoadProducts()
		{
			//SqlCommand commandProductList = new SqlCommand("select * from Products", DataConnection.connection);
			SqlCommand commandProductList = new SqlCommand("select ProductId, ProductName, Price, ProductBarcode, CategoryName from Products" +
															" inner join Categories on Products.CategoryId = Categories.CategoryId", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			SqlDataAdapter adapter = new SqlDataAdapter(commandProductList);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			dgvProduct.DataSource = dataTable;
		}

		public void LoadCategories() 
		{
			SqlCommand commandLoadCategories = new SqlCommand("select * from Categories", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			SqlDataAdapter adapter = new SqlDataAdapter(commandLoadCategories);
			DataTable dataTable = new DataTable();

			cmbCategoryName.DisplayMember = "CategoryName"; // Üzerinde yazan kısım
			cmbCategoryName.ValueMember = "CategoryId";     // Arka kısımda id ile işlem yapacak

			adapter.Fill(dataTable);
			cmbCategoryName.DataSource = dataTable;


			cmbUpdateCategoryName.DisplayMember = "CategoryName";
			cmbUpdateCategoryName.ValueMember = "CategoryId";

			cmbUpdateCategoryName.DataSource = dataTable;
		}

		public void LoadCategoriesNew()
		{
			SqlCommand commandLoadCategories = new SqlCommand("select * from Categories", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			SqlDataReader reader = commandLoadCategories.ExecuteReader();

			while (reader.Read())
			{
				cmbCategoryName.Items.Add(reader["CategoryName"].ToString());
			}

			reader.Close();

			cmbCategoryName.SelectedIndex = 0;
		}

		private void AdminProductPage_Load(object sender, EventArgs e)
		{
			LoadProducts();
			LoadCategories();   // LoadCategoriesNew();

			devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

			// FilterInfo görüntü yakalama cihazları hakkında bilgi tutar
			foreach (FilterInfo device in devices)
			{
				cmbCamera.Items.Add(device.Name);
			}

			cmbCamera.SelectedIndex = 0;
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			SqlCommand commandProductAdd = new SqlCommand("insert into Products (ProductName,Price,ProductBarcode,CategoryId) " +
															"values (@pname,@pprice,@pbarcode,@pcategory)", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandProductAdd.Parameters.AddWithValue("@pname", txtProductName.Text);
			commandProductAdd.Parameters.AddWithValue("@pprice", txtPrice.Text);
			commandProductAdd.Parameters.AddWithValue("@pbarcode", txtBarcode.Text);
			commandProductAdd.Parameters.AddWithValue("@pcategory", Convert.ToInt32(cmbCategoryName.SelectedValue));

			commandProductAdd.ExecuteNonQuery();

			IncreaseCategory();
			LoadProducts();
		}

		string selectedId;
		string selectedName;
		string selectedPrice;
		string selectedBarcode;
		string selectedCategory;
		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			SqlCommand commandUpdateCategory = new SqlCommand("update Products set ProductName=@pname, Price=@pprice, ProductBarcode=@pbarcode, CategoryId=@pcategory where ProductId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandUpdateCategory.Parameters.AddWithValue("@pid", Convert.ToInt32(selectedId));
			commandUpdateCategory.Parameters.AddWithValue("@pname", txtUpdateProductName.Text);
			commandUpdateCategory.Parameters.AddWithValue("@pprice", txtUpdatePrice.Text);
			commandUpdateCategory.Parameters.AddWithValue("@pbarcode", txtUpdateBarcode.Text);
			commandUpdateCategory.Parameters.AddWithValue("@pcategory", Convert.ToInt32(cmbUpdateCategoryName.SelectedValue));

			commandUpdateCategory.ExecuteNonQuery();

			MessageBox.Show("Ürün başarılı bir şekilde güncellendi!");

			LoadProducts();
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			SqlCommand commandDeleteProduct = new SqlCommand("delete from Products where ProductId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandDeleteProduct.Parameters.AddWithValue("@pid", Convert.ToInt32(selectedId));
			commandDeleteProduct.ExecuteNonQuery();

			MessageBox.Show("Ürün başarılı bir şekilde silindi!");

			DecreaseCategory();
			LoadProducts();
		}

		private void dgvProduct_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvProduct.CurrentRow == null) { }
			else
			{
				selectedId = dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
				lblSelectedId.Text = selectedId;

				selectedName = dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
				txtUpdateProductName.Text = selectedName;

				selectedPrice = dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
				txtUpdatePrice.Text = selectedPrice;

				selectedBarcode = dgvProduct.CurrentRow.Cells["ProductBarcode"].Value.ToString();
				txtUpdateBarcode.Text = selectedBarcode;

				selectedCategory = dgvProduct.CurrentRow.Cells["CategoryName"].Value.ToString();
				cmbUpdateCategoryName.Text = selectedCategory;
			}
		}

		public void IncreaseCategory()
		{
			SqlCommand commandIncreaseCategory = new SqlCommand("update Categories set ProductCount+=1 where CategoryId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandIncreaseCategory.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbCategoryName.SelectedValue));
			commandIncreaseCategory.ExecuteNonQuery();
		}

		public void DecreaseCategory()
		{
			SqlCommand commandIncreaseCategory = new SqlCommand("update Categories set ProductCount-=1 where CategoryId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandIncreaseCategory.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbCategoryName.SelectedValue));
			commandIncreaseCategory.ExecuteNonQuery();
		}

		private void btnMainPage_Click(object sender, EventArgs e)
		{
			this.Hide();

			StoreApp storeAppPage = new StoreApp();
			storeAppPage.Show();
		}

		FilterInfoCollection devices;
		VideoCaptureDevice camera;

		private void btnStartCamera_Click(object sender, EventArgs e)
		{
			camera = new VideoCaptureDevice(devices[cmbCamera.SelectedIndex].MonikerString);

			camera.NewFrame += VideoCaptureDevice_NewFrame;
			camera.Start();
		}

		private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
		{
			Bitmap readBarcode = (Bitmap)eventArgs.Frame.Clone();
			BarcodeReader reader = new BarcodeReader();

			var result = reader.Decode(readBarcode);

			if (result != null)
			{
				txtBarcode.Invoke(new MethodInvoker(delegate ()
				{
					txtBarcode.Text = result.ToString();
				}));
			}

			if (result != null)
			{
				txtBarcodeResult.Invoke(new MethodInvoker(delegate ()
				{
					txtBarcodeResult.Text = result.ToString();
				}));
			}

			pcbCamera.Image = readBarcode;
		}

		private void btnStopCamera_Click(object sender, EventArgs e)
		{
			if (camera != null)
			{
				if (camera.IsRunning)
				{
					camera.Stop();
				}
			}
		}

		private void AdminProductPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (camera != null)
			{
				if (camera.IsRunning)
				{
					camera.Stop();
				}
			}
		}

	}
}
