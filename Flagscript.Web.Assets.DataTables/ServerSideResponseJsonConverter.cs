using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flagscript.Web.Assets.DataTables
{

	/// <summary>
	/// <see cref="JsonConverter{T}"/> for <see cref="DataTablesServerSideResponse{T}"/>.
	/// </summary>
	/// <typeparam name="T">The class of the Datatables result row, inheriting <see cref="DataTablesRow"/>.</typeparam>
	public class ServerSideResponseJsonConverter<T> : JsonConverter<DataTablesServerSideResponse<T>> where T : DataTablesRow
	{

        /// <summary>
        /// Whether or not this converter can read JSON. Always false.
        /// </summary>
        /// <value><c>false</c>.</value>
        public override bool CanRead => false;

        /// <inheritDoc />
        public override DataTablesServerSideResponse<T> ReadJson(JsonReader reader, Type objectType, DataTablesServerSideResponse<T> existingValue, bool hasExistingValue, JsonSerializer serializer)
            => throw new NotImplementedException("CanRead is false. The type will skip the converter.");

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">Writer.</param>
        /// <param name="value">Value.</param>
        /// <param name="serializer">Serializer.</param>
        public override void WriteJson(JsonWriter writer, DataTablesServerSideResponse<T> value, JsonSerializer serializer)
        {
            JObject jsonObject = JToken.FromObject(value) as JObject;

            // Check if the global row class is set
            if (!string.IsNullOrWhiteSpace(value.GlobalRowClass))
            {
                // Add to child objects.
            }

            // Write the json
            jsonObject.WriteTo(writer);

        }

    }

}
