using System.Collections.ObjectModel;

namespace coursework
{
    public class Order
    {
        private static readonly List<Order> orders = new();
        
        private readonly Guid orderID = Guid.NewGuid();
        private readonly Dictionary<Guid, int> products = new();
        private readonly Guid customerID;
        private readonly Guid senderID;
        private PaymentType payment;
        private bool requiresDelivery;
        private decimal totalCost;
        private decimal paidCost;
        private OrderStatus status = OrderStatus.Open;


        public Order(Guid customerID, Guid senderID)
        {
            this.customerID = customerID;
            foreach (var product in products)
                AddProduct(product.Key, product.Value);
            Payment = payment;
            RequiresDelivery = requiresDelivery;
            orders.Add(this);
        }


        public enum PaymentType { Full, Partial }
        public enum OrderStatus { Open, Processing, Closed }


        public static ReadOnlyCollection<Order> Orders => new(orders);
        public Guid OrderID => orderID;
        public ReadOnlyDictionary<Guid, int> Products => new(products);
        public Guid CustomerID => customerID;
        public Guid SenderID => senderID;
        public PaymentType Payment
        {
            get => payment;
            set => payment = status == OrderStatus.Open ? value :
				throw new InvalidOperationException($"{nameof(Payment)} can be changed only for open order");
		}
        public bool RequiresDelivery
        {
            get => requiresDelivery;
            set => requiresDelivery = status == OrderStatus.Open ? value :
                throw new InvalidOperationException($"{nameof(RequiresDelivery)} can be changed only for open order");
        }
        public decimal TotalCost => totalCost;
        public decimal PaidCost => paidCost;
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
            if (status != OrderStatus.Open)
                throw new InvalidOperationException($"Incorrect {nameof(Status)} value");

            if (!products.TryAdd(productID, amount))
                products[productID] += amount;

            totalCost += Product.GetProduct(productID)!.Price * amount;
		}
        public void RemoveProduct(Guid productID, int amount)
        {
            if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");
			if (status != OrderStatus.Open)
				throw new InvalidOperationException($"Incorrect {nameof(Status)} value");

			products[productID] -= amount;

            if (products[productID] == 0)
                products.Remove(productID);

            totalCost -= Product.GetProduct(productID)!.Price * amount;
        }
        public void SetProduct(Guid productID, int amount)
        {
			if (amount < 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Less than 0");
			if (status != OrderStatus.Open)
				throw new InvalidOperationException($"Incorrect {nameof(Status)} value");

			int oldAmount = products[productID];
            products[productID] = amount;

            if (products[productID] == 0)
                products.Remove(productID);

            totalCost += Product.GetProduct(productID)!.Price * (amount - oldAmount);
		}
		public decimal CalculateStorageFee(int days)
        {
            return days > 5 ? totalCost * (days - 5) * 0.02m : 0;
        }
        public void ProcessOrder()
        {
            if (status != OrderStatus.Open)
                throw new InvalidOperationException($"Incorrect {nameof(Status)} value");
            if (paidCost == 0)
                throw new InvalidOperationException($"Incorrect {nameof(PaidCost)} value");

            status = OrderStatus.Processing;
        }
        public void CloseOrder()
        {
            if (status != OrderStatus.Processing)
                throw new InvalidOperationException($"Incorrect {nameof(Status)} value");
			if (totalCost != paidCost)
				throw new InvalidOperationException($"{nameof(PaidCost)} isn't equal to {nameof(TotalCost)}");

            status = OrderStatus.Closed;
		}
        public void MakePayment(decimal amount)
        {
            if (amount <= 0 || amount + paidCost > totalCost)
                throw new ArgumentOutOfRangeException(nameof(amount));

            paidCost += amount;
        }
    }
}
