using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    interface IUserRepository
    {
        void AddUser(User user);
        void Update(User user, int id);
        void RemoveUser(int id);
        void RemoveAllUsers();
        User GetUser(int id);
        IEnumerable<User> GetAll();
    }
}
