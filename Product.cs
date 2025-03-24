using Newtonsoft.Json;

namespace coursework
{
	[JsonObject(IsReference = true)]
	public class Product
	{
		private decimal price;

		public Product() { }
		public Product(string name, decimal price)
		{
			ProductID = Guid.NewGuid();
			Name = name;
			Price = price;
		}

		[JsonProperty] public Guid ProductID { get; set; }
		[JsonProperty] public string Name { get; set; }
		[JsonProperty] public decimal Price
		{
			get => price;
			set => price = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(Price), "Меньше или равно 0");
		}
	}
}
