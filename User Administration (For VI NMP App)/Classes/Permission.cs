using System;
using System.Collections.Generic;
using System.Text;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class Permission
    {
        public string Name { get; private set; }
        public byte BitPosition { get; private set; }

        public Permission(string name, byte bitPosition)
        {
            Name = name;
            BitPosition = bitPosition;
        }
    }
}
