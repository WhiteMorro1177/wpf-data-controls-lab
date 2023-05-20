namespace db_connection
{
	partial class DBConnection
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.connections_tool_strip_menu_item = new System.Windows.Forms.ToolStripMenuItem();
			this.connect_menu_item = new System.Windows.Forms.ToolStripMenuItem();
			this.select_button = new System.Windows.Forms.Button();
			this.data_grid_view = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.modifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.add_button = new System.Windows.Forms.Button();
			this.id_label = new System.Windows.Forms.Label();
			this.id_text_box = new System.Windows.Forms.TextBox();
			this.name_text_box = new System.Windows.Forms.TextBox();
			this.name_label = new System.Windows.Forms.Label();
			this.category_text_box = new System.Windows.Forms.TextBox();
			this.category_label = new System.Windows.Forms.Label();
			this.update_button = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.save_button = new System.Windows.Forms.Button();
			this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connections_tool_strip_menu_item,
            this.exportAsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(533, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// connections_tool_strip_menu_item
			// 
			this.connections_tool_strip_menu_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connect_menu_item});
			this.connections_tool_strip_menu_item.Name = "connections_tool_strip_menu_item";
			this.connections_tool_strip_menu_item.Size = new System.Drawing.Size(86, 22);
			this.connections_tool_strip_menu_item.Tag = "";
			this.connections_tool_strip_menu_item.Text = "Connections";
			// 
			// connect_menu_item
			// 
			this.connect_menu_item.Name = "connect_menu_item";
			this.connect_menu_item.Size = new System.Drawing.Size(151, 22);
			this.connect_menu_item.Text = "Connect to DB";
			this.connect_menu_item.Click += new System.EventHandler(this.OnConnect);
			// 
			// select_button
			// 
			this.select_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.select_button.Location = new System.Drawing.Point(8, 30);
			this.select_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.select_button.Name = "select_button";
			this.select_button.Size = new System.Drawing.Size(101, 32);
			this.select_button.TabIndex = 1;
			this.select_button.Text = "SELECT";
			this.select_button.UseVisualStyleBackColor = true;
			this.select_button.Click += new System.EventHandler(this.OnSelectButtonClicked);
			// 
			// data_grid_view
			// 
			this.data_grid_view.AllowUserToAddRows = false;
			this.data_grid_view.AllowUserToDeleteRows = false;
			this.data_grid_view.AllowUserToResizeColumns = false;
			this.data_grid_view.AllowUserToResizeRows = false;
			this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_grid_view.ContextMenuStrip = this.contextMenuStrip1;
			this.data_grid_view.Location = new System.Drawing.Point(113, 30);
			this.data_grid_view.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.data_grid_view.MultiSelect = false;
			this.data_grid_view.Name = "data_grid_view";
			this.data_grid_view.ReadOnly = true;
			this.data_grid_view.RowHeadersWidth = 62;
			this.data_grid_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.data_grid_view.RowTemplate.Height = 28;
			this.data_grid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.data_grid_view.Size = new System.Drawing.Size(413, 372);
			this.data_grid_view.TabIndex = 2;
			this.data_grid_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
			// 
			// modifyRecordToolStripMenuItem
			// 
			this.modifyRecordToolStripMenuItem.Name = "modifyRecordToolStripMenuItem";
			this.modifyRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.modifyRecordToolStripMenuItem.Text = "Modify Record";
			this.modifyRecordToolStripMenuItem.Click += new System.EventHandler(this.CallModifyDialog);
			// 
			// deleteRecordToolStripMenuItem
			// 
			this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
			this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteRecordToolStripMenuItem.Text = "Delete Record";
			this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteRecord);
			// 
			// add_button
			// 
			this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.add_button.Location = new System.Drawing.Point(8, 66);
			this.add_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(101, 32);
			this.add_button.TabIndex = 3;
			this.add_button.Text = "ADD";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.OnAddButtonClicked);
			// 
			// id_label
			// 
			this.id_label.AutoSize = true;
			this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.id_label.Location = new System.Drawing.Point(8, 126);
			this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.id_label.Name = "id_label";
			this.id_label.Size = new System.Drawing.Size(21, 17);
			this.id_label.TabIndex = 4;
			this.id_label.Text = "ID";
			// 
			// id_text_box
			// 
			this.id_text_box.Enabled = false;
			this.id_text_box.Location = new System.Drawing.Point(8, 151);
			this.id_text_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.id_text_box.Name = "id_text_box";
			this.id_text_box.Size = new System.Drawing.Size(102, 20);
			this.id_text_box.TabIndex = 5;
			// 
			// name_text_box
			// 
			this.name_text_box.Location = new System.Drawing.Point(8, 202);
			this.name_text_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.name_text_box.Name = "name_text_box";
			this.name_text_box.Size = new System.Drawing.Size(102, 20);
			this.name_text_box.TabIndex = 7;
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.name_label.Location = new System.Drawing.Point(8, 177);
			this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(45, 17);
			this.name_label.TabIndex = 6;
			this.name_label.Text = "Name";
			// 
			// category_text_box
			// 
			this.category_text_box.Location = new System.Drawing.Point(8, 252);
			this.category_text_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.category_text_box.Name = "category_text_box";
			this.category_text_box.Size = new System.Drawing.Size(102, 20);
			this.category_text_box.TabIndex = 9;
			// 
			// category_label
			// 
			this.category_label.AutoSize = true;
			this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.category_label.Location = new System.Drawing.Point(8, 227);
			this.category_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.category_label.Name = "category_label";
			this.category_label.Size = new System.Drawing.Size(65, 17);
			this.category_label.TabIndex = 8;
			this.category_label.Text = "Category";
			// 
			// update_button
			// 
			this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.update_button.Location = new System.Drawing.Point(8, 281);
			this.update_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.update_button.Name = "update_button";
			this.update_button.Size = new System.Drawing.Size(101, 32);
			this.update_button.TabIndex = 10;
			this.update_button.Text = "UPDATE";
			this.update_button.UseVisualStyleBackColor = true;
			this.update_button.Click += new System.EventHandler(this.OnUpdateButtonClicked);
			// 
			// delete_button
			// 
			this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.delete_button.Location = new System.Drawing.Point(8, 317);
			this.delete_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(101, 32);
			this.delete_button.TabIndex = 11;
			this.delete_button.Text = "DELETE";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.OnDeleteButtonClicked);
			// 
			// save_button
			// 
			this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.save_button.Location = new System.Drawing.Point(8, 369);
			this.save_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(101, 32);
			this.save_button.TabIndex = 12;
			this.save_button.Text = "SAVE";
			this.save_button.UseVisualStyleBackColor = true;
			this.save_button.Click += new System.EventHandler(this.OnSaveButtonClicked);
			// 
			// exportAsToolStripMenuItem
			// 
			this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphicsToolStripMenuItem});
			this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
			this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
			this.exportAsToolStripMenuItem.Text = "Export as...";
			// 
			// graphicsToolStripMenuItem
			// 
			this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
			this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.graphicsToolStripMenuItem.Text = "Graphics";
			this.graphicsToolStripMenuItem.Click += new System.EventHandler(this.ExportDiagram);
			// 
			// DBConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 410);
			this.Controls.Add(this.save_button);
			this.Controls.Add(this.delete_button);
			this.Controls.Add(this.update_button);
			this.Controls.Add(this.category_text_box);
			this.Controls.Add(this.category_label);
			this.Controls.Add(this.name_text_box);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.id_text_box);
			this.Controls.Add(this.id_label);
			this.Controls.Add(this.add_button);
			this.Controls.Add(this.data_grid_view);
			this.Controls.Add(this.select_button);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DBConnection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DB Connection";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connections_tool_strip_menu_item;
		private System.Windows.Forms.ToolStripMenuItem connect_menu_item;
		private System.Windows.Forms.Button select_button;
		private System.Windows.Forms.DataGridView data_grid_view;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Label id_label;
		private System.Windows.Forms.TextBox id_text_box;
		private System.Windows.Forms.TextBox name_text_box;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.TextBox category_text_box;
		private System.Windows.Forms.Label category_label;
		private System.Windows.Forms.Button update_button;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.Button save_button;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem modifyRecordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
	}
}

