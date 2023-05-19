using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_connection
{
	public partial class DBConnection : Form
	{
		public DBConnection()
		{
			InitializeComponent();
			data_grid_view.AllowUserToResizeColumns = false;
		}

		private void ClearFields()
		{
			id_text_box.Text = "";
			name_text_box.Text = "";
			category_text_box.Text = "";
		}

		private void OnConnect(object sender, EventArgs e)
		{
			try { new ConnectionDialog().ShowDialog(); }
			catch { MessageBox.Show("Please, connect to server first"); }
		}

		private void OnSelectButtonClicked(object sender, EventArgs e)
		{
			SqlCommand select_cmd = new SqlCommand("select * from product", Config.connection);
			SqlDataAdapter adapter = new SqlDataAdapter(select_cmd);
			DataTable current_table = new DataTable();
			adapter.Fill(current_table);
			data_grid_view.DataSource = current_table;
		}

		private void OnAddButtonClicked(object sender, EventArgs e)
		{
			new AddDialog().ShowDialog();
			select_button.PerformClick();
		}

		private void SelectRow(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selected_row = data_grid_view.SelectedRows[0];

			id_text_box.Text = selected_row.Cells[0].Value.ToString();
			name_text_box.Text = selected_row.Cells[1].Value.ToString();
			category_text_box.Text = selected_row.Cells[2].Value.ToString();
		}

		private void OnUpdateButtonClicked(object sender, EventArgs e)
		{
			SqlCommand update_cmd = new SqlCommand($"update product set name = '{name_text_box.Text}', category = '{category_text_box.Text}' where id = {int.Parse(id_text_box.Text)}", Config.connection);

			if (update_cmd.ExecuteNonQuery() != 1)
				throw new Exception("Error while executing update command");

			select_button.PerformClick();
			ClearFields();
		}

		private void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			SqlCommand delete_cmd = new SqlCommand($"delete from product where id = {int.Parse(id_text_box.Text)}", Config.connection);
			
			if (delete_cmd.ExecuteNonQuery() != 1)
				throw new Exception("Error while executing delete command");

			select_button.PerformClick();
			ClearFields();
		}


		// TODO(need to get data from DataGridView, not from another "select")
		private void OnSaveButtonClicked(object sender, EventArgs e)
		{
			SqlCommand select_cmd = new SqlCommand("select * from product", Config.connection);
			SqlDataAdapter adapter = new SqlDataAdapter(select_cmd);
			DataTable current_table = new DataTable();

			adapter.Fill(current_table);

			Debug.WriteLine($"Rows: {current_table.Rows.Count}");
			Debug.WriteLine($"Columns: {current_table.Columns.Count}");


			new SaveDialog(current_table).ShowDialog();
		}

		private void CallModifyDialog(object sender, EventArgs e)
		{
			List<string> selected_row = new List<string> { id_text_box.Text, name_text_box.Text, category_text_box.Text };
			
			new ModifyDialog(selected_row).ShowDialog();

			select_button.PerformClick();
		}

		private void OnDeleteRecord(object sender, EventArgs e)
		{
			SqlCommand delete_cmd = new SqlCommand($"delete from product where id = {int.Parse(id_text_box.Text)}", Config.connection);

			if (delete_cmd.ExecuteNonQuery() != 1)
				throw new Exception("Error while executing delete command");

			select_button.PerformClick();
		}
	}
}
