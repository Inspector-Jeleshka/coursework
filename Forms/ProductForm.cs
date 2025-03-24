namespace coursework.Forms
{
	public partial class ProductForm : Form, IDataEntryForm<Product>
	{
		private readonly MainPresenter presenter;
		private Product? currentData;

		public ProductForm(MainPresenter presenter)
		{
			InitializeComponent();
			this.presenter = presenter;
		}

		public void SetData(Product data)
		{
			currentData = data;
			nameTextBox.Text = data.Name;
			priceNumericUpDown.Value = data.Price;
			quantityNumericUpDown.Value = presenter.Warehouse.GetStock(data);
		}
		public Product? ShowDialogAndGetResult()
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
				currentData.Price = priceNumericUpDown.Value;
			}
			else
				currentData = new Product(nameTextBox.Text, priceNumericUpDown.Value);

			presenter.Warehouse.Stock[currentData] = (int)quantityNumericUpDown.Value;

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
			if (string.IsNullOrEmpty(((TextBox)sender).Text))
			{
				errorProvider.SetError((Control)sender, "Название не указано!");
				return;
			}

			errorProvider.SetError((Control)sender, null);
		}
		private void priceNumericUpDown_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (((NumericUpDown)sender).Value == 0)
			{
				errorProvider.SetError((Control)sender, "Укажите цену!");
				return;
			}

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
