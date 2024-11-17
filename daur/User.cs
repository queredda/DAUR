using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    internal class User
    {
        public int _userID;
        public string _userName;
        public string _userPassword;
        public string _userRole;
        public string _userPhoneNumber;
        public string _userEmail;

        private static List<User> _users = new List<User>();

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public string UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        public string UserEmail
        {
            get { return _userEmail; }
            set { _userEmail = value; }
        }

        public Boolean Login(string userName, string userPassword)
        {
            //Basic Logic for Login
            if (UserEmail == this._userEmail && UserPassword == this._userPassword)
            {
                UserRole = this._userRole;
                UserID = this._userID;
                UserName = this._userName;
            }
            return true;
        }

        public void register(List<User> users)
        {
            users.Add(this);
        }

        public void chooseRole(int roleSelection)
        {
            switch (roleSelection)
            {
                case 1:
                    this._userRole = "Pelaku Industri";
                    break;
                case 2:
                    this._userRole = "Pengepul Sampah";
                    break;
                case 3:
                    this._userRole = "Kurir";
                    break;
                case 4:
                    this._userRole = "Pengguna Umum";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
