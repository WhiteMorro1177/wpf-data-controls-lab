﻿namespace db_connection
{
	partial class SaveDialog
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
			this.file_path_textbox = new System.Windows.Forms.TextBox();
			this.save_html_button = new System.Windows.Forms.Button();
			this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
			this.open_file_chooser_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// file_path_textbox
			// 
			this.file_path_textbox.Location = new System.Drawing.Point(12, 25);
			this.file_path_textbox.Name = "file_path_textbox";
			this.file_path_textbox.Size = new System.Drawing.Size(507, 26);
			this.file_path_textbox.TabIndex = 0;
			// 
			// save_html_button
			// 
			this.save_html_button.Location = new System.Drawing.Point(12, 66);
			this.save_html_button.Name = "save_html_button";
			this.save_html_button.Size = new System.Drawing.Size(136, 30);
			this.save_html_button.TabIndex = 1;
			this.save_html_button.Text = "Save as HTML";
			this.save_html_button.UseVisualStyleBackColor = true;
			this.save_html_button.Click += new System.EventHandler(this.OnSaveHtmlButtonClicked);
			// 
			// open_file_dialog
			// 
			this.open_file_dialog.FileName = "openFileDialog";
			// 
			// open_file_chooser_button
			// 
			this.open_file_chooser_button.Location = new System.Drawing.Point(526, 25);
			this.open_file_chooser_button.Name = "open_file_chooser_button";
			this.open_file_chooser_button.Size = new System.Drawing.Size(74, 30);
			this.open_file_chooser_button.TabIndex = 2;
			this.open_file_chooser_button.Text = "Open";
			this.open_file_chooser_button.UseVisualStyleBackColor = true;
			this.open_file_chooser_button.Click += new System.EventHandler(this.OpenFileChooser);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(154, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "Export as WORD";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnSaveWordButtonClicked);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(312, 66);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 30);
			this.button2.TabIndex = 4;
			this.button2.Text = "Export as PDF";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.OnSavePdfButtonClicked);
			// 
			// SaveDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 108);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.open_file_chooser_button);
			this.Controls.Add(this.save_html_button);
			this.Controls.Add(this.file_path_textbox);
			this.MaximizeBox = false;
			this.Name = "SaveDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Save To File";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox file_path_textbox;
		private System.Windows.Forms.Button save_html_button;
		private System.Windows.Forms.OpenFileDialog open_file_dialog;
		private System.Windows.Forms.Button open_file_chooser_button;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}