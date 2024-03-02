using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StoreApp.DataAccess
{
	public class DataConnection
	{
		public static SqlConnection connection = new SqlConnection("server=DESKTOP-R6K64T9\\SQLEXPRESS;database=StoreAppDb;integrated security=true");

		public static void CheckConnection(SqlConnection sqlConnection)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed)
			{
				sqlConnection.Open();
			}
		}
	}
}
