namespace coursework
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void clientsTabPage_Enter(object sender, EventArgs e)
		{
			clientsDataGrid.DataSource = Product.Products;
		}
	}
}
