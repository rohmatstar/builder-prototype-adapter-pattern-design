using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class LegacyUserAdapter : INewUser
    {
        public LegacyUser legacyUser;

        public LegacyUserAdapter(LegacyUser user)
        {
            legacyUser = user;
        }

        public string GetFullName()
        {
            return $"{legacyUser.FirstName} { legacyUser.LastName}";
        }

        public string GetUsername()
        {
            return legacyUser.UserName;
        }

        public string GetEmailAddress()
        {
            return legacyUser.Email;
        }
    }
}
