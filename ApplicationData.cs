namespace coursework
{
	public class ApplicationData
	{
		public List<Client> Clients { get; set; } = new();
		public List<Product> Products { get; set; } = new();
		public List<Order> Orders { get; set; } = new();
		public List<Supplier> Suppliers { get; set; } = new();
		public List<SupplierOrder> SupplierOrders { get; set; } = new();
		public Warehouse Warehouse { get; set; } = new();
	}
}
