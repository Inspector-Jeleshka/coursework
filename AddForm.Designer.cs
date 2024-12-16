namespace coursework
{
	partial class AddForm
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
			confirmButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// confirmButton
			// 
			confirmButton.Location = new Point(30, 380);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(100, 40);
			confirmButton.TabIndex = 4;
			confirmButton.Text = "Принять";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(250, 380);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 40);
			cancelButton.TabIndex = 5;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// AddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(384, 451);
			Controls.Add(cancelButton);
			Controls.Add(confirmButton);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "AddForm";
			Text = "AddForm";
			ResumeLayout(false);
		}

		#endregion
		private Button confirmButton;
		private Button cancelButton;
	}
}