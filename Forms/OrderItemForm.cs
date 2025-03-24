namespace coursework.Forms
{
	public partial class OrderItemForm : Form, IDataEntryForm<OrderItem>
	{
		private List<Product> products;
		private OrderItem? currentItem;
		private readonly List<Guid>? existingProductIds;
		private readonly bool isEditMode;

		public OrderItemForm(List<Product> products, List<Guid>? existingProductIds)
		{
			InitializeComponent();
			this.products = products;
			this.existingProductIds = existingProductIds;
			isEditMode = false;
			LoadProducts();
		}
		public OrderItemForm(List<Product> products, OrderItem itemToEdit)
		{
			InitializeComponent();
			this.products = products;
			currentItem = itemToEdit;
			isEditMode = true;

			productComboBox.Enabled = false;
			productComboBox.DataSource = new List<Product> { currentItem.Product };
			productComboBox.DisplayMember = "Name";
			productComboBox.ValueMember = "ProductID";
			quantityNumericUpDown.Value = currentItem.Quantity;
			UpdatePriceLabels();
		}

		private void LoadProducts()
		{
			if (existingProductIds != null)
				products = products.Where(p => !existingProductIds.Contains(p.ProductID)).ToList();

			productComboBox.DataSource = products;
			productComboBox.DisplayMember = "Name";
			productComboBox.ValueMember = "ProductID";
		}

		public void SetData(OrderItem data)
		{
			currentItem = data;
			productComboBox.SelectedItem = data.Product;
			quantityNumericUpDown.Value = data.Quantity;
			UpdatePriceLabels();
		}
		public OrderItem? ShowDialogAndGetResult()
		{
			ShowDialog();
			return currentItem;
		}
		private void UpdatePriceLabels()
		{
			if (productComboBox.SelectedItem is Product selectedProduct)
			{
				priceLabel.Text = $"{selectedProduct.Price:C}";
				decimal total = selectedProduct.Price * quantityNumericUpDown.Value;
				totalLabel.Text = $"{total:C}";
			}
		}

		private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdatePriceLabels();
		}
		private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			UpdatePriceLabels();
		}
		private void confirmButton_Click(object sender, EventArgs e)
		{
			if (productComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var product = (Product)productComboBox.SelectedItem;
			int quantity = (int)quantityNumericUpDown.Value;

			currentItem = isEditMode ? currentItem : new OrderItem(product, quantity);
			currentItem!.Quantity = quantity;

			DialogResult = DialogResult.OK;
			Close();
		}
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}