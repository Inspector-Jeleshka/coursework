namespace coursework.Forms
{
	partial class SupplierForm
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
			errorProvider = new ErrorProvider(components);
			nameLabel = new Label();
			nameTextBox = new TextBox();
			confirmButton = new Button();
			cancelButton = new Button();
			supplierProductsGrid = new DataGridView();
			allProductsGrid = new DataGridView();
			addButton = new Button();
			removeButton = new Button();
			supplierProductsLabel = new Label();
			allProductsLabel = new Label();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			((System.ComponentModel.ISupportInitialize)supplierProductsGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)allProductsGrid).BeginInit();
			SuspendLayout();
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(12, 15);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(62, 15);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Название:";
			// 
			// nameTextBox
			// 
			nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nameTextBox.Location = new Point(80, 12);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(704, 23);
			nameTextBox.TabIndex = 1;
			nameTextBox.Validating += nameTextBox_Validating;
			// 
			// confirmButton
			// 
			confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			confirmButton.Location = new Point(694, 363);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(90, 25);
			confirmButton.TabIndex = 8;
			confirmButton.Text = "OK";
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cancelButton.Location = new Point(598, 363);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(90, 25);
			cancelButton.TabIndex = 9;
			cancelButton.Text = "Отмена";
			cancelButton.Click += cancelButton_Click;
			// 
			// supplierProductsGrid
			// 
			supplierProductsGrid.AllowUserToAddRows = false;
			supplierProductsGrid.AllowUserToDeleteRows = false;
			supplierProductsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			supplierProductsGrid.Location = new Point(12, 75);
			supplierProductsGrid.Name = "supplierProductsGrid";
			supplierProductsGrid.ReadOnly = true;
			supplierProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			supplierProductsGrid.Size = new Size(350, 280);
			supplierProductsGrid.TabIndex = 4;
			// 
			// allProductsGrid
			// 
			allProductsGrid.AllowUserToAddRows = false;
			allProductsGrid.AllowUserToDeleteRows = false;
			allProductsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			allProductsGrid.Location = new Point(434, 75);
			allProductsGrid.Name = "allProductsGrid";
			allProductsGrid.ReadOnly = true;
			allProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			allProductsGrid.Size = new Size(350, 280);
			allProductsGrid.TabIndex = 5;
			// 
			// addButton
			// 
			addButton.Location = new Point(368, 175);
			addButton.Name = "addButton";
			addButton.Size = new Size(60, 30);
			addButton.TabIndex = 6;
			addButton.Text = "<";
			addButton.Click += addButton_Click;
			// 
			// removeButton
			// 
			removeButton.Location = new Point(368, 215);
			removeButton.Name = "removeButton";
			removeButton.Size = new Size(60, 30);
			removeButton.TabIndex = 7;
			removeButton.Text = ">";
			removeButton.Click += removeButton_Click;
			// 
			// supplierProductsLabel
			// 
			supplierProductsLabel.AutoSize = true;
			supplierProductsLabel.Location = new Point(12, 50);
			supplierProductsLabel.Name = "supplierProductsLabel";
			supplierProductsLabel.Size = new Size(118, 15);
			supplierProductsLabel.TabIndex = 2;
			supplierProductsLabel.Text = "Товары поставщика";
			// 
			// allProductsLabel
			// 
			allProductsLabel.AutoSize = true;
			allProductsLabel.Location = new Point(434, 50);
			allProductsLabel.Name = "allProductsLabel";
			allProductsLabel.Size = new Size(69, 15);
			allProductsLabel.TabIndex = 3;
			allProductsLabel.Text = "Все товары";
			// 
			// SupplierForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(805, 400);
			Controls.Add(cancelButton);
			Controls.Add(confirmButton);
			Controls.Add(removeButton);
			Controls.Add(addButton);
			Controls.Add(allProductsGrid);
			Controls.Add(supplierProductsGrid);
			Controls.Add(allProductsLabel);
			Controls.Add(supplierProductsLabel);
			Controls.Add(nameTextBox);
			Controls.Add(nameLabel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "SupplierForm";
			Text = "Данные поставщика";
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			((System.ComponentModel.ISupportInitialize)supplierProductsGrid).EndInit();
			((System.ComponentModel.ISupportInitialize)allProductsGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ErrorProvider errorProvider;
		private Label nameLabel;
		private TextBox nameTextBox;
		private Label supplierProductsLabel;
		private Label allProductsLabel;
		private DataGridView supplierProductsGrid;
		private DataGridView allProductsGrid;
		private Button addButton;
		private Button removeButton;
		private Button confirmButton;
		private Button cancelButton;
	}
}