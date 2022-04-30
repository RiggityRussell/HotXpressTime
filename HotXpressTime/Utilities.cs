using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotXpressTime
{
    class Utilities
    {
        internal static bool IsCredentialsValid(string username, string password, string reEnterPass)
        {
            bool isValid = true;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                isValid = false;
            }
            if(string.IsNullOrEmpty(password)|| password != reEnterPass)
            {
                isValid = false;
            }

            return isValid;
            
        }
    }
}
