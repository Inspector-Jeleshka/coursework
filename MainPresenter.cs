using coursework.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace coursework
{
	public class MainPresenter
	{
		private readonly MainForm view;
		private const string DataFilePath = "data.json";


		public MainPresenter(MainForm view)
		{
			this.view = view ?? throw new ArgumentNullException(nameof(view));
		}


		public BindingList<Client> Clients { get; private set; } = new();
		public BindingList<Product> Products { get; private set; } = new();
		public BindingList<Order> Orders { get; private set; } = new();
		public BindingList<Supplier> Suppliers { get; private set; } = new();
		public BindingList<SupplierOrder> SupplierOrders { get; private set; } = new();
		public Warehouse Warehouse { get; set; } = new();


		public void LoadData()
		{
			if (!File.Exists(DataFilePath)) return;

			try
			{
				string fileContent = File.ReadAllText(DataFilePath);

				var baseData = JsonConvert.DeserializeObject<ApplicationData>(
					fileContent,
					new JsonSerializerSettings
					{
						PreserveReferencesHandling = PreserveReferencesHandling.Objects,
						ReferenceLoopHandling = ReferenceLoopHandling.Ignore
					}) ?? new ApplicationData();

				Clients = new BindingList<Client>(baseData.Clients ?? new List<Client>());
				Products = new BindingList<Product>(baseData.Products ?? new List<Product>());
				Suppliers = new BindingList<Supplier>(baseData.Suppliers ?? new List<Supplier>());

				var warehouseSettings = new JsonSerializerSettings
				{
					PreserveReferencesHandling = PreserveReferencesHandling.Objects,
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
					Context = new StreamingContext(StreamingContextStates.All, Products.ToList()),
					Converters = { new ProductDictionaryConverter() }
				};

				baseData = JsonConvert.DeserializeObject<ApplicationData>(fileContent, warehouseSettings);

				Warehouse = new(baseData!.Warehouse.Stock);

				Orders = new BindingList<Order>(baseData.Orders ?? new List<Order>());
				SupplierOrders = new BindingList<SupplierOrder>(baseData.SupplierOrders ?? new List<SupplierOrder>());

				RestoreRelationships();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Load error: {ex.Message}");
			}
		}
		public void SaveData()
		{
			try
			{
				var context = new StreamingContext(
					StreamingContextStates.All,
					Products.ToList()
				);

				var settings = new JsonSerializerSettings
				{
					Context = context,
					PreserveReferencesHandling = PreserveReferencesHandling.Objects,
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
					Formatting = Newtonsoft.Json.Formatting.Indented
				};

				var data = new ApplicationData
				{
					Clients = Clients.ToList(),
					Products = Products.ToList(),
					Orders = Orders.ToList(),
					Suppliers = Suppliers.ToList(),
					SupplierOrders = SupplierOrders.ToList(),
					Warehouse = Warehouse
				};

				var json = JsonConvert.SerializeObject(data, settings);

				File.WriteAllText(DataFilePath, json);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
			}
		}
		private void RestoreRelationships()
		{
			foreach (var order in Orders.ToList())
			{
				order.Client = Clients.FirstOrDefault(c => c?.ClientID == order.Client?.ClientID);
				foreach (var item in order.Items.ToList())
				{
					item.Product = Products.FirstOrDefault(p => p?.ProductID == item.Product?.ProductID);
				}
			}

			foreach (var supplierOrder in SupplierOrders.ToList())
			{
				supplierOrder.Supplier = Suppliers.FirstOrDefault(s => s?.SupplierID == supplierOrder.Supplier?.SupplierID);
				foreach (var item in supplierOrder.Items.ToList())
				{
					item.Product = Products.FirstOrDefault(p => p?.ProductID == item.Product?.ProductID);
				}
			}

			var validStock = new Dictionary<Product, int>();
			foreach (var kvp in Warehouse.Stock)
			{
				if (kvp.Key != null && Products.Contains(kvp.Key))
				{
					validStock[kvp.Key] = kvp.Value;
				}
			}
			Warehouse.Stock = validStock;
		}


		#region Clients Methods
		public void AddClient()
		{
			using var form = new ClientForm();
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				Clients.Add(data!);
				MessageBox.Show("Клиент добавлен!", "Успех");
			}
		}
		public void EditClient(Guid id)
		{
			using var form = new ClientForm();
			form.SetData(GetClient(id)!);
			form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
				MessageBox.Show("Данные клиента изменены!", "Успех");
		}
		public void RemoveClient(Guid id)
		{
			if (MessageBox.Show("Удалить клиента? Все заказы этого клиента также будут удалены!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var client = GetClient(id)!;
			var orders = Orders.Where(o => o.Client.ClientID == client.ClientID).ToList();
			foreach (var order in orders)
				Orders.Remove(order);

			if (Clients.Remove(client))
				MessageBox.Show("Клиент удален!", "Успех");
			else
				MessageBox.Show("Клиент не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public Client? GetClient(Guid id)
		{
			return Clients.FirstOrDefault(client => client.ClientID == id);
		}
		#endregion

		#region Products Methods
		public void AddProduct()
		{
			using var form = new ProductForm(this);
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				Products.Add(data!);
				MessageBox.Show("Товар добавлен!", "Успех");
			}
		}
		public void EditProduct(Guid id)
		{
			using var form = new ProductForm(this);
			form.SetData(GetProduct(id)!);
			form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
				MessageBox.Show("Данные товара изменены!", "Успех");
		}
		public void RemoveProduct(Guid id)
		{
			if (MessageBox.Show("Удалить товар? Он будет также удален из заказов и у поставщиков!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var product = GetProduct(id)!;
			foreach (var order in Orders)
				order.Items.RemoveAll(i => i.Product.ProductID == product.ProductID);
			foreach (var order in SupplierOrders)
				order.Items.RemoveAll(i => i.Product.ProductID == product.ProductID);
			foreach (var supplier in Suppliers)
				supplier.SuppliedProducts.Remove(product);

			if (Products.Remove(product))
				MessageBox.Show("Товар удален!", "Успех");
			else
				MessageBox.Show("Товар не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public Product? GetProduct(Guid id)
		{
			return Products.FirstOrDefault(product => product.ProductID == id);
		}
		public void RefreshProductsData(DataGridView productsDataGrid)
		{
			productsDataGrid.Rows.Clear();

			foreach (var product in Products)
				productsDataGrid.Rows.Add(product.ProductID, product.Name, product.Price, Warehouse.GetStock(product));
		}
		#endregion

		#region Orders Methods
		public void AddOrder()
		{
			using var form = new OrderForm(this);
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				Orders.Add(data!);
				data!.Client.Orders.Add(data);

				MessageBox.Show("Заказ добавлен!", "Успех");
			}
		}
		public void EditOrder(Guid id)
		{
			using var form = new OrderForm(this);
			form.SetData(GetOrder(id)!);
			var client = GetOrder(id)!.Client;
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				if (client != data!.Client)
				{
					client.Orders.Remove(data);
					data.Client.Orders.Add(data);
				}

				MessageBox.Show("Данные заказа изменены!", "Успех");
			}
		}
		public void RemoveOrder(Guid id)
		{
			if (MessageBox.Show("Удалить заказ? У клиентов этот заказ также будет удален!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var order = GetOrder(id)!;
			foreach (var client in Clients)
				client.Orders.Remove(order);

			if (Orders.Remove(order))
				MessageBox.Show("Заказ удален!", "Успех");
			else
				MessageBox.Show("Заказ не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public void CompleteOrder(Guid id)
		{
			if (MessageBox.Show("Завершить заказ? Товары со склада будут выданы клиенту!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var order = GetOrder(id)!;

			if (order.CanBeCompleted(Warehouse))
			{
				order.Status = OrderStatus.Completed;
				foreach (var item in order.Items)
					Warehouse.RemoveProduct(item.Product, item.Quantity);
			}
			else
				MessageBox.Show("Заказ не удалось завершить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		public void GenerateInvoice(Guid id)
		{
			var order = GetOrder(id)!;
			var filePath = Path.Combine("Invoices", $"{id}.docx");

			if (order.Status != OrderStatus.Completed)
			{
				MessageBox.Show("Завершите заказ для формирования счета!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using var doc = DocX.Create(filePath);
			doc.InsertParagraph("Счет на оплату")
				.FontSize(20d)
				.Bold()
				.Alignment = Alignment.center;

			var table = doc.InsertTable(order.Items.Count + 1, 3);
			table.Rows[0].Cells[0].Paragraphs.First().Append("Товар");
			table.Rows[0].Cells[1].Paragraphs.First().Append("Количество");
			table.Rows[0].Cells[2].Paragraphs.First().Append("Сумма");

			for (int i = 0; i < order.Items.Count; i++)
			{
				table.Rows[i + 1].Cells[0].Paragraphs.First().Append(order.Items[i].Product.Name);
				table.Rows[i + 1].Cells[1].Paragraphs.First().Append(order.Items[i].Quantity.ToString());
				table.Rows[i + 1].Cells[2].Paragraphs.First().Append(order.Items[i].TotalPrice.ToString("C2"));
			}

			doc.Save();
		}
		public Order? GetOrder(Guid id)
		{
			return Orders.FirstOrDefault(order => order.OrderID == id);
		}
		#endregion

		#region Suppliers Methods
		public void AddSupplier()
		{
			using var form = new SupplierForm(this);
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				Suppliers.Add(data!);
				MessageBox.Show("Поставщик добавлен!", "Успех");
			}
		}
		public void EditSupplier(Guid id)
		{
			using var form = new SupplierForm(this);
			form.SetData(GetSupplier(id)!);
			form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
				MessageBox.Show("Данные поставщика изменены!", "Успех");
		}
		public void RemoveSupplier(Guid id)
		{
			if (MessageBox.Show("Удалить поставщика? Все связанные заказы также будут удалены!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var supplier = GetSupplier(id)!;
			var orders = SupplierOrders.Where(o => o.Supplier.SupplierID == supplier.SupplierID).ToList();
			foreach (var order in orders)
				SupplierOrders.Remove(order);

			if (Suppliers.Remove(supplier))
				MessageBox.Show("Поставщик удален!", "Успех");
			else
				MessageBox.Show("Поставщик не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public Supplier? GetSupplier(Guid id)
		{
			return Suppliers.FirstOrDefault(supplier => supplier.SupplierID == id);
		}
		#endregion

		#region Supplier Orders Methods
		public void AddSupplierOrder()
		{
			using var form = new SupplierOrderForm(this);
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
			{
				SupplierOrders.Add(data!);

				MessageBox.Show("Заказ добавлен!", "Успех");
			}
		}
		public void EditSupplierOrder(Guid id)
		{
			using var form = new SupplierOrderForm(this);
			form.SetData(GetSupplierOrder(id)!);
			var data = form.ShowDialogAndGetResult();

			if (form.DialogResult == DialogResult.OK)
				MessageBox.Show("Данные заказа изменены!", "Успех");
		}
		public void RemoveSupplierOrder(Guid id)
		{
			if (MessageBox.Show("Удалить заказ?", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var order = GetSupplierOrder(id);

			if (SupplierOrders.Remove(order!))
				MessageBox.Show("Заказ удален!", "Успех");
			else
				MessageBox.Show("Заказ не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public void CompleteSupplierOrder(Guid id)
		{
			if (MessageBox.Show("Завершить заказ? Товары будут добавлены на склад!", "Подтвердить действие",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			var order = GetSupplierOrder(id)!;

			if (order.CanBeCompleted())
			{
				order.Status = OrderStatus.Completed;
				foreach (var item in order.Items)
					Warehouse.AddProduct(item.Product, item.Quantity);
			}
			else
				MessageBox.Show("Заказ не удалось завершить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		public SupplierOrder? GetSupplierOrder(Guid id)
		{
			return SupplierOrders.FirstOrDefault(order => order.OrderID == id);
		}
		#endregion

		#region Analytics Methods
		public class AnalyticsResult
		{
			public Dictionary<Guid, (int Purchased, int Sold)> ProductStats { get; set; } = new();
			public decimal Profit { get; set; }
			public List<Product> TopProducts { get; set; } = new();
		}
		public AnalyticsResult AnalyzePeriods(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
		{
			var result = new AnalyticsResult();

			var period1Data = CalculatePeriodData(start1, end1);
			var period2Data = CalculatePeriodData(start2, end2);

			// Сопоставление объемов
			result.ProductStats = ComparePeriods(period1Data, period2Data);

			result.TopProducts = GetTopProducts(start1, end1, 3);

			result.Profit = CalculateProfit(start1, end1);

			return result;
		}
		private Dictionary<Guid, (int Purchased, int Sold)> ComparePeriods(Dictionary<Guid, int> period1, Dictionary<Guid, int> period2)
		{
			var comparison = new Dictionary<Guid, (int, int)>();

			foreach (var product in Products)
			{
				period1.TryGetValue(product.ProductID, out var p1);
				period2.TryGetValue(product.ProductID, out var p2);
				comparison[product.ProductID] = (p1, p2);
			}

			return comparison;
		}
		private Dictionary<Guid, int> CalculatePeriodData(DateTime start, DateTime end)
		{
			var data = new Dictionary<Guid, int>();

			// Продажи
			foreach (var order in Orders.Where(o => o.OrderDate >= start && o.OrderDate <= end))
				foreach (var item in order.Items)
					data[item.Product.ProductID] = data.GetValueOrDefault(item.Product.ProductID) + item.Quantity;

			// Закупки
			foreach (var supplierOrder in SupplierOrders.Where(so => so.OrderDate >= start && so.OrderDate <= end))
				foreach (var item in supplierOrder.Items)
					data[item.Product.ProductID] = data.GetValueOrDefault(item.Product.ProductID) - item.Quantity;

			return data;
		}
		public List<Product> GetTopProducts(DateTime start, DateTime end, int topCount)
		{
			var productSales = new Dictionary<Guid, int>();

			foreach (var order in Orders.Where(o => o.OrderDate >= start && o.OrderDate <= end))
			{
				foreach (var item in order.Items)
				{
					productSales[item.Product.ProductID] =
						productSales.GetValueOrDefault(item.Product.ProductID) + item.Quantity;
				}
			}

			return productSales
				.OrderByDescending(kvp => kvp.Value)
				.Take(topCount)
				.Select(kvp => Products.First(p => p.ProductID == kvp.Key))
				.ToList();
		}
		public decimal CalculateProfit(DateTime start, DateTime end)
		{
			decimal income = Orders
				.Where(o => o.OrderDate >= start && o.OrderDate <= end)
				.Sum(o => o.TotalCost);

			decimal expenses = SupplierOrders
				.Where(so => so.OrderDate >= start && so.OrderDate <= end)
				.Sum(so => so.TotalCost);

			return income - expenses;
		}
		#endregion

	}
}
