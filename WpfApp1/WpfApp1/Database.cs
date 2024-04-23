using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;


namespace WpfApp1
{
    

    internal class Database
    {
        int electionsResults;
        int userInfo;
        int elections;

        void addElection() { }

        void updateElection() { }

        int getResults(string electionName) 
        {
            return 0;       
        }

        int getUserInfo()
        {
            return 0;
        }


        //test_database() { }
        //public Bucket CreateBucket(
        //string projectId = "420500",
        //string bucketName = "your-unique-bucket-name")
        //{
        //    var storage = StorageClient.Create();
        //    var bucket = storage.CreateBucket(projectId, bucketName);
        //    Console.WriteLine($"Created {bucketName}.");
        //    return bucket;
        //}

    }
}
