namespace coursework.Forms
{
	public partial class MainForm : Form
	{
		private readonly MainPresenter presenter;

		public MainForm()
		{
			InitializeComponent();

			presenter = new MainPresenter(this);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			presenter.LoadData();

			mainPresenterBindingSource.DataSource = presenter;
			InitProductColumns();
		}
		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			presenter.SaveData();
		}

		#region clientTab
		private void addClientButton_Click(object sender, EventArgs e)
		{
			presenter.AddClient();
		}
		private void editClientButton_Click(object sender, EventArgs e)
		{
			if (clientsDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var clientID = (Guid)clientsDataGrid.CurrentRow.Cells[0].Value;

			presenter.EditClient(clientID);
			clientsDataGrid.Refresh();
		}
		private void removeClientButton_Click(object sender, EventArgs e)
		{
			if (clientsDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var clientID = (Guid)clientsDataGrid.CurrentRow.Cells[0].Value;

			presenter.RemoveClient(clientID);
		}
		#endregion

		#region productTab
		private void addProductButton_Click(object sender, EventArgs e)
		{
			presenter.AddProduct();
			presenter.RefreshProductsData(productsDataGrid);
		}
		private void editProductButton_Click(object sender, EventArgs e)
		{
			if (productsDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите товар!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)productsDataGrid.CurrentRow.Cells[0].Value;

			presenter.EditProduct(id);
			presenter.RefreshProductsData(productsDataGrid);
		}
		private void removeProductButton_Click(object sender, EventArgs e)
		{
			if (productsDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите товар!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)productsDataGrid.CurrentRow.Cells[0].Value;

			presenter.RemoveProduct(id);
			presenter.RefreshProductsData(productsDataGrid);
		}
		private void InitProductColumns()
		{
			productsDataGrid.AutoGenerateColumns = false;

			presenter.RefreshProductsData(productsDataGrid);
		}
		#endregion

		#region orderTab
		private void addOrderButton_Click(object sender, EventArgs a)
		{
			presenter.AddOrder();
		}
		private void editOrderButton_Click(object sender, EventArgs e)
		{
			if (ordersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)ordersDataGrid.CurrentRow.Cells[0].Value;

			presenter.EditOrder(id);
			ordersDataGrid.Refresh();
		}
		private void removeOrderButton_Click(object sender, EventArgs e)
		{
			if (ordersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)ordersDataGrid.CurrentRow.Cells[0].Value;

			presenter.RemoveOrder(id);
		}
		private void completeOrderButton_Click(object sender, EventArgs e)
		{
			if (ordersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)ordersDataGrid.CurrentRow.Cells[0].Value;

			presenter.CompleteOrder(id);
			ordersDataGrid.Refresh();
			presenter.RefreshProductsData(productsDataGrid);
		}
		private void makeInvoiceButton_Click(object sender, EventArgs e)
		{
			if (ordersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)ordersDataGrid.CurrentRow.Cells[0].Value;

			presenter.GenerateInvoice(id);
		}
		#endregion

		#region supplierTab
		private void addSupplierButton_Click(object sender, EventArgs e)
		{
			presenter.AddSupplier();
		}
		private void editSupplierButton_Click(object sender, EventArgs e)
		{
			if (suppliersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)suppliersDataGrid.CurrentRow.Cells[0].Value;

			presenter.EditSupplier(id);
			suppliersDataGrid.Refresh();
		}
		private void removeSupplierButton_Click(object sender, EventArgs e)
		{
			if (suppliersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)suppliersDataGrid.CurrentRow.Cells[0].Value;

			presenter.RemoveSupplier(id);
		}
		#endregion

		#region supplierOrdersTab
		private void addSupplierOrderButton_Click(object sender, EventArgs e)
		{
			presenter.AddSupplierOrder();
			productsDataGrid.Refresh();
		}
		private void editSupplierOrderButton_Click(object sender, EventArgs e)
		{
			if (supplierOrdersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)supplierOrdersDataGrid.CurrentRow.Cells[0].Value;
			presenter.EditSupplierOrder(id);
			supplierOrdersDataGrid.Refresh();
			productsDataGrid.Refresh();
		}
		private void removeSupplierOrderButton_Click(object sender, EventArgs e)
		{
			if (supplierOrdersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)supplierOrdersDataGrid.CurrentRow.Cells[0].Value;
			presenter.RemoveSupplierOrder(id);
			productsDataGrid.Refresh();
		}
		private void completeSupplierOrderButton_Click(object sender, EventArgs e)
		{
			if (supplierOrdersDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var id = (Guid)supplierOrdersDataGrid.CurrentRow.Cells[0].Value;

			presenter.CompleteSupplierOrder(id);
			supplierOrdersDataGrid.Refresh();
			presenter.RefreshProductsData(productsDataGrid);
		}
		#endregion

		#region analyticsTab
		private void compareButton_Click(object sender, EventArgs e)
		{
			var result = presenter.AnalyzePeriods(
				period1StartPicker.Value,
				period1EndPicker.Value,
				period2StartPicker.Value,
				period2EndPicker.Value
			);

			comparisonGrid.Rows.Clear();
			topProductsGrid.Rows.Clear();

			// Заполнение сравнения
			foreach (var product in presenter.Products)
			{
				if (result.ProductStats.TryGetValue(product.ProductID, out var stats))
				{
					comparisonGrid.Rows.Add(
						product.Name,
						stats.Purchased,
						stats.Sold,
						stats.Sold - stats.Purchased
					);
				}
			}

			// Заполнение топ товаров
			int position = 1;
			foreach (var product in result.TopProducts)
			{
				topProductsGrid.Rows.Add(
					position++,
					product.Name,
					result.ProductStats[product.ProductID].Sold
				);
			}

			// Отображение прибыли
			profitTextBox.Text = result.Profit.ToString("C2");
		}

		#endregion

	}
}
