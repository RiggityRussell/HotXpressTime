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

            if((username == null) || (password == null))
            {
                return false;
            }
            if(reEnterPass == null || password != reEnterPass)
            {
                return false;
            }

            return true;
            
        }
    }
}
