using System.Collections.ObjectModel;
using System.Reflection.Metadata;

namespace coursework
{
	public class MainPresenter
	{
		private readonly MainForm view;

		public MainPresenter(MainForm view)
		{
			this.view = view ?? throw new ArgumentNullException(nameof(view));
		}

		public ReadOnlyCollection<Client> Clients => Client.Clients;
		public ReadOnlyCollection<Product> Products => Product.Products;
		public ReadOnlyCollection<Warehouse> Warehouses => Warehouse.Warehouses;
		public ReadOnlyCollection<Order> Orders => Order.Orders;
		public ReadOnlyCollection<Supplier> Suppliers => Supplier.Suppliers;

		public void LoadData()
		{
			//load saved data
		}
		public void AddClient()
		{
			string[] textBoxLabels = new string[] { "Имя", "Контактные данные", "Баланс" };
			
			using var addClientForm = new AddForm(3, textBoxLabels);
			addClientForm.ShowDialog();

			if (addClientForm.DialogResult == DialogResult.Cancel)
				return;

			try
			{
				string name = addClientForm.Result[0];
				string contactInfo = addClientForm.Result[1];
				decimal balance = decimal.Parse(addClientForm.Result[2]);

				Client newClient = new(name, name, balance);
				MessageBox.Show("Клиент добавлен!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
			}
		}
		public void SetClient(DataGridViewRow clientRow)
		{
			string[] textBoxLabels = new string[] { "Имя", "Контактные данные", "Баланс" };
			
			Guid clientID = (Guid)clientRow.Cells[0].Value;
			Client client = Client.GetClient(clientID)!;
			string[] clientsData = new string[] { client.Name, client.ContactInfo, client.Balance.ToString() };

			using var setClientForm = new AddForm(3, textBoxLabels, clientsData);
			setClientForm.ShowDialog();

			if (setClientForm.DialogResult == DialogResult.Cancel)
				return;

			try
			{
				client.Name = setClientForm.Result[0];
				client.ContactInfo = setClientForm.Result[1];
				client.Balance = decimal.Parse(setClientForm.Result[2]);

				MessageBox.Show("Клиент изменен!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
			}
		}
	}
}
