using StoreApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp.Category
{
	public partial class AdminCategoryPage : Form
	{
		public AdminCategoryPage()
		{
			InitializeComponent();
		}

		public void LoadCategories()
		{
			SqlCommand commandCategoryList = new SqlCommand("select * from Categories", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			SqlDataAdapter adapter = new SqlDataAdapter(commandCategoryList);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			dgvCategory.DataSource = dataTable;
		}

		private void AdminCategoryPage_Load(object sender, EventArgs e)
		{
			LoadCategories();
		}

		private void btnCategoryAdd_Click(object sender, EventArgs e)
		{
			SqlCommand commandCategoryAdd = new SqlCommand("insert into Categories (CategoryName) values (@pname)", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandCategoryAdd.Parameters.AddWithValue("pname", txtCategoryName.Text);
			commandCategoryAdd.ExecuteNonQuery();

			LoadCategories();
		}

		string selectedId;
		string selectedName;
		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			SqlCommand commandDeleteCategory = new SqlCommand("update Categories set CategoryName=@pname where CategoryId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandDeleteCategory.Parameters.AddWithValue("@pid", Convert.ToInt32(selectedId));
			commandDeleteCategory.Parameters.AddWithValue("@pname", txtUpdateCategoryName.Text);
			commandDeleteCategory.ExecuteNonQuery();

			MessageBox.Show("Kategori başarılı bir şekilde güncellendi!");

			LoadCategories();
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			SqlCommand commandDeleteCategory = new SqlCommand("delete from Categories where CategoryId=@pid", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandDeleteCategory.Parameters.AddWithValue("@pid", Convert.ToInt32(selectedId));
			commandDeleteCategory.ExecuteNonQuery();

			MessageBox.Show("Kategori başarılı bir şekilde silindi!");

			LoadCategories();
		}

		private void dgvCategory_SelectionChanged(object sender, EventArgs e)
		{
			selectedId = dgvCategory.CurrentRow.Cells["CategoryId"].Value.ToString();
			lblSelectedId.Text = selectedId;

			selectedName = dgvCategory.CurrentRow.Cells["CategoryName"].Value.ToString();
			txtUpdateCategoryName.Text = selectedName;
		}

	}
}
