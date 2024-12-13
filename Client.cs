using System.Collections.ObjectModel;

namespace coursework
{
    public class Client
    {
        private static readonly List<Client> clients = new();

        private readonly Guid clientID = Guid.NewGuid();
        private string name = string.Empty;
        private string contactInfo = string.Empty;
        private decimal balance;
        private readonly List<Guid> orders = new();


		public Client(string name, string contactInfo, decimal balance = 0m)
        {
            Name = name;
            ContactInfo = contactInfo;
            Balance = balance;
            clients.Add(this);
        }


        public static ReadOnlyCollection<Client> Clients => new(clients);
		public Guid ClientID => clientID;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string ContactInfo
        {
            get => contactInfo;
            set => contactInfo = value;
        }
        public decimal Balance
        {
            get => balance;
            set => balance = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Less than 0");
        }


        public void AddOrder(Dictionary<Guid, int> products)
        {
            decimal amountToPay = 0m;
            var payment = Order.PaymentType.Full;

			foreach (Guid productID in products.Keys)
				amountToPay += Product.GetProduct(productID)?.Price * products[productID] ??
                    throw new ArgumentException("Incorrect ID", nameof(products));

            if (balance < amountToPay)
                payment = Order.PaymentType.Partial;

			Order order = new(clientID, products, payment);

            orders.Add(order.OrderID);
        }
        public bool TryPayOrder(Guid orderID, int amount)
        {
            Order order = Order.GetOrder(orderID) ?? throw new ArgumentException("Incorrect ID", nameof(orderID));
            decimal amountToPay = order.TotalCost - order.PaidCost;

            if (balance < amountToPay)
                return false;

            balance -= amountToPay;
            order.PaidCost += amountToPay;

            return true;
        }
	}
}
