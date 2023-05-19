namespace db_connection
{
	partial class ModifyDialog
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
			this.modify_button = new System.Windows.Forms.Button();
			this.name_label = new System.Windows.Forms.Label();
			this.category_label = new System.Windows.Forms.Label();
			this.name_text_box = new System.Windows.Forms.TextBox();
			this.category_text_box = new System.Windows.Forms.TextBox();
			this.id_label = new System.Windows.Forms.Label();
			this.id_text_box = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// modify_button
			// 
			this.modify_button.Location = new System.Drawing.Point(12, 299);
			this.modify_button.Name = "modify_button";
			this.modify_button.Size = new System.Drawing.Size(285, 34);
			this.modify_button.TabIndex = 1;
			this.modify_button.Text = "Modify";
			this.modify_button.UseVisualStyleBackColor = true;
			this.modify_button.Click += new System.EventHandler(this.OnModifyButtonClick);
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Location = new System.Drawing.Point(12, 108);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(51, 20);
			this.name_label.TabIndex = 2;
			this.name_label.Text = "Name";
			// 
			// category_label
			// 
			this.category_label.AutoSize = true;
			this.category_label.Location = new System.Drawing.Point(12, 204);
			this.category_label.Name = "category_label";
			this.category_label.Size = new System.Drawing.Size(73, 20);
			this.category_label.TabIndex = 3;
			this.category_label.Text = "Category";
			// 
			// name_text_box
			// 
			this.name_text_box.Location = new System.Drawing.Point(12, 131);
			this.name_text_box.Name = "name_text_box";
			this.name_text_box.Size = new System.Drawing.Size(285, 26);
			this.name_text_box.TabIndex = 5;
			// 
			// category_text_box
			// 
			this.category_text_box.Location = new System.Drawing.Point(12, 227);
			this.category_text_box.Name = "category_text_box";
			this.category_text_box.Size = new System.Drawing.Size(285, 26);
			this.category_text_box.TabIndex = 6;
			// 
			// id_label
			// 
			this.id_label.AutoSize = true;
			this.id_label.Location = new System.Drawing.Point(12, 9);
			this.id_label.Name = "id_label";
			this.id_label.Size = new System.Drawing.Size(26, 20);
			this.id_label.TabIndex = 0;
			this.id_label.Text = "ID";
			// 
			// id_text_box
			// 
			this.id_text_box.Enabled = false;
			this.id_text_box.Location = new System.Drawing.Point(12, 32);
			this.id_text_box.Name = "id_text_box";
			this.id_text_box.Size = new System.Drawing.Size(285, 26);
			this.id_text_box.TabIndex = 4;
			// 
			// ModifyDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 349);
			this.Controls.Add(this.category_text_box);
			this.Controls.Add(this.name_text_box);
			this.Controls.Add(this.id_text_box);
			this.Controls.Add(this.category_label);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.modify_button);
			this.Controls.Add(this.id_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ModifyDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modify Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button modify_button;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.Label category_label;
		private System.Windows.Forms.TextBox name_text_box;
		private System.Windows.Forms.TextBox category_text_box;
		private System.Windows.Forms.Label id_label;
		private System.Windows.Forms.TextBox id_text_box;
	}
}