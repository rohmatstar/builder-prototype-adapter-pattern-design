using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class UserBuilder
    {
        private User user = new User();
        public UserBuilder SetUserId(string userId)
        {
            user.UserId = userId;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            user.Password = password;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }

}
