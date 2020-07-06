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
    public class UserRepositoryWorkingWithXML : UserRepository
    {
        private readonly ISerializer _serializer;
        private readonly IXmlWorker _xmlWorker = new XmlWorker();
        private readonly string _path;

        public UserRepositoryWorkingWithXML(ISerializer serializer)
        {
            _serializer = serializer;
            _path = ConfigurationManager.AppSettings["xmlPath"];
            Users = _serializer.DeSerialize<List<User>>(_path) ?? new List<User>();
        }

        public override void Save()
        {
            string xml = _xmlWorker.Serialize<List<User>>(Users);
            File.WriteAllText(_path, xml);
        }

        public string Read()
        {
            string xml = string.Empty;
            if (File.Exists(_path))
            {
                using (TextReader reader = new StreamReader(_path))
                {
                    xml = reader.ReadToEnd();
                }
            }
            return xml;
        }
    }
}

