namespace db_connection
{
	partial class ConnectionDialog
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
			this.connect_button = new System.Windows.Forms.Button();
			this.server_name_textbox = new System.Windows.Forms.TextBox();
			this.database_name_textbox = new System.Windows.Forms.TextBox();
			this.login_textbox = new System.Windows.Forms.TextBox();
			this.password_textbox = new System.Windows.Forms.TextBox();
			this.server_label = new System.Windows.Forms.Label();
			this.database_label = new System.Windows.Forms.Label();
			this.login_label = new System.Windows.Forms.Label();
			this.password_login = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// connect_button
			// 
			this.connect_button.Location = new System.Drawing.Point(12, 525);
			this.connect_button.Name = "connect_button";
			this.connect_button.Size = new System.Drawing.Size(280, 45);
			this.connect_button.TabIndex = 0;
			this.connect_button.Text = "Connect";
			this.connect_button.UseVisualStyleBackColor = true;
			this.connect_button.Click += new System.EventHandler(this.OnConnectButtonClick);
			// 
			// server_name_textbox
			// 
			this.server_name_textbox.Location = new System.Drawing.Point(8, 77);
			this.server_name_textbox.Name = "server_name_textbox";
			this.server_name_textbox.Size = new System.Drawing.Size(280, 26);
			this.server_name_textbox.TabIndex = 1;
			// 
			// database_name_textbox
			// 
			this.database_name_textbox.Location = new System.Drawing.Point(8, 188);
			this.database_name_textbox.Name = "database_name_textbox";
			this.database_name_textbox.Size = new System.Drawing.Size(280, 26);
			this.database_name_textbox.TabIndex = 2;
			// 
			// login_textbox
			// 
			this.login_textbox.Location = new System.Drawing.Point(12, 318);
			this.login_textbox.Name = "login_textbox";
			this.login_textbox.Size = new System.Drawing.Size(280, 26);
			this.login_textbox.TabIndex = 3;
			// 
			// password_textbox
			// 
			this.password_textbox.Location = new System.Drawing.Point(12, 435);
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.Size = new System.Drawing.Size(280, 26);
			this.password_textbox.TabIndex = 4;
			// 
			// server_label
			// 
			this.server_label.AutoSize = true;
			this.server_label.Location = new System.Drawing.Point(8, 54);
			this.server_label.Name = "server_label";
			this.server_label.Size = new System.Drawing.Size(55, 20);
			this.server_label.TabIndex = 5;
			this.server_label.Text = "Server";
			// 
			// database_label
			// 
			this.database_label.AutoSize = true;
			this.database_label.Location = new System.Drawing.Point(8, 165);
			this.database_label.Name = "database_label";
			this.database_label.Size = new System.Drawing.Size(79, 20);
			this.database_label.TabIndex = 6;
			this.database_label.Text = "Database";
			// 
			// login_label
			// 
			this.login_label.AutoSize = true;
			this.login_label.Location = new System.Drawing.Point(12, 295);
			this.login_label.Name = "login_label";
			this.login_label.Size = new System.Drawing.Size(48, 20);
			this.login_label.TabIndex = 7;
			this.login_label.Text = "Login";
			// 
			// password_login
			// 
			this.password_login.AutoSize = true;
			this.password_login.Location = new System.Drawing.Point(12, 412);
			this.password_login.Name = "password_login";
			this.password_login.Size = new System.Drawing.Size(78, 20);
			this.password_login.TabIndex = 8;
			this.password_login.Text = "Password";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 610);
			this.Controls.Add(this.password_login);
			this.Controls.Add(this.login_label);
			this.Controls.Add(this.database_label);
			this.Controls.Add(this.server_label);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.login_textbox);
			this.Controls.Add(this.database_name_textbox);
			this.Controls.Add(this.server_name_textbox);
			this.Controls.Add(this.connect_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connect to DB";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button connect_button;
		private System.Windows.Forms.TextBox server_name_textbox;
		private System.Windows.Forms.TextBox database_name_textbox;
		private System.Windows.Forms.TextBox login_textbox;
		private System.Windows.Forms.TextBox password_textbox;
		private System.Windows.Forms.Label server_label;
		private System.Windows.Forms.Label database_label;
		private System.Windows.Forms.Label login_label;
		private System.Windows.Forms.Label password_login;
	}
}