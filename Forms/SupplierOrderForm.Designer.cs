namespace coursework.Forms
{
	partial class SupplierOrderForm
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
			supplierLabel = new Label();
			supplierComboBox = new ComboBox();
			orderDateLabel = new Label();
			orderDatePicker = new DateTimePicker();
			expectedDeliveryDateLabel = new Label();
			expectedDeliveryDatePicker = new DateTimePicker();
			itemsLabel = new Label();
			itemsDataGridView = new DataGridView();
			statusLabel = new Label();
			statusComboBox = new ComboBox();
			addItemButton = new Button();
			removeItemButton = new Button();
			confirmButton = new Button();
			cancelButton = new Button();
			editItemButton = new Button();
			errorProvider = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// supplierLabel
			// 
			supplierLabel.AutoSize = true;
			supplierLabel.Location = new Point(20, 20);
			supplierLabel.Name = "supplierLabel";
			supplierLabel.Size = new Size(73, 15);
			supplierLabel.TabIndex = 0;
			supplierLabel.Text = "Поставщик:";
			// 
			// supplierComboBox
			// 
			supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			supplierComboBox.Location = new Point(120, 17);
			supplierComboBox.Name = "supplierComboBox";
			supplierComboBox.Size = new Size(200, 23);
			supplierComboBox.TabIndex = 1;
			supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
			// 
			// orderDateLabel
			// 
			orderDateLabel.AutoSize = true;
			orderDateLabel.Location = new Point(20, 60);
			orderDateLabel.Name = "orderDateLabel";
			orderDateLabel.Size = new Size(72, 15);
			orderDateLabel.TabIndex = 2;
			orderDateLabel.Text = "Дата заказа:";
			// 
			// orderDatePicker
			// 
			orderDatePicker.Location = new Point(120, 57);
			orderDatePicker.Name = "orderDatePicker";
			orderDatePicker.Size = new Size(200, 23);
			orderDatePicker.TabIndex = 3;
			// 
			// expectedDeliveryDateLabel
			// 
			expectedDeliveryDateLabel.AutoSize = true;
			expectedDeliveryDateLabel.Location = new Point(20, 100);
			expectedDeliveryDateLabel.Name = "expectedDeliveryDateLabel";
			expectedDeliveryDateLabel.Size = new Size(87, 15);
			expectedDeliveryDateLabel.TabIndex = 4;
			expectedDeliveryDateLabel.Text = "Дата доставки:";
			// 
			// expectedDeliveryDatePicker
			// 
			expectedDeliveryDatePicker.Location = new Point(120, 97);
			expectedDeliveryDatePicker.Name = "expectedDeliveryDatePicker";
			expectedDeliveryDatePicker.Size = new Size(200, 23);
			expectedDeliveryDatePicker.TabIndex = 5;
			expectedDeliveryDatePicker.Validating += deliveryDatePicker_Validating;
			// 
			// itemsLabel
			// 
			itemsLabel.AutoSize = true;
			itemsLabel.Location = new Point(20, 140);
			itemsLabel.Name = "itemsLabel";
			itemsLabel.Size = new Size(51, 15);
			itemsLabel.TabIndex = 6;
			itemsLabel.Text = "Товары:";
			// 
			// itemsDataGridView
			// 
			itemsDataGridView.AllowUserToAddRows = false;
			itemsDataGridView.AllowUserToDeleteRows = false;
			itemsDataGridView.Location = new Point(20, 160);
			itemsDataGridView.Name = "itemsDataGridView";
			itemsDataGridView.ReadOnly = true;
			itemsDataGridView.Size = new Size(400, 150);
			itemsDataGridView.TabIndex = 7;
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.Location = new Point(20, 320);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new Size(46, 15);
			statusLabel.TabIndex = 8;
			statusLabel.Text = "Статус:";
			// 
			// statusComboBox
			// 
			statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			statusComboBox.Location = new Point(120, 317);
			statusComboBox.Name = "statusComboBox";
			statusComboBox.Size = new Size(200, 23);
			statusComboBox.TabIndex = 9;
			statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
			// 
			// addItemButton
			// 
			addItemButton.Location = new Point(430, 160);
			addItemButton.Name = "addItemButton";
			addItemButton.Size = new Size(100, 30);
			addItemButton.TabIndex = 11;
			addItemButton.Text = "Добавить";
			addItemButton.Click += addItemButton_Click;
			// 
			// removeItemButton
			// 
			removeItemButton.Location = new Point(430, 200);
			removeItemButton.Name = "removeItemButton";
			removeItemButton.Size = new Size(100, 30);
			removeItemButton.TabIndex = 12;
			removeItemButton.Text = "Удалить";
			removeItemButton.Click += removeItemButton_Click;
			// 
			// confirmButton
			// 
			confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			confirmButton.Location = new Point(414, 375);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(100, 30);
			confirmButton.TabIndex = 13;
			confirmButton.Text = "OK";
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cancelButton.Location = new Point(308, 375);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 30);
			cancelButton.TabIndex = 14;
			cancelButton.Text = "Отмена";
			cancelButton.Click += cancelButton_Click;
			// 
			// editItemButton
			// 
			editItemButton.Location = new Point(430, 240);
			editItemButton.Name = "editItemButton";
			editItemButton.Size = new Size(100, 30);
			editItemButton.TabIndex = 15;
			editItemButton.Text = "Изменить";
			editItemButton.Click += editItemButton_Click;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// SupplierOrderForm
			// 
			ClientSize = new Size(534, 421);
			Controls.Add(supplierLabel);
			Controls.Add(supplierComboBox);
			Controls.Add(orderDateLabel);
			Controls.Add(orderDatePicker);
			Controls.Add(expectedDeliveryDateLabel);
			Controls.Add(expectedDeliveryDatePicker);
			Controls.Add(itemsLabel);
			Controls.Add(itemsDataGridView);
			Controls.Add(statusLabel);
			Controls.Add(statusComboBox);
			Controls.Add(addItemButton);
			Controls.Add(removeItemButton);
			Controls.Add(confirmButton);
			Controls.Add(cancelButton);
			Controls.Add(editItemButton);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "SupplierOrderForm";
			Text = "Данные заказа";
			((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label supplierLabel;
		private ComboBox supplierComboBox;
		private Label orderDateLabel;
		private DateTimePicker orderDatePicker;
		private Label expectedDeliveryDateLabel;
		private DateTimePicker expectedDeliveryDatePicker;
		private Label itemsLabel;
		private DataGridView itemsDataGridView;
		private Label statusLabel;
		private ComboBox statusComboBox;
		private Button addItemButton;
		private Button removeItemButton;
		private Button confirmButton;
		private Button cancelButton;
		private Button editItemButton;
		private ErrorProvider errorProvider;
	}
}