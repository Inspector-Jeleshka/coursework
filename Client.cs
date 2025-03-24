using Newtonsoft.Json;

namespace coursework
{
	[JsonObject(IsReference = true)]
	public class Client
	{
		public Client() { }
		public Client(string name, string phone, string address)
		{
			ClientID = Guid.NewGuid();
			Name = name;
			Phone = phone;
			Address = address;
		}

		[JsonProperty] public Guid ClientID { get; set; }
		[JsonProperty] public string Name { get; set; }
		[JsonProperty] public string Phone { get; set; }
		[JsonProperty] public string Address { get; set; } = string.Empty;
		[JsonIgnore] public decimal TotalDebt
		{
			get
			{
				var totalDebt = 0m;
				foreach (var order in Orders)
					if (order.Status == OrderStatus.Processing)
						totalDebt += order.TotalCost - order.PaidCost + order.StorageCost;
				return totalDebt;
			}
		}
		[JsonProperty] public List<Order> Orders { get; set; } = new();

		public override string ToString()
		{
			return Name;
		}
	}
}
