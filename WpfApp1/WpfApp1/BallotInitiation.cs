using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class BallotInitiation
    {
        public BallotInitiation() { }

        public Ballot createBallot()
        {
            var results = new Ballot();
            return results;
        }

        public Ballot createBallot(string voterName)
        {
            var results = new Ballot(voterName);
            return results;
        }
    }
}
