using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using DataAccess;

namespace ModelLibrary
{
    public class UserRepository : IBaseRepository<User>
    {
        public List<User> Users { get; set; }

        public bool IsValidId(int ID)
        {
            List<int> Ids = new List<int>();
            foreach (var item in Users)
            {
                Ids.Add(item.UserId);
            }

            return Ids.Contains(ID);
        }
        public UserRepository()
        {
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

        public virtual void Save()
        {
        }
    }
}
