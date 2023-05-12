namespace db_connection
{
	partial class AddDialog
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
			this.category_textbox = new System.Windows.Forms.TextBox();
			this.category_label = new System.Windows.Forms.Label();
			this.name_textbox = new System.Windows.Forms.TextBox();
			this.name_label = new System.Windows.Forms.Label();
			this.add_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// category_textbox
			// 
			this.category_textbox.Location = new System.Drawing.Point(12, 167);
			this.category_textbox.Name = "category_textbox";
			this.category_textbox.Size = new System.Drawing.Size(320, 26);
			this.category_textbox.TabIndex = 14;
			// 
			// category_label
			// 
			this.category_label.AutoSize = true;
			this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.category_label.Location = new System.Drawing.Point(12, 129);
			this.category_label.Name = "category_label";
			this.category_label.Size = new System.Drawing.Size(92, 25);
			this.category_label.TabIndex = 13;
			this.category_label.Text = "Category";
			// 
			// name_textbox
			// 
			this.name_textbox.Location = new System.Drawing.Point(12, 91);
			this.name_textbox.Name = "name_textbox";
			this.name_textbox.Size = new System.Drawing.Size(320, 26);
			this.name_textbox.TabIndex = 12;
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.name_label.Location = new System.Drawing.Point(12, 53);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(64, 25);
			this.name_label.TabIndex = 11;
			this.name_label.Text = "Name";
			// 
			// add_button
			// 
			this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.add_button.Location = new System.Drawing.Point(12, 241);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(320, 50);
			this.add_button.TabIndex = 10;
			this.add_button.Text = "ADD";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.AddNewRecordEvent);
			// 
			// AddDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 308);
			this.Controls.Add(this.category_textbox);
			this.Controls.Add(this.category_label);
			this.Controls.Add(this.name_textbox);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.add_button);
			this.Name = "AddDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Record";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox category_textbox;
		private System.Windows.Forms.Label category_label;
		private System.Windows.Forms.TextBox name_textbox;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.Button add_button;
	}
}