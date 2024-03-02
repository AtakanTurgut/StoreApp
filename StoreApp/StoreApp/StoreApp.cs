using StoreApp.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
	public partial class StoreApp : Form
	{
		public StoreApp()
		{
			InitializeComponent();
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			this.Hide();

			AdminCategoryPage categoryPage = new AdminCategoryPage();
			categoryPage.Show();
		}
	}
}
