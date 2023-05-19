using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace db_connection
{
	public partial class ModifyDialog : Form
	{
		public ModifyDialog(List<string> record)
		{
			InitializeComponent();

			id_text_box.Text = record[0].ToString();
			name_text_box.Text = record[1].ToString();
			category_text_box.Text = record[2].ToString();

		}

		private void OnModifyButtonClick(object sender, EventArgs e)
		{
			SqlCommand update_cmd = new SqlCommand($"update product set name = '{name_text_box.Text}', category = '{category_text_box.Text}' where id = {int.Parse(id_text_box.Text)}", Config.connection);

			if (update_cmd.ExecuteNonQuery() != 1)
				throw new Exception("Error while executing update command");
			
			Close();
		}
	}
}
