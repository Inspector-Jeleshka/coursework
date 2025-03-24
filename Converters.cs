using Newtonsoft.Json;

namespace coursework
{
	public class ProductDictionaryConverter : JsonConverter<Dictionary<Product, int>>
	{
		public override void WriteJson(JsonWriter writer, Dictionary<Product, int> value, JsonSerializer serializer)
		{
			var converted = new Dictionary<Guid, int>();
			foreach (var kvp in value)
				if (kvp.Key != null)
					converted[kvp.Key.ProductID] = kvp.Value;

			serializer.Serialize(writer, converted);
		}

		public override Dictionary<Product, int> ReadJson(JsonReader reader, Type objectType,
			Dictionary<Product, int> existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			try
			{
				var temp = serializer.Deserialize<Dictionary<Guid, int>>(reader)
					?? new Dictionary<Guid, int>();

				if (!(serializer.Context.Context is List<Product> products))
					return new Dictionary<Product, int>();


				var result = new Dictionary<Product, int>();
				foreach (var kvp in temp)
				{
					var product = products.FirstOrDefault(p => p.ProductID == kvp.Key);
					if (product == null)
						continue;

					result[product] = kvp.Value;
				}

				return result;
			}
			catch (Exception ex)
			{
				return new Dictionary<Product, int>();
			}
		}
	}
}
