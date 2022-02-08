using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Web.Http.Cors;

namespace ConsoleApp1
{
    class usercheck
    {

        private static List<string> GetUsers()
        {
            List<string> ret = new List<string>();
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher search = new ManagementObjectSearcher(query);
            foreach (ManagementObject a in search.Get())
            {
                ret.Add(a["Name"].ToString());
            }
            return ret;
        }
        [DisableCors]
        public static bool isadmin(string user)
        {
            foreach (string a in GetUsers())
            {
                if (a == user) return true;
            }
            return false;
        }
    }
}
