using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotXpressTime
{
    internal class Update
    {
        internal static void CreateNewUser(string username, string password)
        {
            using (StreamWriter stream = new StreamWriter("Users/Users.txt", false))
            {
                string info = $"2,{username},{password},,";
                stream.Write(info);
                stream.Close();
            }
            
        }
    }
}
