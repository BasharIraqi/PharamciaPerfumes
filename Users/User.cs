using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        static private User user;

        static private Object key = new object();

        private User()
        {

        }
        static public User GetUser()
        {
            if (user == null)
            {
                lock (key)
                {
                    if (user == null)
                    {
                        user = new User();
                    }
                }
            }
            return user;
        }
    }
}
