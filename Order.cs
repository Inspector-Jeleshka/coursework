using Newtonsoft.Json;

namespace coursework
{
	[JsonObject(IsReference = true)]
	public class Order
	{
		private decimal paidCost = 0;
		private DateTime deliveryDate;

		public Order() { }
		public Order(Client client, DateTime orderDate)
		{
			OrderID = Guid.NewGuid();
			Client = client;
			OrderDate = orderDate;
		}

		[JsonProperty] public Guid OrderID { get; set; }
		[JsonProperty] public Client Client { get; set; }
		[JsonProperty] public DateTime OrderDate { get; set; }
		[JsonProperty] public DateTime DeliveryDate
		{
			get => deliveryDate;
			set => deliveryDate = value >= OrderDate ? value
				: throw new ArgumentException("Дата доставки не может быть раньше даты заказа.", nameof(DeliveryDate));
		}
		[JsonProperty] public List<OrderItem> Items { get; set; } = new();
		[JsonProperty] public OrderStatus Status { get; set; } = OrderStatus.Draft;
		[JsonIgnore] public decimal TotalCost => Items.Sum(i => i.TotalPrice);
		[JsonProperty] public decimal PaidCost
		{
			get => paidCost;
			set => paidCost = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(PaidCost), "Меньше 0");
		}
		[JsonIgnore] public bool IsPaid => PaidCost >= TotalCost + StorageCost;
		[JsonProperty] public bool RequiresDelivery { get; set; } = false;
		[JsonProperty] public bool IsDeliveryPaid { get; set; } = false;
		[JsonIgnore] public decimal StorageCost
		{
			get
			{
				DateTime currentDate = DateTime.Now;
				if (!RequiresDelivery && currentDate > DeliveryDate.AddDays(5))
				{
					int daysOverdue = (currentDate - DeliveryDate.AddDays(5)).Days;
					return TotalCost * daysOverdue * 0.02m;
				}
				return 0;
			}
		}

		public bool CanBeCompleted(Warehouse warehouse)
		{
			return (Status == OrderStatus.Processing) && IsPaid && (RequiresDelivery == IsDeliveryPaid) && CanBeFulfilled(warehouse);
		}
		public bool CanBeFulfilled(Warehouse warehouse)
		{
			foreach (var item in Items)
				if (warehouse.GetStock(item.Product) < item.Quantity)
					return false;

			return true;
		}
	}

	public enum OrderStatus { Draft, Processing, Completed }

	[JsonObject(IsReference = true)]
	public class OrderItem
	{
		private int quantity;

		public OrderItem() { }
		public OrderItem(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
		public OrderItem(OrderItem other)
		{
			Product = other.Product;
			Quantity = other.Quantity;
		}

		[JsonProperty] public Product Product { get; set; }
		[JsonProperty] public int Quantity
		{
			get => quantity;
			set => quantity = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(Quantity), "Меньше или равно 0");
		}
		[JsonIgnore] public decimal TotalPrice => Product.Price * Quantity;
	}

	[JsonObject(IsReference = true)]
	public class SupplierOrder
	{
		private DateTime deliveryDate;

		public SupplierOrder() { }
		public SupplierOrder(Supplier supplier, DateTime orderDate)
		{
			OrderID = Guid.NewGuid();
			Supplier = supplier;
			OrderDate = orderDate;
		}

		[JsonProperty] public Guid OrderID { get; set; }
		[JsonProperty] public Supplier Supplier { get; set; }
		[JsonProperty] public DateTime OrderDate { get; set; }
		[JsonProperty] public DateTime ExpectedDeliveryDate
		{
			get => deliveryDate;
			set => deliveryDate = value >= OrderDate ? value
				: throw new ArgumentException("Дата доставки не может быть раньше даты заказа.", nameof(ExpectedDeliveryDate));
		}
		[JsonProperty] public List<OrderItem> Items { get; set; } = new();
		[JsonProperty] public OrderStatus Status { get; set; } = OrderStatus.Draft;
		[JsonIgnore] public decimal TotalCost => Items.Sum(i => i.TotalPrice);

		public bool CanBeCompleted()
		{
			return Status == OrderStatus.Processing;
		}
	}
}
