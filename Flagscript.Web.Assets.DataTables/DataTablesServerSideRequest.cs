using System.Collections.Generic;

using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables
{

    /// <summary>
    /// Server side request.
    /// </summary>
    public class DataTablesServerSideRequest
    {

        /// <summary>
        /// Draw counter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables 
        /// (Ajax requests are asynchronous and thus can return out of sequence).
        /// </para>
        /// <para>
        /// This is used as part of the <see cref="DataTablesServerSideResponse{T}.Draw"/> return parameter.
        /// </para>
        /// </remarks>
        /// <value>Draw counter.</value>
        [JsonProperty("draw")]
        public int Draw { get; set; }

        /// <summary>
        /// Number of records that the table can display in the current draw.
        /// </summary>
        /// <remarks>
        /// <para>It is expected that the number of records returned will be equal to this number, unless the server has fewer records to return.</para>
        /// <para>Note that this can be -1 to indicate that all records should be returned (although that negates any benefits of server-side processing!).</para>
        /// </remarks>
        /// <value>Number of records that the table can display in the current draw.</value>
        [JsonProperty("length")]
        public int Length { get; set; }

        /// <summary>
        /// An array defining how many columns are being ordered upon.
        /// </summary>
        /// <remarks>
        /// if the array length is 1, then a single column sort is being performed, otherwise a multi-column sort is being performed.
        /// </remarks>
        /// <value>An array defining how many columns are being ordered upon.</value>
        [JsonProperty("order")]
        public DataTablesColumnOrder[] Order { get; set; }

        /// <summary>
        /// How the results in <see cref="ServerSideResult{T}"/> should be filtered for user search.
        /// </summary>
        /// <value>How the results in <see cref="ServerSideResult{T}"/> should be filtered for user search.</value>
        [JsonProperty("search")]
        public DataTablesSearch Search { get; set; }

        /// <summary>
        /// Paging first record indicator.
        /// </summary>
        /// <remarks>
        /// This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </remarks>
        /// <value>Paging first record indicator.</value>
        [JsonProperty("start")]
        public int Start { get; set; }

    }

}