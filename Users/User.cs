namespace Users
{
    public class User  : IAccessbillity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        private static User user;
        private static object userLock = new object();

        private User()
        {
            
        }

        public static User GetUser()
        {
            if (user == null)
            {
                lock (userLock)
                {
                    if (user == null)
                    {
                        user = new User();
                    }
                }
            }
            return user;
        }

        public string AccessType()
        {
            if (UserName.Contains("cus"))
            {
                return "customer";
            }
            else if (UserName.Contains("man"))
            {
                return "manager";
            }
            else if (UserName.Contains("dir"))
            {
                return "director";
            }
            return "InValid User Name Or Password";
        }
    }
}
