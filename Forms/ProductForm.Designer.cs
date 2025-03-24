namespace coursework.Forms
{
	partial class ProductForm
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
			nameLabel = new Label();
			nameTextBox = new TextBox();
			priceLabel = new Label();
			priceNumericUpDown = new NumericUpDown();
			confirmButton = new Button();
			cancelButton = new Button();
			errorProvider = new ErrorProvider(components);
			quantityNumericUpDown = new NumericUpDown();
			quantityLabel = new Label();
			((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
			SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(12, 17);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(62, 15);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Название:";
			// 
			// nameTextBox
			// 
			nameTextBox.Location = new Point(115, 14);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(200, 23);
			nameTextBox.TabIndex = 1;
			nameTextBox.Validating += nameTextBox_Validating;
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new Point(12, 54);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(38, 15);
			priceLabel.TabIndex = 2;
			priceLabel.Text = "Цена:";
			// 
			// priceNumericUpDown
			// 
			priceNumericUpDown.DecimalPlaces = 2;
			priceNumericUpDown.Location = new Point(115, 52);
			priceNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			priceNumericUpDown.Name = "priceNumericUpDown";
			priceNumericUpDown.Size = new Size(200, 23);
			priceNumericUpDown.TabIndex = 3;
			priceNumericUpDown.ThousandsSeparator = true;
			priceNumericUpDown.Validating += priceNumericUpDown_Validating;
			// 
			// confirmButton
			// 
			confirmButton.Location = new Point(230, 152);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(100, 30);
			confirmButton.TabIndex = 4;
			confirmButton.Text = "ОК";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(130, 152);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 30);
			cancelButton.TabIndex = 5;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// quantityNumericUpDown
			// 
			quantityNumericUpDown.Location = new Point(115, 90);
			quantityNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			quantityNumericUpDown.Name = "quantityNumericUpDown";
			quantityNumericUpDown.Size = new Size(200, 23);
			quantityNumericUpDown.TabIndex = 7;
			quantityNumericUpDown.ThousandsSeparator = true;
			// 
			// quantityLabel
			// 
			quantityLabel.AutoSize = true;
			quantityLabel.Location = new Point(12, 92);
			quantityLabel.Name = "quantityLabel";
			quantityLabel.Size = new Size(75, 15);
			quantityLabel.TabIndex = 6;
			quantityLabel.Text = "Количество:";
			// 
			// ProductForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(354, 194);
			Controls.Add(quantityNumericUpDown);
			Controls.Add(quantityLabel);
			Controls.Add(cancelButton);
			Controls.Add(confirmButton);
			Controls.Add(priceNumericUpDown);
			Controls.Add(priceLabel);
			Controls.Add(nameTextBox);
			Controls.Add(nameLabel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "ProductForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Данные товара";
			((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private Label nameLabel;
		private TextBox nameTextBox;
		private Label priceLabel;
		private NumericUpDown priceNumericUpDown;
		private Button confirmButton;
		private Button cancelButton;
		private ErrorProvider errorProvider;
		private NumericUpDown quantityNumericUpDown;
		private Label quantityLabel;
	}
}