using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables
{

    /// <summary>
    /// Indicates how a <see cref="ServerSideRequest"/>'s search value should be handled for server side processing.
    /// </summary>
    [JsonObject]
    public class Search
    {

        /// <summary>
        /// Whether or not <see cref="Value"/> should be treated as a regular expression for advanced searching.
        /// </summary>
        /// <value><c>true</c> if <see cref="Value"/> should be treated as a regular expression for advanced searching, <c>false</c> otherwise.</value>
        [JsonProperty("regex")]
        public bool Regex { get; set; }

        /// <summary>
        /// Global search value.
        /// </summary>
        /// <remarks>
        /// To be applied to all columns which have <c>searchable</c> as <c>true</c>.
        /// </remarks>
        /// <value>Global search value.</value>
        [JsonProperty("value")]
        public string Value { get; set; }

    }

}