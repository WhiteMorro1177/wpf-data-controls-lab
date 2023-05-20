using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using PdfConfig = iTextSharp.text;
using PdfElements = iTextSharp.text.pdf;
using iTextSharp.text;

namespace db_connection
{
	public partial class SaveDialog : Form
	{
		public System.Data.DataTable Data { get; private set; }

		private string html_string = string.Empty;


		public SaveDialog(System.Data.DataTable data_to_save)
		{
			InitializeComponent();
			open_file_dialog.InitialDirectory = "D:\\save_tests\\";
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
			Word.Document word_document =
				word_app.Documents.Add(missing, missing, missing, missing);

			Table data = word_document.Tables.Add
				(
					word_document.Range(),
					Data.Rows.Count + 1,
					Data.Columns.Count,
					missing,
					missing
				);
			data.Borders.Enable = 1;

			foreach (Row row in data.Rows)
			{
				foreach (Cell cell in row.Cells)
				{
					//Header row  
					if (cell.RowIndex == 1)
					{
						cell.Range.Text = Data.Columns[cell.ColumnIndex - 1].ColumnName;
						cell.Range.Font.Bold = 1;
					}
					else //Data row  
					{
						object[] data_cell = Data.Rows[row.Index - 2].ItemArray;
						cell.Range.Text = data_cell[cell.ColumnIndex - 1].ToString();
					}
				}
			}


			// save document
			try
			{
				word_document.SaveAs2(file_path_textbox.Text);
				word_document.Close(missing, missing, missing);
				word_document = null;
				word_app.Quit(missing, missing, missing);
				word_app = null;
				MessageBox.Show("Your document was sucsessfully saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot save document. Error: " + ex.Message);
			}
			Close();
		}

		private void OnSavePdfButtonClicked(object sender, EventArgs e)
		{
			PdfConfig.Document doc = new PdfConfig.Document(PageSize.A4);
			using (FileStream fs = new FileStream(file_path_textbox.Text, FileMode.Create))
			{
				// create cursor for document
				var pdf_writer = PdfElements.PdfWriter.GetInstance(doc, fs);
				doc.Open();

				// create table
				PdfElements.PdfPTable data = new PdfElements.PdfPTable(Data.Columns.Count);

				// fill the table
				for (int column_index = 0; column_index < Data.Columns.Count; column_index++) // header
				{
					data.AddCell(Data.Columns[column_index].ColumnName);
				}

				foreach (DataRow row in Data.Rows) // data
				{
					foreach (var cell in row.ItemArray)
					{
						data.AddCell(Translate(cell.ToString()));
					}
				}
				doc.Add(new Phrase("Table"));
				doc.Add(data);

				try
				{
					doc.Close();
					pdf_writer.Close();
					MessageBox.Show("Your pdf document sucsessfully saved");
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Saved terminated this error: " + ex.Message);
				}
			}
		}

		private string Translate(string cell_text)
		{
			string translated = "";
            if (!int.TryParse(cell_text, out int result))
            {
				cell_text.ToList().ForEach(x => translated += Config.words[x.ToString()]);
				return translated;
            }
			else return cell_text;
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
