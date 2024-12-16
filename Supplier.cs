using System.Collections.ObjectModel;

namespace coursework
{
	public class Supplier
	{
		private static readonly List<Supplier> suppliers = new();
		
		private readonly Guid supplierID = Guid.NewGuid();
		//private string name = string.Empty;


		public Supplier(string name)
		{
			Name = name;
			suppliers.Add(this);
		}


		public static ReadOnlyCollection<Supplier> Suppliers => new(suppliers);

		public Guid SupplierID => supplierID;
		public string Name { get; set; } = string.Empty;
	}
}
