namespace db_connection
{
	partial class TempChart
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tmp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.save_chart_button = new System.Windows.Forms.Button();
			this.decline_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tmp_chart)).BeginInit();
			this.SuspendLayout();
			// 
			// tmp_chart
			// 
			chartArea1.Name = "ChartArea1";
			this.tmp_chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.tmp_chart.Legends.Add(legend1);
			this.tmp_chart.Location = new System.Drawing.Point(12, 12);
			this.tmp_chart.Name = "tmp_chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.tmp_chart.Series.Add(series1);
			this.tmp_chart.Size = new System.Drawing.Size(510, 429);
			this.tmp_chart.TabIndex = 0;
			this.tmp_chart.Text = "chart1";
			// 
			// save_chart_button
			// 
			this.save_chart_button.Location = new System.Drawing.Point(447, 447);
			this.save_chart_button.Name = "save_chart_button";
			this.save_chart_button.Size = new System.Drawing.Size(75, 23);
			this.save_chart_button.TabIndex = 1;
			this.save_chart_button.Text = "Save";
			this.save_chart_button.UseVisualStyleBackColor = true;
			this.save_chart_button.Click += new System.EventHandler(this.SaveChart);
			// 
			// decline_button
			// 
			this.decline_button.Location = new System.Drawing.Point(366, 447);
			this.decline_button.Name = "decline_button";
			this.decline_button.Size = new System.Drawing.Size(75, 23);
			this.decline_button.TabIndex = 2;
			this.decline_button.Text = "Decline";
			this.decline_button.UseVisualStyleBackColor = true;
			this.decline_button.Click += new System.EventHandler(this.DeclineSaveChart);
			// 
			// TempChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 475);
			this.Controls.Add(this.decline_button);
			this.Controls.Add(this.save_chart_button);
			this.Controls.Add(this.tmp_chart);
			this.Name = "TempChart";
			this.Text = "TempChart";
			((System.ComponentModel.ISupportInitialize)(this.tmp_chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart tmp_chart;
		private System.Windows.Forms.Button save_chart_button;
		private System.Windows.Forms.Button decline_button;
	}
}