namespace coursework.Forms
{
	partial class OrderForm
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
			clientLabel = new Label();
			clientComboBox = new ComboBox();
			orderDateLabel = new Label();
			orderDatePicker = new DateTimePicker();
			deliveryDateLabel = new Label();
			deliveryDatePicker = new DateTimePicker();
			itemsLabel = new Label();
			itemsDataGridView = new DataGridView();
			statusLabel = new Label();
			statusComboBox = new ComboBox();
			paidLabel = new Label();
			paidNumericUpDown = new NumericUpDown();
			requiresDeliveryCheckBox = new CheckBox();
			isDeliveryPaidCheckBox = new CheckBox();
			addItemButton = new Button();
			removeItemButton = new Button();
			confirmButton = new Button();
			cancelButton = new Button();
			editItemButton = new Button();
			errorProvider = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)paidNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// clientLabel
			// 
			clientLabel.AutoSize = true;
			clientLabel.Location = new Point(20, 20);
			clientLabel.Name = "clientLabel";
			clientLabel.Size = new Size(49, 15);
			clientLabel.TabIndex = 0;
			clientLabel.Text = "Клиент:";
			// 
			// clientComboBox
			// 
			clientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			clientComboBox.Location = new Point(120, 17);
			clientComboBox.Name = "clientComboBox";
			clientComboBox.Size = new Size(200, 23);
			clientComboBox.TabIndex = 1;
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
			// deliveryDateLabel
			// 
			deliveryDateLabel.AutoSize = true;
			deliveryDateLabel.Location = new Point(20, 100);
			deliveryDateLabel.Name = "deliveryDateLabel";
			deliveryDateLabel.Size = new Size(87, 15);
			deliveryDateLabel.TabIndex = 4;
			deliveryDateLabel.Text = "Дата доставки:";
			// 
			// deliveryDatePicker
			// 
			deliveryDatePicker.Location = new Point(120, 97);
			deliveryDatePicker.Name = "deliveryDatePicker";
			deliveryDatePicker.Size = new Size(200, 23);
			deliveryDatePicker.TabIndex = 5;
			deliveryDatePicker.Validating += deliveryDatePicker_Validating;
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
			itemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
			// paidLabel
			// 
			paidLabel.AutoSize = true;
			paidLabel.Location = new Point(20, 360);
			paidLabel.Name = "paidLabel";
			paidLabel.Size = new Size(66, 15);
			paidLabel.TabIndex = 10;
			paidLabel.Text = "Оплачено:";
			// 
			// paidNumericUpDown
			// 
			paidNumericUpDown.DecimalPlaces = 2;
			paidNumericUpDown.Location = new Point(120, 357);
			paidNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			paidNumericUpDown.Name = "paidNumericUpDown";
			paidNumericUpDown.Size = new Size(200, 23);
			paidNumericUpDown.TabIndex = 11;
			paidNumericUpDown.Validating += paidNumericUpDown_Validating;
			// 
			// requiresDeliveryCheckBox
			// 
			requiresDeliveryCheckBox.Location = new Point(20, 390);
			requiresDeliveryCheckBox.Name = "requiresDeliveryCheckBox";
			requiresDeliveryCheckBox.Size = new Size(150, 20);
			requiresDeliveryCheckBox.TabIndex = 12;
			requiresDeliveryCheckBox.Text = "Требуется доставка";
			requiresDeliveryCheckBox.UseVisualStyleBackColor = true;
			requiresDeliveryCheckBox.CheckedChanged += requiresDeliveryCheckBox_CheckedChanged;
			// 
			// isDeliveryPaidCheckBox
			// 
			isDeliveryPaidCheckBox.Enabled = false;
			isDeliveryPaidCheckBox.Location = new Point(20, 415);
			isDeliveryPaidCheckBox.Name = "isDeliveryPaidCheckBox";
			isDeliveryPaidCheckBox.Size = new Size(150, 20);
			isDeliveryPaidCheckBox.TabIndex = 13;
			isDeliveryPaidCheckBox.Text = "Доставка оплачена";
			isDeliveryPaidCheckBox.UseVisualStyleBackColor = true;
			// 
			// addItemButton
			// 
			addItemButton.Location = new Point(430, 160);
			addItemButton.Name = "addItemButton";
			addItemButton.Size = new Size(100, 30);
			addItemButton.TabIndex = 8;
			addItemButton.Text = "Добавить";
			addItemButton.UseVisualStyleBackColor = true;
			addItemButton.Click += addItemButton_Click;
			// 
			// removeItemButton
			// 
			removeItemButton.Location = new Point(430, 200);
			removeItemButton.Name = "removeItemButton";
			removeItemButton.Size = new Size(100, 30);
			removeItemButton.TabIndex = 9;
			removeItemButton.Text = "Удалить";
			removeItemButton.UseVisualStyleBackColor = true;
			removeItemButton.Click += removeItemButton_Click;
			// 
			// confirmButton
			// 
			confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			confirmButton.Location = new Point(414, 415);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(100, 30);
			confirmButton.TabIndex = 10;
			confirmButton.Text = "OK";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cancelButton.Location = new Point(308, 415);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 30);
			cancelButton.TabIndex = 11;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// editItemButton
			// 
			editItemButton.Location = new Point(430, 240);
			editItemButton.Name = "editItemButton";
			editItemButton.Size = new Size(100, 30);
			editItemButton.TabIndex = 14;
			editItemButton.Text = "Изменить";
			editItemButton.Click += editItemButton_Click;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// OrderForm
			// 
			ClientSize = new Size(534, 461);
			Controls.Add(clientLabel);
			Controls.Add(clientComboBox);
			Controls.Add(orderDateLabel);
			Controls.Add(orderDatePicker);
			Controls.Add(deliveryDateLabel);
			Controls.Add(deliveryDatePicker);
			Controls.Add(itemsLabel);
			Controls.Add(itemsDataGridView);
			Controls.Add(statusLabel);
			Controls.Add(statusComboBox);
			Controls.Add(paidLabel);
			Controls.Add(paidNumericUpDown);
			Controls.Add(requiresDeliveryCheckBox);
			Controls.Add(isDeliveryPaidCheckBox);
			Controls.Add(addItemButton);
			Controls.Add(removeItemButton);
			Controls.Add(confirmButton);
			Controls.Add(cancelButton);
			Controls.Add(editItemButton);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "OrderForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Данные заказа";
			((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)paidNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label clientLabel;
		private ComboBox clientComboBox;
		private Label orderDateLabel;
		private DateTimePicker orderDatePicker;
		private Label deliveryDateLabel;
		private DateTimePicker deliveryDatePicker;
		private Label itemsLabel;
		private DataGridView itemsDataGridView;
		private Label statusLabel;
		private ComboBox statusComboBox;
		private Label paidLabel;
		private NumericUpDown paidNumericUpDown;
		private CheckBox requiresDeliveryCheckBox;
		private CheckBox isDeliveryPaidCheckBox;
		private Button addItemButton;
		private Button removeItemButton;
		private Button confirmButton;
		private Button cancelButton;
		private Button editItemButton;
		private ErrorProvider errorProvider;
	}
}