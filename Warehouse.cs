namespace coursework
{
	public class Warehouse
	{
		public Guid WarehouseID { get; } = Guid.NewGuid();
		public string Address { get; set; }
		public int Balance { get; set; }
		public Dictionary<Guid, int> Products { get; set; }
	}
}
