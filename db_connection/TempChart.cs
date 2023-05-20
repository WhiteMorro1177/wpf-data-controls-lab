using Microsoft.Office.Interop.Word;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace db_connection
{
	public partial class TempChart : Form
	{
		public TempChart()
		{
			InitializeComponent();
		}

		public TempChart(SqlDataReader dr)
		{
			InitializeComponent();
			tmp_chart.Series.Clear();
			tmp_chart.Series.Add("Proceed");

			while (dr.Read())
			{
				tmp_chart.Series["Proceed"].Points.AddXY(dr[0], dr[1]);
			}
		}

		private void SaveChart(object sender, EventArgs e)
		{
			tmp_chart.SaveImage($"{Config.directory_for_files}\\chart.jpeg", ChartImageFormat.Jpeg);
			Close();
		}

		private void DeclineSaveChart(object sender, EventArgs e)
		{
			Close();
		}
	}
}
