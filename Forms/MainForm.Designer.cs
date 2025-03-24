namespace coursework.Forms
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
			components = new System.ComponentModel.Container();
			tabs = new TabControl();
			clientsTabPage = new TabPage();
			clientModifyPanel = new FlowLayoutPanel();
			addClientButton = new Button();
			editClientButton = new Button();
			removeClientButton = new Button();
			clientsDataGrid = new DataGridView();
			clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			totalDebtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			mainPresenterBindingSource = new BindingSource(components);
			productsTabPage = new TabPage();
			productModifyPanel = new FlowLayoutPanel();
			addProductButton = new Button();
			editProductButton = new Button();
			removeProductButton = new Button();
			productsDataGrid = new DataGridView();
			ProductID = new DataGridViewTextBoxColumn();
			ProductName = new DataGridViewTextBoxColumn();
			ProductPrice = new DataGridViewTextBoxColumn();
			ProductQuantity = new DataGridViewTextBoxColumn();
			ordersTabPage = new TabPage();
			orderModifyPanel = new FlowLayoutPanel();
			addOrderButton = new Button();
			editOrderButton = new Button();
			removeOrderButton = new Button();
			completeOrderButton = new Button();
			makeInvoiceButton = new Button();
			ordersDataGrid = new DataGridView();
			orderIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			clientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			deliveryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			totalCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			paidCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			suppliersTabPage = new TabPage();
			supplierModifyPanel = new FlowLayoutPanel();
			addSupplierButton = new Button();
			editSupplierButton = new Button();
			removeSupplierButton = new Button();
			suppliersDataGrid = new DataGridView();
			supplierIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			supplierOrdersTabPage = new TabPage();
			supplierOrdersModifyPanel = new FlowLayoutPanel();
			addSupplierOrderButton = new Button();
			editSupplierOrderButton = new Button();
			removeSupplierOrderButton = new Button();
			completeSupplierOrderButton = new Button();
			supplierOrdersDataGrid = new DataGridView();
			OrderID = new DataGridViewTextBoxColumn();
			supplierColumn = new DataGridViewTextBoxColumn();
			orderDateColumn = new DataGridViewTextBoxColumn();
			deliveryDateColumn = new DataGridViewTextBoxColumn();
			statusColumn = new DataGridViewTextBoxColumn();
			analyticsTabPage = new TabPage();
			period1Label = new Label();
			period1StartPicker = new DateTimePicker();
			period1EndPicker = new DateTimePicker();
			period2Label = new Label();
			period2StartPicker = new DateTimePicker();
			period2EndPicker = new DateTimePicker();
			compareButton = new Button();
			comparisonLabel = new Label();
			comparisonGrid = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			topProductsLabel = new Label();
			topProductsGrid = new DataGridView();
			dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			profitLabel = new Label();
			profitTextBox = new TextBox();
			period1StartLabel = new Label();
			period2StartLabel = new Label();
			tabs.SuspendLayout();
			clientsTabPage.SuspendLayout();
			clientModifyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)mainPresenterBindingSource).BeginInit();
			productsTabPage.SuspendLayout();
			productModifyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
			ordersTabPage.SuspendLayout();
			orderModifyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ordersDataGrid).BeginInit();
			suppliersTabPage.SuspendLayout();
			supplierModifyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)suppliersDataGrid).BeginInit();
			supplierOrdersTabPage.SuspendLayout();
			supplierOrdersModifyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)supplierOrdersDataGrid).BeginInit();
			analyticsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)comparisonGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)topProductsGrid).BeginInit();
			SuspendLayout();
			// 
			// tabs
			// 
			tabs.Controls.Add(clientsTabPage);
			tabs.Controls.Add(productsTabPage);
			tabs.Controls.Add(ordersTabPage);
			tabs.Controls.Add(suppliersTabPage);
			tabs.Controls.Add(supplierOrdersTabPage);
			tabs.Controls.Add(analyticsTabPage);
			tabs.Location = new Point(0, 0);
			tabs.Name = "tabs";
			tabs.SelectedIndex = 0;
			tabs.Size = new Size(717, 454);
			tabs.TabIndex = 0;
			// 
			// clientsTabPage
			// 
			clientsTabPage.Controls.Add(clientModifyPanel);
			clientsTabPage.Controls.Add(clientsDataGrid);
			clientsTabPage.Location = new Point(4, 24);
			clientsTabPage.Name = "clientsTabPage";
			clientsTabPage.Padding = new Padding(3);
			clientsTabPage.Size = new Size(709, 426);
			clientsTabPage.TabIndex = 0;
			clientsTabPage.Text = "Клиенты";
			clientsTabPage.UseVisualStyleBackColor = true;
			// 
			// clientModifyPanel
			// 
			clientModifyPanel.AutoSize = true;
			clientModifyPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			clientModifyPanel.Controls.Add(addClientButton);
			clientModifyPanel.Controls.Add(editClientButton);
			clientModifyPanel.Controls.Add(removeClientButton);
			clientModifyPanel.FlowDirection = FlowDirection.TopDown;
			clientModifyPanel.Location = new Point(539, 20);
			clientModifyPanel.Name = "clientModifyPanel";
			clientModifyPanel.Size = new Size(137, 138);
			clientModifyPanel.TabIndex = 1;
			// 
			// addClientButton
			// 
			addClientButton.Anchor = AnchorStyles.Left;
			addClientButton.Location = new Point(3, 3);
			addClientButton.Name = "addClientButton";
			addClientButton.Size = new Size(131, 40);
			addClientButton.TabIndex = 2;
			addClientButton.Text = "Добавить нового\r\nклиента";
			addClientButton.UseVisualStyleBackColor = true;
			addClientButton.Click += addClientButton_Click;
			// 
			// editClientButton
			// 
			editClientButton.Anchor = AnchorStyles.Left;
			editClientButton.Location = new Point(3, 49);
			editClientButton.Name = "editClientButton";
			editClientButton.Size = new Size(131, 40);
			editClientButton.TabIndex = 3;
			editClientButton.Text = "Изменить данные\r\nклиента";
			editClientButton.UseVisualStyleBackColor = true;
			editClientButton.Click += editClientButton_Click;
			// 
			// removeClientButton
			// 
			removeClientButton.Anchor = AnchorStyles.Left;
			removeClientButton.Location = new Point(3, 95);
			removeClientButton.Name = "removeClientButton";
			removeClientButton.Size = new Size(131, 40);
			removeClientButton.TabIndex = 4;
			removeClientButton.Text = "Удалить клиента";
			removeClientButton.UseVisualStyleBackColor = true;
			removeClientButton.Click += removeClientButton_Click;
			// 
			// clientsDataGrid
			// 
			clientsDataGrid.AllowUserToAddRows = false;
			clientsDataGrid.AllowUserToDeleteRows = false;
			clientsDataGrid.AutoGenerateColumns = false;
			clientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientsDataGrid.Columns.AddRange(new DataGridViewColumn[] { clientIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, totalDebtDataGridViewTextBoxColumn });
			clientsDataGrid.DataMember = "Clients";
			clientsDataGrid.DataSource = mainPresenterBindingSource;
			clientsDataGrid.Dock = DockStyle.Left;
			clientsDataGrid.Location = new Point(3, 3);
			clientsDataGrid.MultiSelect = false;
			clientsDataGrid.Name = "clientsDataGrid";
			clientsDataGrid.ReadOnly = true;
			clientsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			clientsDataGrid.Size = new Size(506, 420);
			clientsDataGrid.TabIndex = 8;
			// 
			// clientIDDataGridViewTextBoxColumn
			// 
			clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
			clientIDDataGridViewTextBoxColumn.HeaderText = "ID";
			clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
			clientIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
			phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			phoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
			addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalDebtDataGridViewTextBoxColumn
			// 
			totalDebtDataGridViewTextBoxColumn.DataPropertyName = "TotalDebt";
			totalDebtDataGridViewTextBoxColumn.HeaderText = "Задолженность";
			totalDebtDataGridViewTextBoxColumn.Name = "totalDebtDataGridViewTextBoxColumn";
			totalDebtDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// mainPresenterBindingSource
			// 
			mainPresenterBindingSource.DataSource = typeof(MainPresenter);
			// 
			// productsTabPage
			// 
			productsTabPage.Controls.Add(productModifyPanel);
			productsTabPage.Controls.Add(productsDataGrid);
			productsTabPage.Location = new Point(4, 24);
			productsTabPage.Name = "productsTabPage";
			productsTabPage.Padding = new Padding(3);
			productsTabPage.Size = new Size(709, 426);
			productsTabPage.TabIndex = 2;
			productsTabPage.Text = "Товары";
			productsTabPage.UseVisualStyleBackColor = true;
			// 
			// productModifyPanel
			// 
			productModifyPanel.AutoSize = true;
			productModifyPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			productModifyPanel.Controls.Add(addProductButton);
			productModifyPanel.Controls.Add(editProductButton);
			productModifyPanel.Controls.Add(removeProductButton);
			productModifyPanel.FlowDirection = FlowDirection.TopDown;
			productModifyPanel.Location = new Point(539, 20);
			productModifyPanel.Name = "productModifyPanel";
			productModifyPanel.Size = new Size(137, 138);
			productModifyPanel.TabIndex = 17;
			// 
			// addProductButton
			// 
			addProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addProductButton.Location = new Point(3, 3);
			addProductButton.Name = "addProductButton";
			addProductButton.Size = new Size(131, 40);
			addProductButton.TabIndex = 14;
			addProductButton.Text = "Добавить новый\r\nтовар";
			addProductButton.UseVisualStyleBackColor = true;
			addProductButton.Click += addProductButton_Click;
			// 
			// editProductButton
			// 
			editProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			editProductButton.Location = new Point(3, 49);
			editProductButton.Name = "editProductButton";
			editProductButton.Size = new Size(131, 40);
			editProductButton.TabIndex = 15;
			editProductButton.Text = "Изменить товар";
			editProductButton.UseVisualStyleBackColor = true;
			editProductButton.Click += editProductButton_Click;
			// 
			// removeProductButton
			// 
			removeProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			removeProductButton.Location = new Point(3, 95);
			removeProductButton.Name = "removeProductButton";
			removeProductButton.Size = new Size(131, 40);
			removeProductButton.TabIndex = 16;
			removeProductButton.Text = "Удалить товар";
			removeProductButton.UseVisualStyleBackColor = true;
			removeProductButton.Click += removeProductButton_Click;
			// 
			// productsDataGrid
			// 
			productsDataGrid.AllowUserToAddRows = false;
			productsDataGrid.AllowUserToDeleteRows = false;
			productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			productsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductPrice, ProductQuantity });
			productsDataGrid.Dock = DockStyle.Left;
			productsDataGrid.Location = new Point(3, 3);
			productsDataGrid.MultiSelect = false;
			productsDataGrid.Name = "productsDataGrid";
			productsDataGrid.ReadOnly = true;
			productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			productsDataGrid.Size = new Size(506, 420);
			productsDataGrid.TabIndex = 13;
			// 
			// ProductID
			// 
			ProductID.HeaderText = "ID";
			ProductID.Name = "ProductID";
			ProductID.ReadOnly = true;
			// 
			// ProductName
			// 
			ProductName.HeaderText = "Товар";
			ProductName.Name = "ProductName";
			ProductName.ReadOnly = true;
			// 
			// ProductPrice
			// 
			ProductPrice.HeaderText = "Цена";
			ProductPrice.Name = "ProductPrice";
			ProductPrice.ReadOnly = true;
			// 
			// ProductQuantity
			// 
			ProductQuantity.HeaderText = "Количество на складе";
			ProductQuantity.Name = "ProductQuantity";
			ProductQuantity.ReadOnly = true;
			// 
			// ordersTabPage
			// 
			ordersTabPage.Controls.Add(orderModifyPanel);
			ordersTabPage.Controls.Add(ordersDataGrid);
			ordersTabPage.Location = new Point(4, 24);
			ordersTabPage.Name = "ordersTabPage";
			ordersTabPage.Padding = new Padding(3);
			ordersTabPage.Size = new Size(709, 426);
			ordersTabPage.TabIndex = 3;
			ordersTabPage.Text = "Заказы";
			ordersTabPage.UseVisualStyleBackColor = true;
			// 
			// orderModifyPanel
			// 
			orderModifyPanel.AutoSize = true;
			orderModifyPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			orderModifyPanel.Controls.Add(addOrderButton);
			orderModifyPanel.Controls.Add(editOrderButton);
			orderModifyPanel.Controls.Add(removeOrderButton);
			orderModifyPanel.Controls.Add(completeOrderButton);
			orderModifyPanel.Controls.Add(makeInvoiceButton);
			orderModifyPanel.FlowDirection = FlowDirection.TopDown;
			orderModifyPanel.Location = new Point(539, 20);
			orderModifyPanel.Name = "orderModifyPanel";
			orderModifyPanel.Size = new Size(137, 230);
			orderModifyPanel.TabIndex = 15;
			// 
			// addOrderButton
			// 
			addOrderButton.Anchor = AnchorStyles.Left;
			addOrderButton.Location = new Point(3, 3);
			addOrderButton.Name = "addOrderButton";
			addOrderButton.Size = new Size(131, 40);
			addOrderButton.TabIndex = 2;
			addOrderButton.Text = "Добавить новый\r\nзаказ";
			addOrderButton.UseVisualStyleBackColor = true;
			addOrderButton.Click += addOrderButton_Click;
			// 
			// editOrderButton
			// 
			editOrderButton.Anchor = AnchorStyles.Left;
			editOrderButton.Location = new Point(3, 49);
			editOrderButton.Name = "editOrderButton";
			editOrderButton.Size = new Size(131, 40);
			editOrderButton.TabIndex = 3;
			editOrderButton.Text = "Изменить данные\r\nзаказа";
			editOrderButton.UseVisualStyleBackColor = true;
			editOrderButton.Click += editOrderButton_Click;
			// 
			// removeOrderButton
			// 
			removeOrderButton.Anchor = AnchorStyles.Left;
			removeOrderButton.Location = new Point(3, 95);
			removeOrderButton.Name = "removeOrderButton";
			removeOrderButton.Size = new Size(131, 40);
			removeOrderButton.TabIndex = 4;
			removeOrderButton.Text = "Удалить заказ";
			removeOrderButton.UseVisualStyleBackColor = true;
			removeOrderButton.Click += removeOrderButton_Click;
			// 
			// completeOrderButton
			// 
			completeOrderButton.Anchor = AnchorStyles.Left;
			completeOrderButton.Location = new Point(3, 141);
			completeOrderButton.Name = "completeOrderButton";
			completeOrderButton.Size = new Size(131, 40);
			completeOrderButton.TabIndex = 5;
			completeOrderButton.Text = "Завершить заказ";
			completeOrderButton.UseVisualStyleBackColor = true;
			completeOrderButton.Click += completeOrderButton_Click;
			// 
			// makeInvoiceButton
			// 
			makeInvoiceButton.Anchor = AnchorStyles.Left;
			makeInvoiceButton.Location = new Point(3, 187);
			makeInvoiceButton.Name = "makeInvoiceButton";
			makeInvoiceButton.Size = new Size(131, 40);
			makeInvoiceButton.TabIndex = 6;
			makeInvoiceButton.Text = "Составить счет";
			makeInvoiceButton.UseVisualStyleBackColor = true;
			makeInvoiceButton.Click += makeInvoiceButton_Click;
			// 
			// ordersDataGrid
			// 
			ordersDataGrid.AllowUserToAddRows = false;
			ordersDataGrid.AllowUserToDeleteRows = false;
			ordersDataGrid.AutoGenerateColumns = false;
			ordersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ordersDataGrid.Columns.AddRange(new DataGridViewColumn[] { orderIDDataGridViewTextBoxColumn, clientDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, deliveryDateDataGridViewTextBoxColumn, totalCostDataGridViewTextBoxColumn, paidCostDataGridViewTextBoxColumn });
			ordersDataGrid.DataMember = "Orders";
			ordersDataGrid.DataSource = mainPresenterBindingSource;
			ordersDataGrid.Dock = DockStyle.Left;
			ordersDataGrid.Location = new Point(3, 3);
			ordersDataGrid.MultiSelect = false;
			ordersDataGrid.Name = "ordersDataGrid";
			ordersDataGrid.ReadOnly = true;
			ordersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			ordersDataGrid.Size = new Size(506, 420);
			ordersDataGrid.TabIndex = 14;
			// 
			// orderIDDataGridViewTextBoxColumn
			// 
			orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
			orderIDDataGridViewTextBoxColumn.HeaderText = "ID";
			orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
			orderIDDataGridViewTextBoxColumn.ReadOnly = true;
			orderIDDataGridViewTextBoxColumn.Width = 77;
			// 
			// clientDataGridViewTextBoxColumn
			// 
			clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
			clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
			clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
			clientDataGridViewTextBoxColumn.ReadOnly = true;
			clientDataGridViewTextBoxColumn.Width = 77;
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
			orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			orderDateDataGridViewTextBoxColumn.ReadOnly = true;
			orderDateDataGridViewTextBoxColumn.Width = 77;
			// 
			// deliveryDateDataGridViewTextBoxColumn
			// 
			deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
			deliveryDateDataGridViewTextBoxColumn.HeaderText = "Дата доставки";
			deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
			deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
			deliveryDateDataGridViewTextBoxColumn.Width = 78;
			// 
			// totalCostDataGridViewTextBoxColumn
			// 
			totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
			totalCostDataGridViewTextBoxColumn.HeaderText = "Суммарная стоимость";
			totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
			totalCostDataGridViewTextBoxColumn.ReadOnly = true;
			totalCostDataGridViewTextBoxColumn.Width = 77;
			// 
			// paidCostDataGridViewTextBoxColumn
			// 
			paidCostDataGridViewTextBoxColumn.DataPropertyName = "PaidCost";
			paidCostDataGridViewTextBoxColumn.HeaderText = "Оплаченная стоимость";
			paidCostDataGridViewTextBoxColumn.Name = "paidCostDataGridViewTextBoxColumn";
			paidCostDataGridViewTextBoxColumn.ReadOnly = true;
			paidCostDataGridViewTextBoxColumn.Width = 77;
			// 
			// suppliersTabPage
			// 
			suppliersTabPage.Controls.Add(supplierModifyPanel);
			suppliersTabPage.Controls.Add(suppliersDataGrid);
			suppliersTabPage.Location = new Point(4, 24);
			suppliersTabPage.Name = "suppliersTabPage";
			suppliersTabPage.Padding = new Padding(3);
			suppliersTabPage.Size = new Size(709, 426);
			suppliersTabPage.TabIndex = 4;
			suppliersTabPage.Text = "Поставщики";
			suppliersTabPage.UseVisualStyleBackColor = true;
			// 
			// supplierModifyPanel
			// 
			supplierModifyPanel.AutoSize = true;
			supplierModifyPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			supplierModifyPanel.Controls.Add(addSupplierButton);
			supplierModifyPanel.Controls.Add(editSupplierButton);
			supplierModifyPanel.Controls.Add(removeSupplierButton);
			supplierModifyPanel.FlowDirection = FlowDirection.TopDown;
			supplierModifyPanel.Location = new Point(539, 20);
			supplierModifyPanel.Name = "supplierModifyPanel";
			supplierModifyPanel.Size = new Size(137, 138);
			supplierModifyPanel.TabIndex = 18;
			// 
			// addSupplierButton
			// 
			addSupplierButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addSupplierButton.Location = new Point(3, 3);
			addSupplierButton.Name = "addSupplierButton";
			addSupplierButton.Size = new Size(131, 40);
			addSupplierButton.TabIndex = 14;
			addSupplierButton.Text = "Добавить нового\r\nпоставщика";
			addSupplierButton.UseVisualStyleBackColor = true;
			addSupplierButton.Click += addSupplierButton_Click;
			// 
			// editSupplierButton
			// 
			editSupplierButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			editSupplierButton.Location = new Point(3, 49);
			editSupplierButton.Name = "editSupplierButton";
			editSupplierButton.Size = new Size(131, 40);
			editSupplierButton.TabIndex = 15;
			editSupplierButton.Text = "Изменить\r\nпоставщика";
			editSupplierButton.UseVisualStyleBackColor = true;
			editSupplierButton.Click += editSupplierButton_Click;
			// 
			// removeSupplierButton
			// 
			removeSupplierButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			removeSupplierButton.Location = new Point(3, 95);
			removeSupplierButton.Name = "removeSupplierButton";
			removeSupplierButton.Size = new Size(131, 40);
			removeSupplierButton.TabIndex = 16;
			removeSupplierButton.Text = "Удалить поставщика";
			removeSupplierButton.UseVisualStyleBackColor = true;
			removeSupplierButton.Click += removeSupplierButton_Click;
			// 
			// suppliersDataGrid
			// 
			suppliersDataGrid.AllowUserToAddRows = false;
			suppliersDataGrid.AllowUserToDeleteRows = false;
			suppliersDataGrid.AutoGenerateColumns = false;
			suppliersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			suppliersDataGrid.Columns.AddRange(new DataGridViewColumn[] { supplierIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1 });
			suppliersDataGrid.DataMember = "Suppliers";
			suppliersDataGrid.DataSource = mainPresenterBindingSource;
			suppliersDataGrid.Dock = DockStyle.Left;
			suppliersDataGrid.Location = new Point(3, 3);
			suppliersDataGrid.MultiSelect = false;
			suppliersDataGrid.Name = "suppliersDataGrid";
			suppliersDataGrid.ReadOnly = true;
			suppliersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			suppliersDataGrid.Size = new Size(506, 420);
			suppliersDataGrid.TabIndex = 14;
			// 
			// supplierIDDataGridViewTextBoxColumn
			// 
			supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
			supplierIDDataGridViewTextBoxColumn.HeaderText = "ID";
			supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
			supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn1.HeaderText = "Название";
			nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// supplierOrdersTabPage
			// 
			supplierOrdersTabPage.Controls.Add(supplierOrdersModifyPanel);
			supplierOrdersTabPage.Controls.Add(supplierOrdersDataGrid);
			supplierOrdersTabPage.Location = new Point(4, 24);
			supplierOrdersTabPage.Name = "supplierOrdersTabPage";
			supplierOrdersTabPage.Padding = new Padding(3);
			supplierOrdersTabPage.Size = new Size(709, 426);
			supplierOrdersTabPage.TabIndex = 5;
			supplierOrdersTabPage.Text = "Заказы поставщикам";
			supplierOrdersTabPage.UseVisualStyleBackColor = true;
			// 
			// supplierOrdersModifyPanel
			// 
			supplierOrdersModifyPanel.AutoSize = true;
			supplierOrdersModifyPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			supplierOrdersModifyPanel.Controls.Add(addSupplierOrderButton);
			supplierOrdersModifyPanel.Controls.Add(editSupplierOrderButton);
			supplierOrdersModifyPanel.Controls.Add(removeSupplierOrderButton);
			supplierOrdersModifyPanel.Controls.Add(completeSupplierOrderButton);
			supplierOrdersModifyPanel.FlowDirection = FlowDirection.TopDown;
			supplierOrdersModifyPanel.Location = new Point(539, 20);
			supplierOrdersModifyPanel.Name = "supplierOrdersModifyPanel";
			supplierOrdersModifyPanel.Size = new Size(137, 184);
			supplierOrdersModifyPanel.TabIndex = 18;
			// 
			// addSupplierOrderButton
			// 
			addSupplierOrderButton.Anchor = AnchorStyles.Left;
			addSupplierOrderButton.Location = new Point(3, 3);
			addSupplierOrderButton.Name = "addSupplierOrderButton";
			addSupplierOrderButton.Size = new Size(131, 40);
			addSupplierOrderButton.TabIndex = 2;
			addSupplierOrderButton.Text = "Добавить новый\r\nзаказ";
			addSupplierOrderButton.UseVisualStyleBackColor = true;
			addSupplierOrderButton.Click += addSupplierOrderButton_Click;
			// 
			// editSupplierOrderButton
			// 
			editSupplierOrderButton.Anchor = AnchorStyles.Left;
			editSupplierOrderButton.Location = new Point(3, 49);
			editSupplierOrderButton.Name = "editSupplierOrderButton";
			editSupplierOrderButton.Size = new Size(131, 40);
			editSupplierOrderButton.TabIndex = 3;
			editSupplierOrderButton.Text = "Изменить данные\r\nзаказа";
			editSupplierOrderButton.UseVisualStyleBackColor = true;
			editSupplierOrderButton.Click += editSupplierOrderButton_Click;
			// 
			// removeSupplierOrderButton
			// 
			removeSupplierOrderButton.Anchor = AnchorStyles.Left;
			removeSupplierOrderButton.Location = new Point(3, 95);
			removeSupplierOrderButton.Name = "removeSupplierOrderButton";
			removeSupplierOrderButton.Size = new Size(131, 40);
			removeSupplierOrderButton.TabIndex = 4;
			removeSupplierOrderButton.Text = "Удалить заказ";
			removeSupplierOrderButton.UseVisualStyleBackColor = true;
			removeSupplierOrderButton.Click += removeSupplierOrderButton_Click;
			// 
			// completeSupplierOrderButton
			// 
			completeSupplierOrderButton.Anchor = AnchorStyles.Left;
			completeSupplierOrderButton.Location = new Point(3, 141);
			completeSupplierOrderButton.Name = "completeSupplierOrderButton";
			completeSupplierOrderButton.Size = new Size(131, 40);
			completeSupplierOrderButton.TabIndex = 6;
			completeSupplierOrderButton.Text = "Завершить заказ";
			completeSupplierOrderButton.UseVisualStyleBackColor = true;
			completeSupplierOrderButton.Click += completeSupplierOrderButton_Click;
			// 
			// supplierOrdersDataGrid
			// 
			supplierOrdersDataGrid.AllowUserToAddRows = false;
			supplierOrdersDataGrid.AllowUserToDeleteRows = false;
			supplierOrdersDataGrid.AutoGenerateColumns = false;
			supplierOrdersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			supplierOrdersDataGrid.Columns.AddRange(new DataGridViewColumn[] { OrderID, supplierColumn, orderDateColumn, deliveryDateColumn, statusColumn });
			supplierOrdersDataGrid.DataMember = "SupplierOrders";
			supplierOrdersDataGrid.DataSource = mainPresenterBindingSource;
			supplierOrdersDataGrid.Dock = DockStyle.Left;
			supplierOrdersDataGrid.Location = new Point(3, 3);
			supplierOrdersDataGrid.MultiSelect = false;
			supplierOrdersDataGrid.Name = "supplierOrdersDataGrid";
			supplierOrdersDataGrid.ReadOnly = true;
			supplierOrdersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			supplierOrdersDataGrid.Size = new Size(506, 420);
			supplierOrdersDataGrid.TabIndex = 14;
			// 
			// OrderID
			// 
			OrderID.DataPropertyName = "OrderID";
			OrderID.HeaderText = "ID";
			OrderID.Name = "OrderID";
			OrderID.ReadOnly = true;
			// 
			// supplierColumn
			// 
			supplierColumn.DataPropertyName = "Supplier";
			supplierColumn.HeaderText = "Поставщик";
			supplierColumn.Name = "supplierColumn";
			supplierColumn.ReadOnly = true;
			// 
			// orderDateColumn
			// 
			orderDateColumn.DataPropertyName = "OrderDate";
			orderDateColumn.HeaderText = "Дата заказа";
			orderDateColumn.Name = "orderDateColumn";
			orderDateColumn.ReadOnly = true;
			// 
			// deliveryDateColumn
			// 
			deliveryDateColumn.DataPropertyName = "ExpectedDeliveryDate";
			deliveryDateColumn.HeaderText = "План. дата доставки";
			deliveryDateColumn.Name = "deliveryDateColumn";
			deliveryDateColumn.ReadOnly = true;
			// 
			// statusColumn
			// 
			statusColumn.DataPropertyName = "Status";
			statusColumn.HeaderText = "Статус";
			statusColumn.Name = "statusColumn";
			statusColumn.ReadOnly = true;
			// 
			// analyticsTabPage
			// 
			analyticsTabPage.Controls.Add(period1Label);
			analyticsTabPage.Controls.Add(period1StartPicker);
			analyticsTabPage.Controls.Add(period1EndPicker);
			analyticsTabPage.Controls.Add(period2Label);
			analyticsTabPage.Controls.Add(period2StartPicker);
			analyticsTabPage.Controls.Add(period2EndPicker);
			analyticsTabPage.Controls.Add(compareButton);
			analyticsTabPage.Controls.Add(comparisonLabel);
			analyticsTabPage.Controls.Add(comparisonGrid);
			analyticsTabPage.Controls.Add(topProductsLabel);
			analyticsTabPage.Controls.Add(topProductsGrid);
			analyticsTabPage.Controls.Add(profitLabel);
			analyticsTabPage.Controls.Add(profitTextBox);
			analyticsTabPage.Location = new Point(4, 24);
			analyticsTabPage.Name = "analyticsTabPage";
			analyticsTabPage.Padding = new Padding(3);
			analyticsTabPage.Size = new Size(709, 426);
			analyticsTabPage.TabIndex = 6;
			analyticsTabPage.Text = "Аналитика";
			analyticsTabPage.UseVisualStyleBackColor = true;
			// 
			// period1Label
			// 
			period1Label.AutoSize = true;
			period1Label.Location = new Point(10, 10);
			period1Label.Name = "period1Label";
			period1Label.Size = new Size(61, 15);
			period1Label.TabIndex = 0;
			period1Label.Text = "Период 1:";
			// 
			// period1StartPicker
			// 
			period1StartPicker.Location = new Point(80, 7);
			period1StartPicker.Name = "period1StartPicker";
			period1StartPicker.Size = new Size(120, 23);
			period1StartPicker.TabIndex = 1;
			// 
			// period1EndPicker
			// 
			period1EndPicker.Location = new Point(210, 7);
			period1EndPicker.Name = "period1EndPicker";
			period1EndPicker.Size = new Size(120, 23);
			period1EndPicker.TabIndex = 2;
			// 
			// period2Label
			// 
			period2Label.AutoSize = true;
			period2Label.Location = new Point(10, 40);
			period2Label.Name = "period2Label";
			period2Label.Size = new Size(61, 15);
			period2Label.TabIndex = 3;
			period2Label.Text = "Период 2:";
			// 
			// period2StartPicker
			// 
			period2StartPicker.Location = new Point(80, 37);
			period2StartPicker.Name = "period2StartPicker";
			period2StartPicker.Size = new Size(120, 23);
			period2StartPicker.TabIndex = 4;
			// 
			// period2EndPicker
			// 
			period2EndPicker.Location = new Point(210, 37);
			period2EndPicker.Name = "period2EndPicker";
			period2EndPicker.Size = new Size(120, 23);
			period2EndPicker.TabIndex = 5;
			// 
			// compareButton
			// 
			compareButton.Location = new Point(350, 22);
			compareButton.Name = "compareButton";
			compareButton.Size = new Size(120, 23);
			compareButton.TabIndex = 6;
			compareButton.Text = "Сравнить периоды";
			compareButton.UseVisualStyleBackColor = true;
			compareButton.Click += compareButton_Click;
			// 
			// comparisonLabel
			// 
			comparisonLabel.AutoSize = true;
			comparisonLabel.Location = new Point(10, 70);
			comparisonLabel.Name = "comparisonLabel";
			comparisonLabel.Size = new Size(122, 15);
			comparisonLabel.TabIndex = 7;
			comparisonLabel.Text = "Сравнение объемов:";
			// 
			// comparisonGrid
			// 
			comparisonGrid.AllowUserToAddRows = false;
			comparisonGrid.AllowUserToDeleteRows = false;
			comparisonGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			comparisonGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
			comparisonGrid.Location = new Point(10, 90);
			comparisonGrid.Name = "comparisonGrid";
			comparisonGrid.ReadOnly = true;
			comparisonGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			comparisonGrid.Size = new Size(450, 150);
			comparisonGrid.TabIndex = 8;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "Товар";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "Закупки/Продажи П1";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.HeaderText = "Закупки/Продажи П2";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewTextBoxColumn4.HeaderText = "Разница";
			dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// topProductsLabel
			// 
			topProductsLabel.AutoSize = true;
			topProductsLabel.Location = new Point(10, 250);
			topProductsLabel.Name = "topProductsLabel";
			topProductsLabel.Size = new Size(77, 15);
			topProductsLabel.TabIndex = 9;
			topProductsLabel.Text = "Топ товаров:";
			// 
			// topProductsGrid
			// 
			topProductsGrid.AllowUserToAddRows = false;
			topProductsGrid.AllowUserToDeleteRows = false;
			topProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			topProductsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
			topProductsGrid.Location = new Point(10, 270);
			topProductsGrid.Name = "topProductsGrid";
			topProductsGrid.ReadOnly = true;
			topProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			topProductsGrid.Size = new Size(450, 100);
			topProductsGrid.TabIndex = 10;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewTextBoxColumn5.HeaderText = "Место";
			dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewTextBoxColumn6.HeaderText = "Товар";
			dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			dataGridViewTextBoxColumn7.HeaderText = "Количество";
			dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// profitLabel
			// 
			profitLabel.AutoSize = true;
			profitLabel.Location = new Point(10, 380);
			profitLabel.Name = "profitLabel";
			profitLabel.Size = new Size(62, 15);
			profitLabel.TabIndex = 11;
			profitLabel.Text = "Прибыль:";
			// 
			// profitTextBox
			// 
			profitTextBox.Location = new Point(80, 377);
			profitTextBox.Name = "profitTextBox";
			profitTextBox.ReadOnly = true;
			profitTextBox.Size = new Size(150, 23);
			profitTextBox.TabIndex = 12;
			// 
			// period1StartLabel
			// 
			period1StartLabel.Location = new Point(0, 0);
			period1StartLabel.Name = "period1StartLabel";
			period1StartLabel.Size = new Size(100, 23);
			period1StartLabel.TabIndex = 0;
			// 
			// period2StartLabel
			// 
			period2StartLabel.Location = new Point(0, 0);
			period2StartLabel.Name = "period2StartLabel";
			period2StartLabel.Size = new Size(100, 23);
			period2StartLabel.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(944, 501);
			Controls.Add(tabs);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Обработка заказов";
			FormClosing += MainForm_Closing;
			Load += MainForm_Load;
			tabs.ResumeLayout(false);
			clientsTabPage.ResumeLayout(false);
			clientsTabPage.PerformLayout();
			clientModifyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)clientsDataGrid).EndInit();
			((System.ComponentModel.ISupportInitialize)mainPresenterBindingSource).EndInit();
			productsTabPage.ResumeLayout(false);
			productsTabPage.PerformLayout();
			productModifyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
			ordersTabPage.ResumeLayout(false);
			ordersTabPage.PerformLayout();
			orderModifyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ordersDataGrid).EndInit();
			suppliersTabPage.ResumeLayout(false);
			suppliersTabPage.PerformLayout();
			supplierModifyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)suppliersDataGrid).EndInit();
			supplierOrdersTabPage.ResumeLayout(false);
			supplierOrdersTabPage.PerformLayout();
			supplierOrdersModifyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)supplierOrdersDataGrid).EndInit();
			analyticsTabPage.ResumeLayout(false);
			analyticsTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)comparisonGrid).EndInit();
			((System.ComponentModel.ISupportInitialize)topProductsGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabs;
		private TabPage clientsTabPage;
		private TabPage productsTabPage;
		private TabPage ordersTabPage;
		private Button addClientButton;
		private Button editClientButton;
		private Button removeClientButton;
		private Button removeProductButton;
		private Button editProductButton;
		private Button addProductButton;
		private DataGridView productsDataGrid;
		private TabPage suppliersTabPage;
		private DataGridView ordersDataGrid;
		private DataGridView suppliersDataGrid;
		private DataGridView clientsDataGrid;
		private FlowLayoutPanel clientModifyPanel;
		private FlowLayoutPanel productModifyPanel;
		private FlowLayoutPanel supplierModifyPanel;
		private Button addSupplierButton;
		private Button editSupplierButton;
		private Button removeSupplierButton;
		private FlowLayoutPanel orderModifyPanel;
		private Button addOrderButton;
		private Button editOrderButton;
		private Button removeOrderButton;
		private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn totalDebtDataGridViewTextBoxColumn;
		private BindingSource mainPresenterBindingSource;
		private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paidCostDataGridViewTextBoxColumn;
		private TabPage supplierOrdersTabPage;
		private FlowLayoutPanel supplierOrdersModifyPanel;
		private Button addSupplierOrderButton;
		private Button editSupplierOrderButton;
		private Button removeSupplierOrderButton;
		private DataGridView supplierOrdersDataGrid;
		private DataGridViewTextBoxColumn supplierOrderIDColumn;
		private TabPage analyticsTabPage;
		private DateTimePicker period1StartPicker;
		private DateTimePicker period1EndPicker;
		private DateTimePicker period2StartPicker;
		private DateTimePicker period2EndPicker;
		private Label period1Label;
		private Label period2Label;
		private Label period1StartLabel;
		private Label period1EndLabel;
		private Label period2StartLabel;
		private Label period2EndLabel;
		private Button compareButton;
		private DataGridView comparisonGrid;
		private DataGridView topProductsGrid;
		private Label comparisonLabel;
		private Label topProductsLabel;
		private Label profitLabel;
		private TextBox profitTextBox;
		private DataGridViewTextBoxColumn OrderID;
		private DataGridViewTextBoxColumn supplierColumn;
		private DataGridViewTextBoxColumn orderDateColumn;
		private DataGridViewTextBoxColumn deliveryDateColumn;
		private DataGridViewTextBoxColumn statusColumn;
		private DataGridViewTextBoxColumn ProductID;
		private DataGridViewTextBoxColumn ProductName;
		private DataGridViewTextBoxColumn ProductPrice;
		private DataGridViewTextBoxColumn ProductQuantity;
		private Button completeOrderButton;
		private Button completeSupplierOrderButton;
		private Button makeInvoiceButton;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	}
}