using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public enum UserProperties
    {
        FirstName, LastName, EmailAddress, PhoneNumber
    }

    public enum Commands
    {
        AddUser, RemoveUser, ShowUser, EditUser, ShowAllUsers, RemoveAllUsers, Quite
    }
}
