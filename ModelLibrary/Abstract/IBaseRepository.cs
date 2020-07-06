using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public interface IBaseRepository<T>
    {
        bool IsValidId(int ID);
        void AddUser(T entity);
        void Update(T user, int id);
        void RemoveUser(int id);
        void RemoveAllUsers();
        T GetUser(int id);
        IEnumerable<T> GetAll();
        void Save();
    }
}
