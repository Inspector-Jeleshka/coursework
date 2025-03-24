using System.ComponentModel;

namespace coursework.Forms
{
	partial class ClientForm
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
			nameTextBox = new TextBox();
			confirmButton = new Button();
			cancelButton = new Button();
			nameLabel = new Label();
			phoneLabel = new Label();
			errorProvider = new ErrorProvider(components);
			phoneTextBox = new MaskedTextBox();
			addressLabel = new Label();
			addressTextBox = new TextBox();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// nameTextBox
			// 
			nameTextBox.Location = new Point(120, 17);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(200, 23);
			nameTextBox.TabIndex = 0;
			nameTextBox.Validating += nameTextBox_Validating;
			// 
			// confirmButton
			// 
			confirmButton.Location = new Point(220, 150);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(100, 30);
			confirmButton.TabIndex = 3;
			confirmButton.Text = "ОК";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(120, 150);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 30);
			cancelButton.TabIndex = 4;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(20, 20);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(34, 15);
			nameLabel.TabIndex = 5;
			nameLabel.Text = "Имя:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new Point(20, 60);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new Size(58, 15);
			phoneLabel.TabIndex = 6;
			phoneLabel.Text = "Телефон:";
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// phoneTextBox
			// 
			phoneTextBox.Location = new Point(120, 57);
			phoneTextBox.Mask = "+7 (999) 000-0000";
			phoneTextBox.Name = "phoneTextBox";
			phoneTextBox.Size = new Size(200, 23);
			phoneTextBox.TabIndex = 8;
			phoneTextBox.Validating += phoneTextBox_Validating;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new Point(20, 100);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new Size(43, 15);
			addressLabel.TabIndex = 9;
			addressLabel.Text = "Адрес:";
			// 
			// addressTextBox
			// 
			addressTextBox.Location = new Point(120, 97);
			addressTextBox.Name = "addressTextBox";
			addressTextBox.Size = new Size(200, 23);
			addressTextBox.TabIndex = 10;
			addressTextBox.Validating += addressTextBox_Validating;
			// 
			// ClientForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(350, 200);
			Controls.Add(addressTextBox);
			Controls.Add(addressLabel);
			Controls.Add(nameLabel);
			Controls.Add(nameTextBox);
			Controls.Add(phoneLabel);
			Controls.Add(phoneTextBox);
			Controls.Add(confirmButton);
			Controls.Add(cancelButton);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ClientForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Данные клиента";
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox nameTextBox;
		private Button confirmButton;
		private Button cancelButton;
		private Label nameLabel;
		private Label phoneLabel;
		private ErrorProvider errorProvider;
		private MaskedTextBox phoneTextBox;
		private TextBox addressTextBox;
		private Label addressLabel;
	}
}