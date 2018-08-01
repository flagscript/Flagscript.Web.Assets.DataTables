using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flagscript.Web.Assets.DataTables
{

	/// <summary>
	/// 
	/// </summary>
	public class DataTablesRowJsonConverter : JsonConverter<DataTablesRow>
	{

		/// <summary>
		/// Row class to add to every <c><tr /></c> tag.
		/// </summary>
		/// <value>Row class to add every <c><tr /></c> tag.</value>
		public string GlobalRowClass { get; private set; }

		/// <summary>
		/// Whether or not to use object notion for the array response.
		/// </summary>
		/// <value>Whether or not to use object notion for the array response.</value>
		public bool UseObjectDataSource { get; private set; }

		/// <summary>
		/// Whether or not this converter can read JSON. Always false.
		/// </summary>
		/// <value><c>false</c>.</value>
		public override bool CanRead => false;

		/// <inheritDoc />
		public override DataTablesRow ReadJson(JsonReader reader, Type objectType, DataTablesRow existingValue, bool hasExistingValue, JsonSerializer serializer)
			=> throw new NotImplementedException("CanRead is false. The type will skip the converter.");

		/// <summary>
		/// Writes the json.
		/// </summary>
		/// <param name="writer">Writer.</param>
		/// <param name="value">Value.</param>
		/// <param name="serializer">Serializer.</param>
		public override void WriteJson(JsonWriter writer, DataTablesRow value, JsonSerializer serializer)
		{
			JObject jsonObject = JToken.FromObject(value) as JObject;

			// Check if the global row class is set
			if (!string.IsNullOrWhiteSpace(GlobalRowClass))
			{
				// Add to child objects.
			}

			// Write the json
			jsonObject.WriteTo(writer);

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataTablesRowJsonConverter"/> class with specified settings.
		/// </summary>
		/// <param name="useObjectDataSource">Whether or not to use object notion for the array response.</param>
		/// <param name="globalRowClass">Optional global Row class to add to every <c><tr /></c> tag.</param>
		public DataTablesRowJsonConverter(bool useObjectDataSource = false, string globalRowClass = null)
		{
			UseObjectDataSource = useObjectDataSource;
			GlobalRowClass = globalRowClass;
		}

	}

}
