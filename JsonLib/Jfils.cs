using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FemmeLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace JsonLib
{
    public class Jfils
    {
        static public void createJsonFemme(IList<Femme> colFem)
        {
            JsonSerializer serializer = new JsonSerializer();
            string output = JsonConvert.SerializeObject(colFem);
            using (StreamWriter writer = File.CreateText("data.json"))
                serializer.Serialize(writer, output);
        }

        static public IList<Femme> createFemmeFromJson()
        {
            string reader = "";
            using (FileStream jsonfile = new FileStream("data.json", FileMode.Open, FileAccess.Read))
            {
                Byte[] tempArray = new byte[jsonfile.Length];
                jsonfile.Read(tempArray, 0, (int)jsonfile.Length);
                reader = Encoding.UTF8.GetString(tempArray, 0, tempArray.Length);
            }
            
            Trace.WriteLine(reader);
            JObject femmeSearch = JObject.ReadFrom() ;

            // get JSON result objects into a list
            IList<JToken> results = femmeSearch.Children().ToList();

            // serialize JSON results into .NET objects
            IList<Femme> searchResults = new List<Femme>();
            foreach (JToken result in results)
            {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                Femme searchResult = result.ToObject<Femme>();
                searchResults.Add(searchResult);
            }
            return searchResults;
        }
    }
}
