using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

using Flagscript.Web.Assets.DataTables;

namespace Flagscript.Web.Assets.DataTables.Test
{
    
    [TestClass]
    public class ServerSideResponseJsonConverterTest
    {

        [TestMethod]
        public void Test_Write()
        {

            Console.WriteLine("Running Test");

            ServerSideResponse<TestJsonClass> response = new ServerSideResponse<TestJsonClass>()
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
    public class TestJsonClass
    {

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

    }

}
