using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount { UserName = "admin", Password = "admin", Role = "Administrator" },
                new UserAccount { UserName = "user", Password = "user", Role = "User" }

            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            var user = new UserAccount ();
            user = _users.FirstOrDefault(x => x.UserName == userName);
            Console.WriteLine(user);
            
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}