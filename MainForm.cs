using System.Drawing.Design;

namespace coursework
{
	public partial class MainForm : Form
	{
		private readonly MainPresenter presenter;

		public MainForm()
		{
			InitializeComponent();

			presenter = new MainPresenter(this);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			presenter.LoadData();

			clientsDataGrid.DataSource = presenter.Clients;
			warehousesDataGrid.DataSource = presenter.Warehouses;
			productsDataGrid.DataSource = presenter.Products;
			ordersDataGrid.DataSource = presenter.Orders;
			suppliersDataGrid.DataSource = presenter.Products;
		}

		private void addClientButton_Click(object sender, EventArgs e)
		{
			presenter.AddClient();
			clientsDataGrid.DataSource = presenter.Clients;
		}

		private void setClientButton_Click(object sender, EventArgs e)
		{
			if (clientsDataGrid.CurrentRow == null)
			{
				MessageBox.Show("Выберите клиента");
				return;
			}

			var currentRow = clientsDataGrid.CurrentRow;
			int currentRowIndex = currentRow.Index;

			presenter.SetClient(currentRow);
			clientsDataGrid.DataSource = presenter.Clients;
			clientsDataGrid.CurrentCell = clientsDataGrid.Rows[currentRowIndex].Cells[0];
		}
	}
}
