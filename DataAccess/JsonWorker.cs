using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class JsonWorker : IJsonWorker
    {

        public JsonWorker()
        {
        }
        public T DeSerialize<T>(string json) where T : class
        {
            T t = default(T);
            t = JsonConvert.DeserializeObject<T>(json);
            return t;
        }

        public string Serialize<T>(T t)
        {
            string str = JsonConvert.SerializeObject(t);
            return str;

        }
    }
}
