using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    public static class UserSession
    {
        public static int? LoggedInIndustryID { get; private set; }
        public static int? LoggedInCollectorID { get; private set; }
        public static string LoggedInEmail { get; private set; }
        public static string LoggedInName { get; private set; }

        public static void SetIndustryUser(int id, string email, string name)
        {
            LoggedInIndustryID = id;
            LoggedInCollectorID = null;
            LoggedInEmail = email;
            LoggedInName = name;
        }

        public static void SetCollectorUser(int id, string email, string name)
        {
            LoggedInCollectorID = id;
            LoggedInIndustryID = null;
            LoggedInEmail = email;
            LoggedInName = name;
        }

        public static void ClearSession()
        {
            LoggedInIndustryID = null;
            LoggedInCollectorID = null;
            LoggedInEmail = null;
            LoggedInName = null;
        }
    }
}
