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
			tabs = new TabControl();
			clientsTabPage = new TabPage();
			addClientBalanceButton = new Button();
			clientsDataGrid = new DataGridView();
			addClientOrderButton = new Button();
			showClientOrdersButton = new Button();
			removeClientButton = new Button();
			setClientButton = new Button();
			addClientButton = new Button();
			warehousesTabPage = new TabPage();
			addWarehouseBalanceButton = new Button();
			addWarehouseOrderButton = new Button();
			showWarehouseOrdersButton = new Button();
			removeWarehouseButton = new Button();
			setWarehouseButton = new Button();
			addWarehouseButton = new Button();
			warehousesDataGrid = new DataGridView();
			productsTabPage = new TabPage();
			removeProductButton = new Button();
			setProductButton = new Button();
			addProductButton = new Button();
			productsDataGrid = new DataGridView();
			ordersTabPage = new TabPage();
			ordersDataGrid = new DataGridView();
			suppliersTabPage = new TabPage();
			suppliersDataGrid = new DataGridView();
			tabs.SuspendLayout();
			clientsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).BeginInit();
			warehousesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)warehousesDataGrid).BeginInit();
			productsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
			ordersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ordersDataGrid).BeginInit();
			suppliersTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)suppliersDataGrid).BeginInit();
			SuspendLayout();
			// 
			// tabs
			// 
			tabs.Controls.Add(clientsTabPage);
			tabs.Controls.Add(warehousesTabPage);
			tabs.Controls.Add(productsTabPage);
			tabs.Controls.Add(ordersTabPage);
			tabs.Controls.Add(suppliersTabPage);
			tabs.Location = new Point(12, 12);
			tabs.Name = "tabs";
			tabs.SelectedIndex = 0;
			tabs.Size = new Size(718, 452);
			tabs.TabIndex = 0;
			// 
			// clientsTabPage
			// 
			clientsTabPage.Controls.Add(addClientBalanceButton);
			clientsTabPage.Controls.Add(clientsDataGrid);
			clientsTabPage.Controls.Add(addClientOrderButton);
			clientsTabPage.Controls.Add(showClientOrdersButton);
			clientsTabPage.Controls.Add(removeClientButton);
			clientsTabPage.Controls.Add(setClientButton);
			clientsTabPage.Controls.Add(addClientButton);
			clientsTabPage.Location = new Point(4, 24);
			clientsTabPage.Name = "clientsTabPage";
			clientsTabPage.Padding = new Padding(3);
			clientsTabPage.Size = new Size(710, 424);
			clientsTabPage.TabIndex = 0;
			clientsTabPage.Text = "Клиенты";
			clientsTabPage.UseVisualStyleBackColor = true;
			// 
			// addClientBalanceButton
			// 
			addClientBalanceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addClientBalanceButton.Location = new Point(549, 292);
			addClientBalanceButton.Name = "addClientBalanceButton";
			addClientBalanceButton.Size = new Size(131, 40);
			addClientBalanceButton.TabIndex = 9;
			addClientBalanceButton.Text = "Пополнить баланс\r\nклиента";
			addClientBalanceButton.UseVisualStyleBackColor = true;
			// 
			// clientsDataGrid
			// 
			clientsDataGrid.AllowUserToAddRows = false;
			clientsDataGrid.AllowUserToDeleteRows = false;
			clientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientsDataGrid.Dock = DockStyle.Left;
			clientsDataGrid.Location = new Point(3, 3);
			clientsDataGrid.MultiSelect = false;
			clientsDataGrid.Name = "clientsDataGrid";
			clientsDataGrid.ReadOnly = true;
			clientsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			clientsDataGrid.Size = new Size(506, 418);
			clientsDataGrid.TabIndex = 8;
			// 
			// addClientOrderButton
			// 
			addClientOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addClientOrderButton.Location = new Point(549, 200);
			addClientOrderButton.Name = "addClientOrderButton";
			addClientOrderButton.Size = new Size(131, 40);
			addClientOrderButton.TabIndex = 6;
			addClientOrderButton.Text = "Добавить заказ";
			addClientOrderButton.UseVisualStyleBackColor = true;
			// 
			// showClientOrdersButton
			// 
			showClientOrdersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			showClientOrdersButton.Location = new Point(549, 246);
			showClientOrdersButton.Name = "showClientOrdersButton";
			showClientOrdersButton.Size = new Size(131, 40);
			showClientOrdersButton.TabIndex = 5;
			showClientOrdersButton.Text = "Просмотреть заказы\r\nклиента";
			showClientOrdersButton.UseVisualStyleBackColor = true;
			// 
			// removeClientButton
			// 
			removeClientButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			removeClientButton.Location = new Point(549, 123);
			removeClientButton.Name = "removeClientButton";
			removeClientButton.Size = new Size(131, 40);
			removeClientButton.TabIndex = 4;
			removeClientButton.Text = "Удалить клиента";
			removeClientButton.UseVisualStyleBackColor = true;
			// 
			// setClientButton
			// 
			setClientButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			setClientButton.Location = new Point(549, 77);
			setClientButton.Name = "setClientButton";
			setClientButton.Size = new Size(131, 40);
			setClientButton.TabIndex = 3;
			setClientButton.Text = "Изменить данные\r\nклиента";
			setClientButton.UseVisualStyleBackColor = true;
			setClientButton.Click += setClientButton_Click;
			// 
			// addClientButton
			// 
			addClientButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addClientButton.Location = new Point(549, 31);
			addClientButton.Name = "addClientButton";
			addClientButton.Size = new Size(131, 40);
			addClientButton.TabIndex = 2;
			addClientButton.Text = "Добавить нового\r\nклиента";
			addClientButton.UseVisualStyleBackColor = true;
			addClientButton.Click += addClientButton_Click;
			// 
			// warehousesTabPage
			// 
			warehousesTabPage.Controls.Add(addWarehouseBalanceButton);
			warehousesTabPage.Controls.Add(addWarehouseOrderButton);
			warehousesTabPage.Controls.Add(showWarehouseOrdersButton);
			warehousesTabPage.Controls.Add(removeWarehouseButton);
			warehousesTabPage.Controls.Add(setWarehouseButton);
			warehousesTabPage.Controls.Add(addWarehouseButton);
			warehousesTabPage.Controls.Add(warehousesDataGrid);
			warehousesTabPage.Location = new Point(4, 24);
			warehousesTabPage.Name = "warehousesTabPage";
			warehousesTabPage.Padding = new Padding(3);
			warehousesTabPage.Size = new Size(710, 424);
			warehousesTabPage.TabIndex = 1;
			warehousesTabPage.Text = "Склады";
			warehousesTabPage.UseVisualStyleBackColor = true;
			// 
			// addWarehouseBalanceButton
			// 
			addWarehouseBalanceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addWarehouseBalanceButton.Location = new Point(549, 292);
			addWarehouseBalanceButton.Name = "addWarehouseBalanceButton";
			addWarehouseBalanceButton.Size = new Size(131, 40);
			addWarehouseBalanceButton.TabIndex = 13;
			addWarehouseBalanceButton.Text = "Пополнить баланс\r\nсклада";
			addWarehouseBalanceButton.UseVisualStyleBackColor = true;
			// 
			// addWarehouseOrderButton
			// 
			addWarehouseOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addWarehouseOrderButton.Location = new Point(549, 200);
			addWarehouseOrderButton.Name = "addWarehouseOrderButton";
			addWarehouseOrderButton.Size = new Size(131, 40);
			addWarehouseOrderButton.TabIndex = 12;
			addWarehouseOrderButton.Text = "Добавить заказ";
			addWarehouseOrderButton.UseVisualStyleBackColor = true;
			// 
			// showWarehouseOrdersButton
			// 
			showWarehouseOrdersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			showWarehouseOrdersButton.Location = new Point(549, 246);
			showWarehouseOrdersButton.Name = "showWarehouseOrdersButton";
			showWarehouseOrdersButton.Size = new Size(131, 40);
			showWarehouseOrdersButton.TabIndex = 11;
			showWarehouseOrdersButton.Text = "Просмотреть\r\nзаказы от склада";
			showWarehouseOrdersButton.UseVisualStyleBackColor = true;
			// 
			// removeWarehouseButton
			// 
			removeWarehouseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			removeWarehouseButton.Location = new Point(549, 123);
			removeWarehouseButton.Name = "removeWarehouseButton";
			removeWarehouseButton.Size = new Size(131, 40);
			removeWarehouseButton.TabIndex = 10;
			removeWarehouseButton.Text = "Удалить склад";
			removeWarehouseButton.UseVisualStyleBackColor = true;
			// 
			// setWarehouseButton
			// 
			setWarehouseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			setWarehouseButton.Location = new Point(549, 77);
			setWarehouseButton.Name = "setWarehouseButton";
			setWarehouseButton.Size = new Size(131, 40);
			setWarehouseButton.TabIndex = 9;
			setWarehouseButton.Text = "Изменить данные\r\nсклада";
			setWarehouseButton.UseVisualStyleBackColor = true;
			// 
			// addWarehouseButton
			// 
			addWarehouseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addWarehouseButton.Location = new Point(549, 31);
			addWarehouseButton.Name = "addWarehouseButton";
			addWarehouseButton.Size = new Size(131, 40);
			addWarehouseButton.TabIndex = 8;
			addWarehouseButton.Text = "Добавить новый\r\nсклад";
			addWarehouseButton.UseVisualStyleBackColor = true;
			// 
			// warehousesDataGrid
			// 
			warehousesDataGrid.AllowUserToAddRows = false;
			warehousesDataGrid.AllowUserToDeleteRows = false;
			warehousesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			warehousesDataGrid.Dock = DockStyle.Left;
			warehousesDataGrid.Location = new Point(3, 3);
			warehousesDataGrid.MultiSelect = false;
			warehousesDataGrid.Name = "warehousesDataGrid";
			warehousesDataGrid.ReadOnly = true;
			warehousesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			warehousesDataGrid.Size = new Size(506, 418);
			warehousesDataGrid.TabIndex = 7;
			// 
			// productsTabPage
			// 
			productsTabPage.Controls.Add(removeProductButton);
			productsTabPage.Controls.Add(setProductButton);
			productsTabPage.Controls.Add(addProductButton);
			productsTabPage.Controls.Add(productsDataGrid);
			productsTabPage.Location = new Point(4, 24);
			productsTabPage.Name = "productsTabPage";
			productsTabPage.Padding = new Padding(3);
			productsTabPage.Size = new Size(710, 424);
			productsTabPage.TabIndex = 2;
			productsTabPage.Text = "Товары";
			productsTabPage.UseVisualStyleBackColor = true;
			// 
			// removeProductButton
			// 
			removeProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			removeProductButton.Location = new Point(548, 128);
			removeProductButton.Name = "removeProductButton";
			removeProductButton.Size = new Size(131, 40);
			removeProductButton.TabIndex = 16;
			removeProductButton.Text = "Удалить товар";
			removeProductButton.UseVisualStyleBackColor = true;
			// 
			// setProductButton
			// 
			setProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			setProductButton.Location = new Point(548, 82);
			setProductButton.Name = "setProductButton";
			setProductButton.Size = new Size(131, 40);
			setProductButton.TabIndex = 15;
			setProductButton.Text = "Изменить товар";
			setProductButton.UseVisualStyleBackColor = true;
			// 
			// addProductButton
			// 
			addProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addProductButton.Location = new Point(548, 36);
			addProductButton.Name = "addProductButton";
			addProductButton.Size = new Size(131, 40);
			addProductButton.TabIndex = 14;
			addProductButton.Text = "Добавить новый\r\nтовар";
			addProductButton.UseVisualStyleBackColor = true;
			// 
			// productsDataGrid
			// 
			productsDataGrid.AllowUserToAddRows = false;
			productsDataGrid.AllowUserToDeleteRows = false;
			productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			productsDataGrid.Dock = DockStyle.Left;
			productsDataGrid.Location = new Point(3, 3);
			productsDataGrid.MultiSelect = false;
			productsDataGrid.Name = "productsDataGrid";
			productsDataGrid.ReadOnly = true;
			productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			productsDataGrid.Size = new Size(506, 418);
			productsDataGrid.TabIndex = 13;
			// 
			// ordersTabPage
			// 
			ordersTabPage.Controls.Add(ordersDataGrid);
			ordersTabPage.Location = new Point(4, 24);
			ordersTabPage.Name = "ordersTabPage";
			ordersTabPage.Padding = new Padding(3);
			ordersTabPage.Size = new Size(710, 424);
			ordersTabPage.TabIndex = 3;
			ordersTabPage.Text = "Заказы";
			ordersTabPage.UseVisualStyleBackColor = true;
			// 
			// ordersDataGrid
			// 
			ordersDataGrid.AllowUserToAddRows = false;
			ordersDataGrid.AllowUserToDeleteRows = false;
			ordersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ordersDataGrid.Dock = DockStyle.Left;
			ordersDataGrid.Location = new Point(3, 3);
			ordersDataGrid.MultiSelect = false;
			ordersDataGrid.Name = "ordersDataGrid";
			ordersDataGrid.ReadOnly = true;
			ordersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			ordersDataGrid.Size = new Size(506, 418);
			ordersDataGrid.TabIndex = 14;
			// 
			// suppliersTabPage
			// 
			suppliersTabPage.Controls.Add(suppliersDataGrid);
			suppliersTabPage.Location = new Point(4, 24);
			suppliersTabPage.Name = "suppliersTabPage";
			suppliersTabPage.Padding = new Padding(3);
			suppliersTabPage.Size = new Size(710, 424);
			suppliersTabPage.TabIndex = 4;
			suppliersTabPage.Text = "Поставщики";
			suppliersTabPage.UseVisualStyleBackColor = true;
			// 
			// suppliersDataGrid
			// 
			suppliersDataGrid.AllowUserToAddRows = false;
			suppliersDataGrid.AllowUserToDeleteRows = false;
			suppliersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			suppliersDataGrid.Dock = DockStyle.Left;
			suppliersDataGrid.Location = new Point(3, 3);
			suppliersDataGrid.MultiSelect = false;
			suppliersDataGrid.Name = "suppliersDataGrid";
			suppliersDataGrid.ReadOnly = true;
			suppliersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			suppliersDataGrid.Size = new Size(506, 418);
			suppliersDataGrid.TabIndex = 14;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(944, 501);
			Controls.Add(tabs);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			tabs.ResumeLayout(false);
			clientsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).EndInit();
			warehousesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)warehousesDataGrid).EndInit();
			productsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
			ordersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ordersDataGrid).EndInit();
			suppliersTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)suppliersDataGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabs;
		private TabPage clientsTabPage;
		private TabPage warehousesTabPage;
		private TabPage productsTabPage;
		private TabPage ordersTabPage;
		private Button addClientButton;
		private Button setClientButton;
		private Button removeClientButton;
		private Button showClientOrdersButton;
		private Button addClientOrderButton;
		private Button addWarehouseOrderButton;
		private Button showWarehouseOrdersButton;
		private Button removeWarehouseButton;
		private Button setWarehouseButton;
		private Button addWarehouseButton;
		private DataGridView warehousesDataGrid;
		private Button removeProductButton;
		private Button setProductButton;
		private Button addProductButton;
		private DataGridView productsDataGrid;
		private TabPage suppliersTabPage;
		private DataGridView ordersDataGrid;
		private DataGridView suppliersDataGrid;
		private DataGridView clientsDataGrid;
		private Button addClientBalanceButton;
		private Button addWarehouseBalanceButton;
	}
}