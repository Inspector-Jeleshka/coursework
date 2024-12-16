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

        public static Client? GetClient(Guid clientID)
        {
			return clients.Find(client => client.clientID == clientID);
		}

        public void PayOrder(Guid orderID, decimal amount)
        {
            if (amount <= 0 || amount > balance)
                throw new ArgumentOutOfRangeException(nameof(amount));
            if (!orders.Contains(orderID))
                throw new ArgumentException("Not your order", nameof(orderID));
            
            Order order = Order.GetOrder(orderID) ?? throw new ArgumentException("Incorrect ID", nameof(orderID));
            decimal availableAmount = order.TotalCost - order.PaidCost;

            if (amount > availableAmount)
                amount = availableAmount;

            balance -= amount;
            order.MakePayment(amount);
        }
        public void AddBalance(decimal amount)
        {
            balance += amount > 0 ? amount : throw new ArgumentOutOfRangeException(nameof(amount), "Less or equal to 0");
        }
	}
}
