namespace Users
{
    public class User  : IAccessbillity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

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
