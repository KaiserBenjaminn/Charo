using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FemmeLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace JsonLib
{
    public class Jfils
    {
        public void createJsonFemme(List<Femme> colFem)
        {
            colFem.Add(new Femme("Peppels", "Noémie", new DateTime(1999, 02, 16), "Le tyran"));
            colFem.Add(new Femme("Loiseau", "Margaux", new DateTime(2001, 12, 26), "Le coup de plusieurs soirs"));

            JsonSerializer serializer = new JsonSerializer();
            string output = JsonConvert.SerializeObject(colFem);
            using (StreamWriter writer = File.CreateText("data.json"))
                serializer.Serialize(writer, output);
        }
    }
}
