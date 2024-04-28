using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    internal class Candidate
    {
  
        string mName;
        string mEmail;
        int mPhone;
        int mAge;
        Position mPosition;
        string mStatement; 

   
        public string getName() { return mName; }
        public string getEmail() { return mEmail;}
        public int getPhone() { return mPhone; }
        public  int getAge() { return mAge;}
        public Position getPosition () { return mPosition; }
        public string getStatement() { return mStatement;}

        public void setName(string name) { mName = name; }
        public void setEmail(string email) {  mEmail = email; }
        public void setPhone(int phone) {  mPhone = phone; }
        public void setAge(int age) {  mAge = age; }
        public void setStatement(string statement) {  mStatement = statement; }
        public void setPosition (position) { mPosition = position; }



    }
}
