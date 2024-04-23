using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class RegisteredUser
    {
        public RegisteredUser(int phoneNo = -1, string email = "", string birthDate = "", string name = "" ) {
            this.phoneNo = phoneNo;
            this.email = email;
            this.birthDate = birthDate;
            this.name = name;
        }

        int phoneNo;
        string email;
        string birthDate;
        string name;

        int getLastVote()
        {
            return 0;
        }

        string getBirthDate() {  return birthDate; }

        int getPhoneNo() { return phoneNo; }

        string getEmail() { return email; }

        string getName() { return name;  }

        void vote() { }

        void setBirthDate(string birthDate) { this.birthDate = birthDate; }

        void setPhoneNo(int phoneNo) {  this.phoneNo = phoneNo; }

        void setEmail(string  email) { this.email = email; }

        bool authenticate() 
        {  
            return true; 
        }

        void viewInfo() { }

        void viewResults() { }

    }
}
