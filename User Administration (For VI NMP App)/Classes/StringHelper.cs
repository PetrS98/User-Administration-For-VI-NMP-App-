using System;
using System.Collections.Generic;
using System.Text;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class StringHelper
    {
        public static bool CheckIfTextIsNumber(string Text)
        {
            try
            {
                int.Parse(Text);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
