using Newtonsoft.Json;

namespace coursework
{
	[JsonObject(IsReference = true)]
	public class Supplier
	{
		public Supplier() { }
		public Supplier(string name, List<Product>? products = null)
		{
			SupplierID = Guid.NewGuid();
			Name = name;
			SuppliedProducts = products ?? new();
		}

		[JsonProperty] public Guid SupplierID { get; set; }
		[JsonProperty] public string Name { get; set; }
		[JsonProperty] public List<Product> SuppliedProducts { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
