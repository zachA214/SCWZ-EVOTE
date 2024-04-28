using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Admin
    {
        Admin(string email = "", int phoneNo = -1, string password = "")
        {
            mEmail = email;
            mPhoneNo = phoneNo;
            mPassword = password;
        }
        string mEmail;
        string mPassword;
        int mPhoneNo;

        public void setEmail(string email) { mEmail = email; }
        public string getEmail() { return mEmail;}
        public void setPassword(string pass) { mPassword = pass; }
        public string getPassword() { return mPassword;}
        public void setPhoneNo(int phoneNo) { mPhoneNo = phoneNo;}
        public int getPhoneNo() {  return mPhoneNo;}

        bool authenticate(string username, string password) { if(username == mEmail &&  password == mPassword) return true; return false; }
        void viewInfo() { }
        void viewResults() { }

    }
}
