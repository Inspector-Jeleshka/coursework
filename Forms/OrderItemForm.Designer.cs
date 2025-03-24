namespace coursework.Forms
{
	partial class OrderItemForm
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
			productLabel = new Label();
			productComboBox = new ComboBox();
			quantityLabel = new Label();
			quantityNumericUpDown = new NumericUpDown();
			priceStaticLabel = new Label();
			priceLabel = new Label();
			totalStaticLabel = new Label();
			totalLabel = new Label();
			confirmButton = new Button();
			cancelButton = new Button();
			((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
			SuspendLayout();
			// 
			// productLabel
			// 
			productLabel.AutoSize = true;
			productLabel.Location = new Point(20, 20);
			productLabel.Name = "productLabel";
			productLabel.Size = new Size(42, 15);
			productLabel.TabIndex = 0;
			productLabel.Text = "Товар:";
			// 
			// productComboBox
			// 
			productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			productComboBox.Location = new Point(120, 17);
			productComboBox.Name = "productComboBox";
			productComboBox.Size = new Size(160, 23);
			productComboBox.TabIndex = 1;
			productComboBox.SelectedIndexChanged += productComboBox_SelectedIndexChanged;
			// 
			// quantityLabel
			// 
			quantityLabel.AutoSize = true;
			quantityLabel.Location = new Point(20, 60);
			quantityLabel.Name = "quantityLabel";
			quantityLabel.Size = new Size(75, 15);
			quantityLabel.TabIndex = 2;
			quantityLabel.Text = "Количество:";
			// 
			// quantityNumericUpDown
			// 
			quantityNumericUpDown.Location = new Point(120, 57);
			quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			quantityNumericUpDown.Name = "quantityNumericUpDown";
			quantityNumericUpDown.Size = new Size(160, 23);
			quantityNumericUpDown.TabIndex = 3;
			quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			quantityNumericUpDown.ValueChanged += quantityNumericUpDown_ValueChanged;
			// 
			// priceStaticLabel
			// 
			priceStaticLabel.AutoSize = true;
			priceStaticLabel.Location = new Point(20, 100);
			priceStaticLabel.Name = "priceStaticLabel";
			priceStaticLabel.Size = new Size(38, 15);
			priceStaticLabel.TabIndex = 4;
			priceStaticLabel.Text = "Цена:";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new Point(120, 100);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(54, 15);
			priceLabel.TabIndex = 5;
			priceLabel.Text = "0,00 руб.";
			// 
			// totalStaticLabel
			// 
			totalStaticLabel.AutoSize = true;
			totalStaticLabel.Location = new Point(20, 140);
			totalStaticLabel.Name = "totalStaticLabel";
			totalStaticLabel.Size = new Size(88, 15);
			totalStaticLabel.TabIndex = 6;
			totalStaticLabel.Text = "Общая сумма:";
			// 
			// totalLabel
			// 
			totalLabel.AutoSize = true;
			totalLabel.Location = new Point(120, 140);
			totalLabel.Name = "totalLabel";
			totalLabel.Size = new Size(54, 15);
			totalLabel.TabIndex = 7;
			totalLabel.Text = "0,00 руб.";
			// 
			// confirmButton
			// 
			confirmButton.Location = new Point(160, 180);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(120, 30);
			confirmButton.TabIndex = 8;
			confirmButton.Text = "OK";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(20, 180);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(120, 30);
			cancelButton.TabIndex = 9;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// OrderItemForm
			// 
			ClientSize = new Size(300, 230);
			Controls.Add(productLabel);
			Controls.Add(productComboBox);
			Controls.Add(quantityLabel);
			Controls.Add(quantityNumericUpDown);
			Controls.Add(priceStaticLabel);
			Controls.Add(priceLabel);
			Controls.Add(totalStaticLabel);
			Controls.Add(totalLabel);
			Controls.Add(confirmButton);
			Controls.Add(cancelButton);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "OrderItemForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Добавить товар";
			((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private Label productLabel;
		private ComboBox productComboBox;
		private Label quantityLabel;
		private NumericUpDown quantityNumericUpDown;
		private Label priceStaticLabel;
		private Label priceLabel;
		private Label totalStaticLabel;
		private Label totalLabel;
		private Button confirmButton;
		private Button cancelButton;
	}
}