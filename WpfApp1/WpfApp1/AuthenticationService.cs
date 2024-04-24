using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AuthenticationService
    {
        public AuthenticationService() { }
        internal bool VerifyUser(string username) 
        {
            string bucketname = "scwz-userinfo";
            var storage = StorageClient.Create();
            var users = storage.ListObjects(bucketname).ToArray();
            if (users.Any(x => x.Name == username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
