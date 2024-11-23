using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    internal class UserSession
    {
        public static int? LoggedInIndustryID { get; set; }
        public static int? LoggedInCollectorID { get; set; }
        public static string LoggedInEmail { get; set; }
    }
}
