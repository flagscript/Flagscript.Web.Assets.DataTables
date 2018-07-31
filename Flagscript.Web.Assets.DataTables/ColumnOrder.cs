using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables
{

    /// <summary>
    /// Indicates how a <see cref="ServerSideResult{T}.Data"/> response should be queried and ordered.
    /// </summary>
    public class ColumnOrder
    {

        /// <summary>
        /// Column to which ordering should be applied.
        /// </summary>
        /// <remarks>
        /// This is an index reference to the <see cref="ServerSideRequest.Order"/> array of information that is also submitted to the server.
        /// </remarks>
        /// <value>Column to which ordering should be applied.</value>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// Ordering direction for this column.
        /// </summary>
        /// <remarks>
        /// It will be <c>asc</c> or <c>desc</c> to indicate ascending ordering or descending ordering, respectively.
        /// </remarks>
        /// <value>Ordering direction for this column.</value>
        [JsonProperty("order")]
        public ColumnOrder Order { get; set; }

    }

}