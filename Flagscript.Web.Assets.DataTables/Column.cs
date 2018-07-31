using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables
{

    /// <summary>
    /// Column.
    /// </summary>
    public class Column
    {

        /// <summary>
        /// Column's data source, as defined by <c>columns.data</c>.
        /// </summary>
        /// <value>Column's data source, as defined by <c>columns.data</c>.</value>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// Column's data source, as defined by <c>columns.name</c>.
        /// </summary>
        /// <value>Column's data source, as defined by <c>columns.name</c>.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Flag to indicate if this column is orderable (<c>true</c>) or not (<c>false</c>).
        /// </summary>
        /// <remarks>This is controlled by <c>columns.orderable Option.</c></remarks>
        /// <value>Flag to indicate if this column is orderable (<c>true</c>) or not (<c>false</c>).</value>
        [JsonProperty("orderable")]
        public bool Orderable { get; set; }

        /// <summary>
        /// Specific search value for this column.
        /// </summary>
        /// <value>Specific search value for this column.</value>
        [JsonProperty("search")]
        public Search Search { get; set; }

        /// <summary>
        /// Flag to indicate if this column is searchable (<c>true</c>) or not (<c>false</c>).
        /// </summary>
        /// <remarks>
        /// This is controlled by <c>columns.searchable option</c>.
        /// </remarks>
        /// <value><c>true</c> if searchable; otherwise, <c>false</c>.</value>
        [JsonProperty("searchable")]
        public bool Searchable { get; set; }

    }

}