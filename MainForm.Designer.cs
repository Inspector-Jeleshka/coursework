namespace coursework
{
	partial class MainForm
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
			tabControl = new TabControl();
			clientsTabPage = new TabPage();
			clientsDataGrid = new DataGridView();
			ordersTabPage = new TabPage();
			productsTabPage = new TabPage();
			tabPage4 = new TabPage();
			tabControl.SuspendLayout();
			clientsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).BeginInit();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(clientsTabPage);
			tabControl.Controls.Add(ordersTabPage);
			tabControl.Controls.Add(productsTabPage);
			tabControl.Controls.Add(tabPage4);
			tabControl.Location = new Point(12, 12);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(466, 248);
			tabControl.TabIndex = 0;
			// 
			// clientsTabPage
			// 
			clientsTabPage.Controls.Add(clientsDataGrid);
			clientsTabPage.Location = new Point(4, 24);
			clientsTabPage.Name = "clientsTabPage";
			clientsTabPage.Padding = new Padding(3);
			clientsTabPage.Size = new Size(458, 220);
			clientsTabPage.TabIndex = 0;
			clientsTabPage.Text = "Клиенты";
			clientsTabPage.UseVisualStyleBackColor = true;
			clientsTabPage.Enter += clientsTabPage_Enter;
			// 
			// clientsDataGrid
			// 
			clientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientsDataGrid.Dock = DockStyle.Fill;
			clientsDataGrid.Location = new Point(3, 3);
			clientsDataGrid.Name = "clientsDataGrid";
			clientsDataGrid.Size = new Size(452, 214);
			clientsDataGrid.TabIndex = 1;
			// 
			// ordersTabPage
			// 
			ordersTabPage.Location = new Point(4, 24);
			ordersTabPage.Name = "ordersTabPage";
			ordersTabPage.Padding = new Padding(3);
			ordersTabPage.Size = new Size(342, 149);
			ordersTabPage.TabIndex = 1;
			ordersTabPage.Text = "Заказы";
			ordersTabPage.UseVisualStyleBackColor = true;
			// 
			// productsTabPage
			// 
			productsTabPage.Location = new Point(4, 24);
			productsTabPage.Name = "productsTabPage";
			productsTabPage.Padding = new Padding(3);
			productsTabPage.Size = new Size(342, 149);
			productsTabPage.TabIndex = 2;
			productsTabPage.Text = "Товары";
			productsTabPage.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(342, 149);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "tabPage4";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl);
			Name = "MainForm";
			Text = "MainForm";
			tabControl.ResumeLayout(false);
			clientsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage clientsTabPage;
		private TabPage ordersTabPage;
		private TabPage productsTabPage;
		private TabPage tabPage4;
		private DataGridView clientsDataGrid;
	}
}