using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class RegisteredUser
    {
        public RegisteredUser(string phoneNo = "", string email = "", string birthDate = "", string name = "" ) {
            //local copies of user data, also stored on Google Cloud database
            this.phoneNo = phoneNo;
            this.email = email;
            this.birthDate = birthDate;
            this.name = name;

            //add user to Google Cloud
            var storage = StorageClient.Create();
            var users = storage.ListObjects("scwz-userinfo").ToArray();

            if(!users.Any(x => x.Name == name))
            {
                //add user item
                byte[] filler = new byte[32];
                var fillerStream = new MemoryStream(filler);
                storage.UploadObject("scwz-userinfo", name, "application/octet-stream", fillerStream);

                //store user item in memory
                var thisUser = storage.GetObject("scwz-userinfo", name);

                //add additional data to metadata
                if (!thisUser.Metadata.ContainsKey("phoneNo")) //check to make sure metadata key isn't already there (note that it shouldn't be, but safe is better)
                {
                    thisUser.Metadata.Add("phoneNo", phoneNo);
                }
                if (!thisUser.Metadata.ContainsKey("email")) //check to make sure metadata key isn't already there (note that it shouldn't be, but safe is better)
                {
                    thisUser.Metadata.Add("email", email);
                }
                if (!thisUser.Metadata.ContainsKey("birthDate")) //check to make sure metadata key isn't already there (note that it shouldn't be, but safe is better)
                {
                    thisUser.Metadata.Add("birthDate", birthDate);
                }

            }
        }

        string phoneNo;
        string email;
        string birthDate;
        string name;

        int getLastVote()
        {
            return 0;
        }

        string getBirthDate() {  return birthDate; }

        string getPhoneNo() { return phoneNo; }

        string getEmail() { return email; }

        string getName() { return name;  }

        void vote() { }

        void setBirthDate(string birthDate) { this.birthDate = birthDate; }

        void setPhoneNo(string phoneNo) {  this.phoneNo = phoneNo; }

        void setEmail(string  email) { this.email = email; }

        bool authenticate() 
        {
            var authenticator = new AuthenticationService();
            return authenticator.VerifyUser(name); 
        }

        void viewInfo() { }

        void viewResults() { }

    }
}
