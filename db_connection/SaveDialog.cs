using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace db_connection
{
	public partial class SaveDialog : Form
	{
		public DataTable Data { get; private set; }

		public SaveDialog(DataTable data_to_save)
		{
			InitializeComponent();
			open_file_dialog.InitialDirectory = "D:\\";
			open_file_dialog.FileName = Config.last_file_path ?? "";

			Data = data_to_save;
		}

		private void OnSaveButtonClicked(object sender, EventArgs e)
		{
			string html_data = PrepareDocument();
			try
			{
				using (StreamWriter wr = new StreamWriter(file_path_textbox.Text)) 
				{ 
					wr.WriteLine(html_data); 
				}
				Close();
			}
			catch (Exception ex) { MessageBox.Show("Saving process was interupted by error: " + ex.Message); }
		}

		private string PrepareDocument()
		{
			string html_string = "<html><head></head><body><center>HTML Отчёт\n" +
				"<table border=1><tr>\n" +
				"<td>ID</td>\n" + 
				"<td>Наименование</td>\n" + 
				"<td>Категория</td></tr>\n";

			foreach (DataRow row in Data.Rows)
			{
				html_string += "<tr>\n" +
					$"<td>{row[0]}</td>\n" +
					$"<td>{row[1]}</td>\n" +
					$"<td>{row[2]}</td>\n" +
					"</tr>\n";
			}

			return html_string;
		}

		private void OpenFileChooser(object sender, EventArgs e)
		{
			open_file_dialog.FileName = Config.last_file_path ?? "";
			open_file_dialog.ShowDialog();

			file_path_textbox.Text = open_file_dialog.FileName;
			Config.last_file_path = open_file_dialog.FileName;
		}
	}
}
