using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Flagscript.Web.Assets.DataTables.Test
{
    
    [TestClass]
    public class ServerSideResponseJsonConverterTest
    {

        [TestMethod]
        public void Test_Write()
        {

            Console.WriteLine("Running Test");

            DataTablesServerSideResponse<TestJsonClass> response = new DataTablesServerSideResponse<TestJsonClass>()
            {
                Draw = 2,
                RecordsTotal = 23,
                RecordsFiltered = 4
            };

            string json = JsonConvert.SerializeObject(response, Formatting.Indented, new ServerSideResponseJsonConverter<TestJsonClass>());
            Console.WriteLine(json);

        }

    }

    [JsonObject]
    public class TestJsonClass : DataTablesRow
    {

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

    }

}
