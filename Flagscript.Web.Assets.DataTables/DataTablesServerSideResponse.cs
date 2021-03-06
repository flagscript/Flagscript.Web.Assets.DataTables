﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables
{

	/// <summary>
	/// Resents a valid JSON response to a DataTables server side processing request.
	/// </summary>
	/// <remarks>
	/// <para>Once DataTables has made a request for data, it expects JSON data to be returned to it, with the members represented by this class set.</para>
	/// <para>View the DataTables documentation at <see cref="!:https://datatables.net/manual/server-side"/></para>
	/// </remarks>
	/// <typeparam name="T">The class of the Datatables result rows, inheriting <see cref="DataTablesRow"/>.</typeparam>
	[JsonObject(MemberSerialization.OptIn)]
    public class DataTablesServerSideResponse<T> where T : DataTablesRow
    {
        
        /// <summary>
        /// Array of data to be displayed in the data table.
        /// </summary>
        /// <remarks>
        /// <para>
        /// An array of data source objects, one for each row, which will be used by DataTables.
        /// </para>
        /// <para>
        /// Note that this parameter's name can be changed using the ajaxDT option's dataSrc property.
        /// </para>
        /// </remarks>
        /// <value>Array of data to be displayed in the data table.</value>
        [JsonProperty("data")]
        public IList<T> Data { get; set; }

        /// <summary>
        /// The draw counter that this object is a response to - from the draw parameter sent as part of the data request.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Should match the draw parameter sent as part of the datatables request.
        /// </para>
        /// <para>
        /// Note that it is strongly recommended for security reasons that you cast this parameter to an integer, rather than simply echoing back
        /// to the client what it sent in the draw parameter, in order to prevent Cross Site Scripting (XSS) attacks.
        /// </para>
        /// <value>The draw counter that this object is a response to.</value>
        [JsonProperty("draw")]
        public int Draw { get; set; }

        /// <summary>
        /// Optional error encountered during the service side processing.
        /// </summary>
        /// <remarks>
        /// If an error occurs during the running of the server-side processing script, you can inform the user of this error by passing back the 
        /// error message to be displayed using this parameter. Do not include if there is no error.
        /// </remarks>
        /// <value>Error encountered during the service side processing..</value>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Total records, before filtering.
        /// </summary>
        /// <remarks>
        /// The total number of records in the database.
        /// </remarks>
        /// <value>Total records, before filtering.</value>
        [JsonProperty("recordsTotal")]
        public int RecordsTotal { get; set; }

        /// <summary>
        /// Total records, after filtering.
        /// </summary>
        /// <remarks>
        /// The total number of records after filtering has been applied - not just the number of records being returned for this page of data.
        /// </remarks>
        /// <value>Total records, after filtering.</value>
        [JsonProperty("recordsFiltered")]
        public int RecordsFiltered { get; set; }

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
		/// Initializes a new instance of the <see cref="DataTablesServerSideResponse{T}"/> class with default settings.
		/// </summary>
		public DataTablesServerSideResponse()
        {
            
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="DataTablesServerSideResponse{T}"/> class with specified settings.
		/// </summary>
		/// <param name="useObjectDataSource">Whether or not to use object notion for the array response.</param>
		/// <param name="globalRowClass">Optional global Row class to add to every <c><tr /></c> tag.</param>
		public DataTablesServerSideResponse(bool useObjectDataSource = false, string globalRowClass = null)
        {
            GlobalRowClass = globalRowClass;
        }


    }

}