using System.Collections.ObjectModel;

namespace coursework
{
	public class Warehouse
	{
		private static readonly List<Warehouse> warehouses = new();

		private readonly Guid warehouseID = Guid.NewGuid();
		private string address = string.Empty;
		private decimal balance;
		private readonly Dictionary<Guid, int> products = new();
		private readonly List<Guid> orders = new();


		public Warehouse(string address, decimal balance = 0m)
		{
			Address = address;
			Balance = balance;
			warehouses.Add(this);
		}


		public static ReadOnlyCollection<Warehouse> Warehouses => new(warehouses);

		public Guid WarehouseID => warehouseID;
		public string Address
		{
			get => address;
			set => address = value;
		}
		public decimal Balance
		{
			get => balance;
			set => balance = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Less than 0");
		}
		public ReadOnlyDictionary<Guid, int> Products => new(products);
		public ReadOnlyCollection<Guid> Orders => new(orders);


		public void AddBalance(decimal amount)
		{
			balance += amount > 0 ? amount : throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");
		}
		public void AddProduct(Guid productID, int amount)
		{
			if (Product.GetProduct(productID) == null)
				throw new ArgumentException("Incorrect ID", nameof(productID));
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");

			if (!products.TryAdd(productID, amount))
				products[productID] += amount;
		}
		public void RemoveProduct(Guid productID, int amount)
		{
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");

			products[productID] -= amount;

			if (products[productID] == 0)
				products.Remove(productID);
		}
		public void SetProduct(Guid productID, int amount)
		{
			if (amount < 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less than 0");

			products[productID] = amount;

			if (products[productID] == 0)
				products.Remove(productID);
		}
	}
}
