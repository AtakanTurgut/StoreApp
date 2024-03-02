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

	}
}
