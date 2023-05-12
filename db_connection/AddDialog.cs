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

namespace db_connection
{
	public partial class AddDialog : Form
	{
		public AddDialog()
		{
			InitializeComponent();
		}

		
		private void AddNewRecordEvent(object sender, EventArgs e)
		{
			string name = name_textbox.Text;
			string category = category_textbox.Text;

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.InsertCommand = new SqlCommand("insert into product values (@name, @category)", Config.connection);
			adapter.InsertCommand.Parameters.AddWithValue("@name", name);
			adapter.InsertCommand.Parameters.AddWithValue("@category", category);

			if (adapter.InsertCommand.ExecuteNonQuery() != 1)
			{
				throw new Exception("Error while executing insert commmand");
			}

			Close();
		}
	}
}
