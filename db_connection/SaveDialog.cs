using Word = Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Linq;
using System.Diagnostics;

namespace db_connection
{
	public partial class SaveDialog : Form
	{
		public System.Data.DataTable Data { get; private set; }

		private string html_string = string.Empty;


		public SaveDialog(System.Data.DataTable data_to_save)
		{
			InitializeComponent();
			open_file_dialog.InitialDirectory = "D:\\";
			open_file_dialog.FileName = Config.last_file_path ?? "";

			Data = data_to_save;
			html_string = PrepareHTML();
		}

		private void OpenFileChooser(object sender, EventArgs e)
		{
			open_file_dialog.ShowDialog();

			file_path_textbox.Text = open_file_dialog.FileName;
			Config.last_file_path = open_file_dialog.FileName;
		}

		private void OnSaveHtmlButtonClicked(object sender, EventArgs e)
		{
			try
			{
				using (StreamWriter wr = new StreamWriter(file_path_textbox.Text))
				{
					wr.WriteLine(html_string);
				}
				Close();
			}
			catch (Exception ex) { MessageBox.Show("Saving process was interupted by error: " + ex.Message); }
		}

		private void OnSaveWordButtonClicked(object sender, EventArgs e)
		{
			object missing = System.Reflection.Missing.Value;
			Word.Application word_app =
				new Word.Application();
			Document word_document =
				word_app.Documents.Add(missing, missing, missing, missing);

			Table data = word_document.Tables.Add
				(
					word_document.Range(),
					Data.Rows.Count,
					Data.Columns.Count,
					missing,
					missing
				);

			foreach (Row row in data.Rows)
			{
                foreach (Cell cell in row.Cells)
                {
					//Header row  
					if (cell.RowIndex == 1)
					{
						cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
						cell.Range.Font.Bold = 1;
						//other format properties goes here  
						cell.Range.Font.Name = "verdana";
						cell.Range.Font.Size = 10;
						//cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
						cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
						//Center alignment for the Header cells  
						cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

					}
					//Data row  
					else
					{
						object[] data_cell = Data.Rows[row.Index].ItemArray;
						cell.Range.Text = data_cell[cell.ColumnIndex - 1].ToString();
					}
				}
            }


			// save document

			try
			{
				word_document.SaveAs2(file_path_textbox.Text);
				word_document.Close();
				word_document = null;

				word_app.Quit();
				word_app = null;
			} catch (Exception ex)
			{
				MessageBox.Show("Cannot save document. Error: " + ex.Message);
			}


		}

		private void OnSavePdfButtonClicked(object sender, EventArgs e)
		{

		}


		private string PrepareHTML()
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
	}
}
