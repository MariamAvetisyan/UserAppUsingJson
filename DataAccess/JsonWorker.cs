using Newtonsoft.Json;
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
        public T DeSerialize<T>(string jsonPhat) where T : class
        {
            T t = default(T);
            JsonSerializer serializer = new JsonSerializer();

            if (File.Exists(jsonPhat))
            {
                using (StreamReader sr = new StreamReader(jsonPhat))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        t = serializer.Deserialize<T>(reader);
                    }
                }
            }

            return t;
        }

        public void Serialize<T>(T t, string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, t);
                }
            }
        }
    }
}
