using System.Collections.ObjectModel;

namespace coursework
{
    public class Order
    {
        private static readonly List<Order> orders = new();
        
        private readonly Guid orderID = Guid.NewGuid();
        private readonly Dictionary<Guid, int> products = new();
        private readonly Guid customerID;
        private decimal totalCost;
        private decimal paidCost;
        private OrderStatus status = OrderStatus.Open;


        public Order(Guid customerID, Dictionary<Guid, int> products, PaymentType payment, bool requiresDelivery = false)
        {
            this.customerID = customerID;
            foreach (var product in products)
                AddProduct(product.Key, product.Value);
            Payment = payment;
            RequiresDelivery = requiresDelivery;
            orders.Add(this);
        }


        public enum PaymentType { Full, Partial }
        public enum OrderStatus { Open, Closed }


        public static ReadOnlyCollection<Order> Orders => new(orders);
        public Guid OrderID => orderID;
        public ReadOnlyDictionary<Guid, int> Products => new(products);
        public Guid CustomerID => customerID;
        public PaymentType Payment { get; init; }
        public bool RequiresDelivery { get; init; } = false;
        public decimal TotalCost => totalCost;
        public decimal PaidCost
        {
            get => paidCost;
            set => paidCost = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Less than 0");
        }
        public OrderStatus Status => status;


        public static Order? GetOrder(Guid orderID)
        {
            return orders.Find(order => order.orderID == orderID);
        }

        private void CalculateTotalCost()
        {
            totalCost = 0;

            foreach (Guid productID in products.Keys)
                totalCost += Product.GetProduct(productID)!.Price * products[productID];
        }
        public void AddProduct(Guid productID, int amount)
        {
            if (Product.GetProduct(productID) == null)
                throw new ArgumentException("Incorrect ID", nameof(productID));
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");

            if (!products.TryAdd(productID, amount))
                products[productID] += amount;

            CalculateTotalCost();
		}
        public void RemoveProduct(Guid productID, int amount)
        {
            if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");

            products[productID] -= amount;

            if (products[productID] == 0)
                products.Remove(productID);

            CalculateTotalCost();
        }
        public void SetProduct(Guid productID, int amount)
        {
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");

            products[productID] = amount;

            CalculateTotalCost();
		}
		public decimal CalculateStorageFee(int days)
        {
            return days > 5 ? totalCost * (days - 5) * 0.02m : 0;
        }
        public void CloseOrder()
        {
            if (status == OrderStatus.Closed)
                throw new InvalidOperationException("Order is already closed");
			if (totalCost != paidCost)
				throw new InvalidOperationException($"{nameof(PaidCost)} isn't equal to {nameof(TotalCost)}");

            status = OrderStatus.Closed;
		}
    }
}
