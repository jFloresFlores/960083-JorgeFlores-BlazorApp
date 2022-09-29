namespace DoggosBlazor.Shared
{
    public class User
    {
        public int UserId { get; set; }
        public int UserType { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserDob { get; set; }
        public string UserAddress { get; set; }

        public User() { }

        public User(int userType, string userName, string userPassword, string userDob, string userAddress)
        {
            UserType = userType;
            UserName = userName;
            UserPassword = userPassword;
            UserDob = userDob;
            UserAddress = userAddress;
        }
    }
}
