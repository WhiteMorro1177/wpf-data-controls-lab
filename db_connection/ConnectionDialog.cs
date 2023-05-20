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

using static db_connection.Config;

namespace db_connection
{
	public partial class ConnectionDialog : Form
	{
		public ConnectionDialog()
		{
			InitializeComponent();
			server_name_textbox.Text = ".\\SQLEXPRESS";
			//database_name_textbox.Text = "QT_DB";
			database_name_textbox.Text = "db_connection";
		}

		private void OnConnectButtonClick(object sender, EventArgs e)
		{
			server_name = server_name_textbox.Text;
			database_name = database_name_textbox.Text;
			
			try
			{
				connection = new SqlConnection(sql_connection_string);
				connection.Open();

				MessageBox.Show("Connection accepted");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
