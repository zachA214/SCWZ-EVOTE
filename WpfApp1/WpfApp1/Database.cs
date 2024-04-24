using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;


namespace WpfApp1
{
    

    internal class Database
    {
        int electionsResults;
        int userInfo;
        int elections;

        void addElection(string electionName) 
        {
            var storage = StorageClient.Create();
            byte[] filler = new byte[32];
            var fillerStream = new MemoryStream(filler);
            storage.UploadObject("scwz-elections", electionName, "application/octet-stream", fillerStream);
        }

        //updates client-side election to Google Cloud
        void updateElection(string election) //int is a placeholder until merging happens 
        {
            var storage = StorageClient.Create();
            var thisElection = storage.GetObject("scwz-elections", election); //probably change election to something like election.getName()

            if (thisElection.Metadata == null) 
            {
                thisElection.Metadata = new Dictionary<string, string>();
                //start date
                thisElection.Metadata.Add("start-date", "placeholder start date"); //replace placeholder with something like election.getStartDate()
                //end date
                thisElection.Metadata.Add("end-date", "placeholder end date"); //replace placeholder with something like election.getEndDate()
                //winning candidates
                thisElection.Metadata.Add("winning-candidates", "placeholder winning candidates list"); //replace placeholder with something like election.getWinningCandididates()
                //candidates
                thisElection.Metadata.Add("candidates", "placeholder candidates list"); //replace placeholder with something like election.getCandididates()
                //votes
                thisElection.Metadata.Add("votes", "placeholder votes list"); //replace placeholder with something like election.getVotes() <--not sure how this data will be formatted
            }

        }

        string getResults(string electionName) //returns a string with format "(votes),(candidates),(winningcandidates)"
        {
            var storage = StorageClient.Create();
            var elections = storage.ListObjects("scwz-elections").ToArray();
            var storageObject = storage.GetObject("scwz-elections", electionName, new GetObjectOptions { Projection = Projection.Full });

            if (!elections.Any(x => x.Name == electionName))
            {
                string votes = "";
                storageObject.Metadata.TryGetValue("votes", out votes);

                string candidates = "";
                storageObject.Metadata.TryGetValue("candidates", out candidates);

                string winningcandidates = "";
                storageObject.Metadata.TryGetValue("winning-candidates", out winningcandidates);

                string concat = "(" + votes + ")" + "(" + candidates + ")" + "(" + winningcandidates + ")";
                return concat;
            }
            else
            {
                return "";
            }       
        }

        string getUserInfo(string name) // returns a string with format "(phoneNo),(email),(birthDate)"
        {
            var storage = StorageClient.Create();
            var elections = storage.ListObjects("scwz-userinfo").ToArray();
            var storageObject = storage.GetObject("scwz-userinfo", name, new GetObjectOptions { Projection = Projection.Full });

            if (!elections.Any(x => x.Name == name))
            {
                string phoneNo = "";
                storageObject.Metadata.TryGetValue("phoneNo", out phoneNo);

                string email = "";
                storageObject.Metadata.TryGetValue("email", out email);

                string birthDate = "";
                storageObject.Metadata.TryGetValue("birthDate", out birthDate);

                string concat = "(" + phoneNo + ")" + "(" + email + ")" + "(" + birthDate + ")";
                return concat;
            }
            else
            {
                return "";
            }
        }
    }
}
