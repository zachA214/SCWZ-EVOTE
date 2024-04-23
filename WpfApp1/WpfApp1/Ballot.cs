using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Ballot
    {
        private List<string> candidates = new List<string>();
        private string voteChoice;
        private string voterName;

        public Ballot()
        {
            voteChoice = "";
            voterName = "";
        }
        public Ballot(string userName)
        {
            voteChoice = "";
            voterName = userName;
        }

        // getters and setters
        public List<string> getList()
        {
            return candidates;
        }

        public void setList(List<string> newList)
        {
            candidates = newList;
        }

        public string getVoterName() 
        {
            return voterName;
        }

        public void setVoterName(string newName)
        {
            voterName = newName;
        }

        public string getVote()
        {
            return voteChoice;
        }

        private void setVote(string newName) 
        {
            voteChoice = newName;
        }

        public void castVote(string voteChoice)
        {
            setVote(voteChoice);
        }
    }
}
