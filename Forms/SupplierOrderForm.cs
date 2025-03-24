using System.ComponentModel;

namespace coursework.Forms
{
	public partial class SupplierOrderForm : Form, IDataEntryForm<SupplierOrder>
	{
		private readonly MainPresenter presenter;
		private SupplierOrder? currentData;
		private List<OrderItem> tempItems = new();
		private Supplier? previousSupplier;

		public SupplierOrderForm(MainPresenter presenter)
		{
			InitializeComponent();
			this.presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
			statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

			InitializeGridColumns();
			LoadSuppliers();
			LoadOrderItems();

			previousSupplier = supplierComboBox.SelectedItem as Supplier;
		}

		private void InitializeGridColumns()
		{
			itemsDataGridView.AutoGenerateColumns = false;
			itemsDataGridView.Columns.Clear();

			var productColumn = new DataGridViewTextBoxColumn
			{
				Name = "ProductName",
				HeaderText = "Товар"
			};

			var quantityColumn = new DataGridViewTextBoxColumn
			{
				Name = "Quantity",
				HeaderText = "Количество"
			};

			var priceColumn = new DataGridViewTextBoxColumn
			{
				Name = "Price",
				HeaderText = "Цена"
			};

			var totalColumn = new DataGridViewTextBoxColumn
			{
				Name = "TotalPrice",
				HeaderText = "Итог"
			};

			itemsDataGridView.Columns.AddRange(productColumn, quantityColumn, priceColumn, totalColumn);
		}
		private void LoadSuppliers()
		{
			supplierComboBox.DataSource = presenter.Suppliers.ToList();
			supplierComboBox.DisplayMember = "Name";
			supplierComboBox.ValueMember = "SupplierID";
		}

		public void SetData(SupplierOrder data)
		{
			currentData = data;
			tempItems = new(data.Items.Select(i => new OrderItem(i)).ToList());

			supplierComboBox.SelectedItem = data.Supplier;
			previousSupplier = data.Supplier;
			orderDatePicker.Value = data.OrderDate;
			expectedDeliveryDatePicker.Value = data.ExpectedDeliveryDate;
			statusComboBox.SelectedItem = data.Status;

			LoadOrderItems();
		}
		public SupplierOrder? ShowDialogAndGetResult()
		{
			ShowDialog();
			return currentData;
		}

		private void LoadOrderItems()
		{
			itemsDataGridView.Rows.Clear();

			foreach (var item in tempItems)
				itemsDataGridView.Rows.Add(item.Product.Name, item.Quantity, item.Product.Price, item.TotalPrice);
		}

		private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedStatus = (OrderStatus)statusComboBox.SelectedItem!;
			bool isDraft = selectedStatus == OrderStatus.Draft;

			orderDatePicker.Enabled = isDraft;
			addItemButton.Enabled = isDraft;
			editItemButton.Enabled = isDraft;
			removeItemButton.Enabled = isDraft;

			if (selectedStatus == OrderStatus.Completed)
				ValidateChildren();
		}
		private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var newSupplier = supplierComboBox.SelectedItem as Supplier;

			if (newSupplier == null || newSupplier == previousSupplier)
				return;

			if (tempItems.Count > 0)
			{
				var result = MessageBox.Show(
					"При смене поставщика список товаров будет очищен. Продолжить?",
					"Внимание",	MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.No)
				{
					supplierComboBox.SelectedItem = previousSupplier;
					return;
				}
			}

			previousSupplier = newSupplier;
			tempItems.Clear();
			LoadOrderItems();
		}
		private void addItemButton_Click(object sender, EventArgs e)
		{
			var existingIds = tempItems.Select(i => i.Product.ProductID).ToList();

			if (supplierComboBox.SelectedValue == null)
				return;

			var supplierProducts = ((Supplier)supplierComboBox.SelectedItem!).SuppliedProducts;
			using var itemForm = new OrderItemForm(supplierProducts, existingIds);
			var newItem = itemForm.ShowDialogAndGetResult();

			if (newItem == null)
				return;

			var existingItem = tempItems.FirstOrDefault(i => i.Product.ProductID == newItem.Product.ProductID);
			if (existingItem != null)
				existingItem.Quantity += newItem.Quantity;
			else
				tempItems.Add(newItem);

			LoadOrderItems();
		}
		private void editItemButton_Click(object sender, EventArgs e)
		{
			if (itemsDataGridView.CurrentRow == null)
				return;

			string productName = itemsDataGridView.CurrentRow.Cells[0].Value.ToString()!;
			var itemToEdit = tempItems.FirstOrDefault(i => i.Product.Name == productName);

			if (itemToEdit == null)
				return;

			if (supplierComboBox.SelectedValue == null)
				return;

			var supplierProducts = ((Supplier)supplierComboBox.SelectedItem!).SuppliedProducts;
			using var itemForm = new OrderItemForm(supplierProducts, itemToEdit);
			var result = itemForm.ShowDialogAndGetResult();

			if (result == null)
				return;

			itemToEdit.Quantity = result.Quantity;
			LoadOrderItems();
		}
		private void removeItemButton_Click(object sender, EventArgs e)
		{
			if (itemsDataGridView.CurrentRow == null)
				return;

			string productName = itemsDataGridView.CurrentRow.Cells[0].Value.ToString()!;
			var itemToRemove = tempItems.FirstOrDefault(i => i.Product.Name == productName);

			if (itemToRemove == null)
				return;

			tempItems.Remove(itemToRemove);
			LoadOrderItems();
		}
		private void confirmButton_Click(object sender, EventArgs e)
		{
			ValidateChildren();

			if (supplierComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите поставщика!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (tempItems.Count == 0)
			{
				MessageBox.Show("Добавьте товары!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (HasErrors(this))
			{
				MessageBox.Show("Исправьте ошибки перед продолжением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			currentData ??= new SupplierOrder((Supplier)supplierComboBox.SelectedItem, orderDatePicker.Value);

			currentData.Supplier = (Supplier)supplierComboBox.SelectedItem;
			currentData.OrderDate = orderDatePicker.Value;
			currentData.ExpectedDeliveryDate = expectedDeliveryDatePicker.Value;
			currentData.Status = (OrderStatus)statusComboBox.SelectedItem!;
			currentData.Items = tempItems;

			DialogResult = DialogResult.OK;
			Close();
		}
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		private void deliveryDatePicker_Validating(object sender, CancelEventArgs e)
		{
			if (((DateTimePicker)sender).Value < orderDatePicker.Value)
				errorProvider.SetError((Control)sender, "Ожидаемая дата доставки не может быть раньше даты заказа!");
			if ((OrderStatus)statusComboBox.SelectedValue! == OrderStatus.Completed
					&& ((DateTimePicker)sender).Value > DateTime.Today.AddDays(1))
				errorProvider.SetError((Control)sender, "Невозможно завершить заказ: дата доставки еще не наступила!");
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
