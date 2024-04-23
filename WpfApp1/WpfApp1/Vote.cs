using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Vote
    {
        Ballot userBallot = new Ballot();
        private bool voteMade;
        public Vote()
        {
            voteMade = false;
        }
        bool getVoteMade()
        {
            return voteMade;
        }
        void toggleVoteState()
        {
            voteMade = !voteMade;
        }

        public void castVote(string voteChoice)
        {
            userBallot.castVote(voteChoice);
        }
    }
}
