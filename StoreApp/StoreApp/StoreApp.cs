using StoreApp.Category;
using StoreApp.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;
using StoreApp.DataAccess;

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

		private void btnProduct_Click(object sender, EventArgs e)
		{
			this.Hide();

			AdminProductPage productPage = new AdminProductPage();
			productPage.Show();
		}

		FilterInfoCollection devices;
		VideoCaptureDevice camera;

		private void StoreApp_Load(object sender, EventArgs e)
		{
			devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

			// FilterInfo görüntü yakalama cihazları hakkında bilgi tutar
			foreach (FilterInfo device in devices)
			{
				cmbCamera.Items.Add(device.Name);
			}

			cmbCamera.SelectedIndex = 0;
		}

		private void btnStartCamera_Click(object sender, EventArgs e)
		{
			camera = new VideoCaptureDevice(devices[cmbCamera.SelectedIndex].MonikerString);

			camera.NewFrame += VideoCaptureDevice_NewFrame;
			camera.Start();
		}

		double sum = 0;
		double price = 0;
		string tempBarcode = "";
		private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
		{
			Bitmap readBarcode = (Bitmap)eventArgs.Frame.Clone();
			BarcodeReader reader = new BarcodeReader();

			var result = reader.Decode(readBarcode);

			if (result != null)
			{
				txtBarcode.Invoke(new MethodInvoker(delegate ()
				{
					if (tempBarcode == result.ToString())
					{

					}
					else
					{
						tempBarcode = result.ToString();
						txtBarcode.Text = result.ToString();
						price = FindProductPrice(txtBarcode.Text);
						
						if (price == 0)
						{
							// MessageBox.Show("Barkod sistemde tanımlı değil!");
						}
						else
						{
							sum += price;
							rtxtTotal.Text = sum.ToString();
						}
					}
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

		private void StoreApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (camera != null)
			{
				if (camera.IsRunning)
				{
					camera.Stop();
				}
			}
		}

		private void btnResetTotal_Click(object sender, EventArgs e)
		{
			sum = 0;
		}

		public double FindProductPrice(string barcode)
		{
			SqlCommand commandFindProductPrice = new SqlCommand("select ProductPrice from Products where ProductBarcode=@pbarcode", DataConnection.connection);
			DataConnection.CheckConnection(DataConnection.connection);

			commandFindProductPrice.Parameters.AddWithValue("@pbarcode", barcode);

			SqlDataReader reader = commandFindProductPrice.ExecuteReader();

			double price = 0;
			while (reader.Read())
			{
				price = Convert.ToDouble(reader[0]);
			}

			reader.Close();

			return price;
		}

		private void btnIncrement_Click(object sender, EventArgs e)
		{
			sum += price;
			rtxtTotal.Text = sum.ToString();
		}

		private void btnDecrement_Click(object sender, EventArgs e)
		{
			sum -= price;
			rtxtTotal.Text = sum.ToString();
		}

	}
}
