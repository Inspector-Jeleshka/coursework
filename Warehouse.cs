using Newtonsoft.Json;

namespace coursework
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Warehouse
	{
		public Warehouse() { }
		public Warehouse(Dictionary<Product, int> stock)
		{
			Stock = stock;
		}

		[JsonProperty]
		[JsonConverter(typeof(ProductDictionaryConverter))]
		public Dictionary<Product, int> Stock { get; set; } = new();

		public void AddProduct(Product product, int quantity)
		{
			if (quantity <= 0)
				throw new ArgumentOutOfRangeException(nameof(quantity), "Меньше или равно 0");

			if (!Stock.TryAdd(product, quantity))
				Stock[product] += quantity;
		}
		public bool RemoveProduct(Product product, int quantity)
		{
			if (quantity <= 0)
				throw new ArgumentOutOfRangeException(nameof(quantity), "Меньше или равно 0");

			if (Stock.TryGetValue(product, out int value) && value >= quantity)
			{
				Stock[product] -= quantity;

				if (Stock[product] == 0)
					Stock.Remove(product);

				return true;
			}
			return false;
		}
		public int GetStock(Product product)
		{
			return Stock.TryGetValue(product, out int value) ? value : 0;
		}
	}
}
