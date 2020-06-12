using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return string.Format($"UserID {UserId} FirstName: {FirstName} Lastname: {LastName}  Phone Number: {PhoneNumber} EmailAddress: {EmailAddress}");
        }
    }
}
