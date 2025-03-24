using System.ComponentModel;

namespace coursework.Forms
{
	public partial class ClientForm : Form, IDataEntryForm<Client>
	{
		private Client? currentData;

		public ClientForm()
		{
			InitializeComponent();
		}

		public void SetData(Client data)
		{
			currentData = data;
			nameTextBox.Text = data.Name;
			phoneTextBox.Text = data.Phone;
			addressTextBox.Text = data.Address;
		}
		public Client? ShowDialogAndGetResult()
		{
			ShowDialog();
			return currentData;
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			ValidateChildren();

			if (HasErrors(this))
			{
				MessageBox.Show("Исправьте ошибки перед продолжением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (currentData != null)
			{
				currentData.Name = nameTextBox.Text;
				currentData.Phone = phoneTextBox.Text;
				currentData.Address = addressTextBox.Text;
			}
			else
				currentData = new Client(nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text);

			DialogResult = DialogResult.OK;
			Close();
		}
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(((TextBoxBase)sender).Text))
			{
				errorProvider.SetError((Control)sender, "Имя не указано!");
				return;
			}

			foreach (var item in ((TextBoxBase)sender).Text)
			{
				if (!char.IsLetter(item) && !char.IsWhiteSpace(item))
				{
					errorProvider.SetError((Control)sender, "Имя может содержать только буквы и пробелы!");
					return;
				}
			}

			errorProvider.SetError((Control)sender, null);
		}
		private void phoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			string rawPhoneNumber = ((TextBoxBase)sender).Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("+7", "");

			if (string.IsNullOrEmpty(rawPhoneNumber))
				errorProvider.SetError((Control)sender, "Номер телефона не указан!");
			if (rawPhoneNumber.Length < 10)
				errorProvider.SetError((Control)sender, "Неверная длина номера!");
			else
				errorProvider.SetError((Control)sender, null);
		}
		private void addressTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(((TextBoxBase)sender).Text))
				errorProvider.SetError((Control)sender, "Адрес не указан!");
			else
				errorProvider.SetError((Control)sender, null);
		}
		private bool HasErrors(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (!string.IsNullOrEmpty(errorProvider.GetError(c)))
					return true;
				if (c.Controls.Count > 0 && HasErrors(c))
					return true;
			}
			return false;
		}
	}
}
