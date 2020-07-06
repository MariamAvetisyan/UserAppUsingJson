using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class UserRepositoryWorkingWithJson : UserRepository
    {
        private readonly ISerializer _serializer;
        private readonly IJsonWorker _jsonWorker = new JsonWorker();
        private readonly string _path;

        public UserRepositoryWorkingWithJson(ISerializer serializer)
        {
            _serializer = serializer;
            _path = ConfigurationManager.AppSettings["jsonPath"];
            Users = _serializer.DeSerialize<List<User>>(Read()) ?? new List<User>();
        }

        public override void Save()
        {
            string json = _jsonWorker.Serialize<List<User>>(Users);
            File.WriteAllText(_path, json);
        }

        public string Read()
        {
            string json = string.Empty;
            if (File.Exists(_path))
            {
                using (StreamReader file = File.OpenText(_path))
                {
                    json = file.ReadToEnd();
                }
            }
            return json;
        }
    }
}

