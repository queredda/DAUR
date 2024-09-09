using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    internal class PublicUser
    {
        public int _ID;
        public string _UserName;
        public string _Password;
        public string _Address;

        // Constructor to initialize the industry
        public PublicUser(int userID, string userName, string userPassword, string userAddress)
        {
            _ID = userID;
            _UserName = userName;
            _Password = userPassword;
            _Address = userAddress
        }

        // Properties
        public int userID
        {
            get { return _ID; }
        }

        public string userName
        {
            get { return _UserName; }
        }

        public string userPassword
        {
            get { return _Password; }
        }

        public string userAddress
        {
            get { return _Address; }
        }
    }
}
