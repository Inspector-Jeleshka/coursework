using System.ComponentModel;

namespace coursework.Forms
{
	public partial class OrderForm : Form, IDataEntryForm<Order>
	{
		private readonly MainPresenter presenter;
		private Order? currentData;
		private List<OrderItem> tempItems = new();

		public OrderForm(MainPresenter presenter)
		{
			InitializeComponent();
			this.presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
			statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

			InitializeGridColumns();
			LoadClients();
			LoadOrderItems();
		}

		private void InitializeGridColumns()
		{
			itemsDataGridView.AutoGenerateColumns = false;

			itemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "ProductName",
				HeaderText = "Товар"
			});

			itemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Quantity",
				HeaderText = "Количество"
			});

			itemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Price",
				HeaderText = "Цена"
			});

			itemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "TotalPrice",
				HeaderText = "Итог"
			});
		}
		private void LoadClients()
		{
			clientComboBox.DataSource = presenter.Clients.ToList();
			clientComboBox.DisplayMember = "Name";
			clientComboBox.ValueMember = "ClientID";
		}

		public void SetData(Order data)
		{
			currentData = data;

			tempItems = new(currentData.Items.Select(i => new OrderItem(i)).ToList());

			clientComboBox.SelectedItem = data.Client;
			orderDatePicker.Value = data.OrderDate;
			deliveryDatePicker.Value = data.DeliveryDate;
			requiresDeliveryCheckBox.Checked = data.RequiresDelivery;
			isDeliveryPaidCheckBox.Checked = data.IsDeliveryPaid;
			paidNumericUpDown.Value = data.PaidCost;
			statusComboBox.SelectedItem = data.Status;

			LoadOrderItems();
		}
		public Order? ShowDialogAndGetResult()
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
			bool isDraft = (OrderStatus)statusComboBox.SelectedItem! == OrderStatus.Draft;

			orderDatePicker.Enabled = isDraft;
			addItemButton.Enabled = isDraft;
			editItemButton.Enabled = isDraft;
			removeItemButton.Enabled = isDraft;

			if ((OrderStatus)statusComboBox.SelectedItem == OrderStatus.Completed)
				ValidateChildren();
		}
		private void requiresDeliveryCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			isDeliveryPaidCheckBox.Enabled = requiresDeliveryCheckBox.Checked;

			if (!requiresDeliveryCheckBox.Checked)
				isDeliveryPaidCheckBox.Checked = false;
		}
		private void addItemButton_Click(object sender, EventArgs e)
		{
			var existingIds = tempItems.Select(i => i.Product.ProductID).ToList();
			using var itemForm = new OrderItemForm(presenter.Products.ToList(), existingIds);
			var newItem = itemForm.ShowDialogAndGetResult();

			if (newItem == null)
				return;

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

			using var itemForm = new OrderItemForm(presenter.Products.ToList(), itemToEdit);
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

			if (clientComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			if ((OrderStatus)statusComboBox.SelectedItem! == OrderStatus.Completed)
				foreach (var item in tempItems)
					if (presenter.Warehouse.GetStock(item.Product) < item.Quantity)
					{
						MessageBox.Show("Недостаточно товара на складе для закрытия заказа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

			currentData ??= new Order((Client)clientComboBox.SelectedItem, orderDatePicker.Value);

			currentData.Client = (Client)clientComboBox.SelectedItem;
			currentData.OrderDate = orderDatePicker.Value;
			currentData.DeliveryDate = deliveryDatePicker.Value;
			currentData.RequiresDelivery = requiresDeliveryCheckBox.Checked;
			currentData.Status = (OrderStatus)statusComboBox.SelectedItem!;
			currentData.IsDeliveryPaid = isDeliveryPaidCheckBox.Checked;
			currentData.PaidCost = paidNumericUpDown.Value;
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
				errorProvider.SetError((Control)sender, "Дата доставки не может быть раньше даты заказа!");
			else if ((OrderStatus)statusComboBox.SelectedValue! == OrderStatus.Completed
					&& ((DateTimePicker)sender).Value > DateTime.Today.AddDays(1))
				errorProvider.SetError((Control)sender, "Невозможно завершить заказ: дата доставки еще не наступила!");
			else
				errorProvider.SetError((Control)sender, null);
		}
		private void paidNumericUpDown_Validating(object sender, CancelEventArgs e)
		{
			decimal totalCost = tempItems.Sum(i => i.TotalPrice);
			if ((OrderStatus)statusComboBox.SelectedItem! == OrderStatus.Completed
					&& paidNumericUpDown.Value < totalCost)
				errorProvider.SetError((Control)sender, "Оплата должна покрывать полную стоимость заказа!");
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
