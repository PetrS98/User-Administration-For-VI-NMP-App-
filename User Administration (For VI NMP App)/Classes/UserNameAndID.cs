using System;
using System.Collections.Generic;
using System.Text;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class UserNameAndID
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public UserNameAndID(int UserID, string UserFirstName, string UserLastName)
        {
            ID = UserID;
            FirstName = UserFirstName;
            LastName = UserLastName;
        }
    }
}
