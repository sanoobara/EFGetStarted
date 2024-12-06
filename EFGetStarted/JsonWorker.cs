using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EFGetStarted
{
    internal class JsonWorker
    {
        private string path;
        private TextReader reader;
        string json;


        public JsonWorker(string jsonPath)
        {
            path = jsonPath;
            reader = new StringReader(path);
            using (var reader = new StreamReader(path))
            {
                json = reader.ReadToEnd();
            }
        }

        public List<Employee> GetValuesFromJson()
        {

            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(json);

            return employees;
        }


    }
}
