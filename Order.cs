namespace coursework
{
	public class Order
	{
		//WIP
		Product Product { get; set; }
		//WIP
		PaymentType Payment { get; set; }
		//WIP, object = Client | Organization
		object Customer { get; set; }
		//WIP
		bool RequiresDelivery { get; set; }

		enum PaymentType { Full, Partial }
	}
}
