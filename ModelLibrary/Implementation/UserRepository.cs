using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using DataAccess;

namespace ModelLibrary
{
    public class UserRepository : IUserRepository
    {
        private readonly IXmlWorker _xmlWorker;
        private readonly IJsonWorker _jsonWorker = new JsonWorker();
        private readonly string _path;
        private List<User> Users { get; set; }

        public UserRepository(IXmlWorker xmlWorker)
        {
            _xmlWorker = xmlWorker;
            _path = ConfigurationManager.AppSettings["xmlPath"];
            Users = _xmlWorker.Deserilize<List<User>>(_xmlWorker.Read());
        }

        public UserRepository()
        {
            _path = ConfigurationManager.AppSettings["jsonPath"];
            Users = _jsonWorker.DeSerialize<List<User>>(_path) ?? new List<User>();
        }

        public void AddUser(User user)
        {
            if (Users.Count != 0)
                user.UserId = Users[(Users.Count - 1)].UserId + 1;
            else
                user.UserId = 1;
            Users.Add(user);
        }

        public void RemoveUser(int id)
        {
            var user = Users.FirstOrDefault(x => x.UserId == id);
            Users.Remove(user);
        }

        public void RemoveAllUsers()
        {
            Users.Clear();
        }

        public User GetUser(int id)
        {
            User user = Users.FirstOrDefault(x => x.UserId == id);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return Users;
        }

        public void Update(User user, int id)
        {
            Users[id].FirstName = user.FirstName;
            Users[id].LastName = user.LastName;
            Users[id].EmailAddress = user.EmailAddress;
            Users[id].PhoneNumber = user.PhoneNumber;

        }

        public void XMlSerialize()
        {
            string xml = _xmlWorker.Serialize<List<User>>(Users);
            _xmlWorker.Save(xml, _path);
        }

        public void JsonSerialize()
        {
            _jsonWorker.Serialize<List<User>>(Users, _path);
        }
    }
}
