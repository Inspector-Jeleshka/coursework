using System.ComponentModel;

namespace coursework.Forms
{
	public partial class SupplierForm : Form, IDataEntryForm<Supplier>
	{
		private readonly MainPresenter presenter;
		private Supplier? currentData;
		private BindingList<Product> supplierProducts;
		private BindingList<Product> allProducts;

		public SupplierForm(MainPresenter presenter)
		{
			InitializeComponent();
			this.presenter = presenter;
			ConfigureGrids();

			supplierProducts = new();
			allProducts = new(presenter.Products.ToList());
			supplierProductsGrid.DataSource = supplierProducts;
			allProductsGrid.DataSource = allProducts;
		}
		private void ConfigureGrids()
		{
			supplierProductsGrid.AutoGenerateColumns = false;
			allProductsGrid.AutoGenerateColumns = false;

			var nameColumn = new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Name",
				HeaderText = "Название"
			};

			var priceColumn = new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Price",
				HeaderText = "Цена"
			};

			supplierProductsGrid.Columns.AddRange(nameColumn, priceColumn);
			allProductsGrid.Columns.AddRange((DataGridViewColumn)nameColumn.Clone(),
				(DataGridViewColumn)priceColumn.Clone());
		}

		public void SetData(Supplier data)
		{
			currentData = data;
			nameTextBox.Text = data.Name;

			supplierProducts = new(data.SuppliedProducts.ToList());
			allProducts = new(presenter.Products.Except(data.SuppliedProducts).ToList());

			supplierProductsGrid.DataSource = supplierProducts;
			allProductsGrid.DataSource = allProducts;
		}
		public Supplier? ShowDialogAndGetResult()
		{
			ShowDialog();
			return currentData;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (allProductsGrid.SelectedRows.Count == 0)
				return;

			var selected = allProductsGrid.SelectedRows.Cast<DataGridViewRow>()
				.Select(r => (Product)r.DataBoundItem).ToList();

			foreach (var product in selected)
			{
				supplierProducts.Add(product);
				allProducts.Remove(product);
			}
		}
		private void removeButton_Click(object sender, EventArgs e)
		{
			if (supplierProductsGrid.SelectedRows.Count == 0)
				return;

			var selected = supplierProductsGrid.SelectedRows
				.Cast<DataGridViewRow>()
				.Select(r => (Product)r.DataBoundItem)
				.ToList();

			foreach (var product in selected)
			{
				allProducts.Add(product);
				supplierProducts.Remove(product);
			}
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
				currentData.SuppliedProducts = supplierProducts.ToList();
			}
			else
				currentData = new Supplier(nameTextBox.Text, supplierProducts.ToList());

			DialogResult = DialogResult.OK;
			Close();
		}
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void nameTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(((TextBoxBase)sender).Text))
			{
				errorProvider.SetError((Control)sender, "Имя не указано!");
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
