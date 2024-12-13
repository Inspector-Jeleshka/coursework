using System.Collections.ObjectModel;

namespace coursework
{
    public class Product : ICloneable
    {
        private static readonly List<Product> products = new();

        private readonly Guid productID = Guid.NewGuid();
        private string name = string.Empty;
        private decimal price;

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            products.Add(this);
        }

        public static ReadOnlyCollection<Product> Products => new(products);
        public Guid ProductID => productID;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public decimal Price
        {
            get => price;
            set => price = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Less or equal to 0");
        }

        public static Product GetProduct(string name, decimal price)
        {
            return products.Find(product => product.Name == name && product.Price == price) ?? new Product(name, price);
        }
        public static Product? GetProduct(Guid productID)
        {
            return products.Find(product => product.ProductID == productID);
		}

        public Product Clone()
        {
            return (Product)MemberwiseClone();
        }

		object ICloneable.Clone()
		{
            return Clone();
		}
	}
}
