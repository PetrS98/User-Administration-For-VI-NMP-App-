using System.Collections.Generic;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class UserInformations
    {
        public UserNameAndID NameAndID { get; private set; }
        public string Password { get; private set; }
        public List<Permission> Permission { get; private set; }

        public UserInformations(UserNameAndID UserNameAndID, string UserPassword, List<Permission> UserPermission)
        {
            NameAndID = UserNameAndID;
            Password = UserPassword;
            Permission = UserPermission;
        }
    }
}
