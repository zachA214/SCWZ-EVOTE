using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ElectionResults
    {
        public ElectionResults(string totalVotes, string winningCandidates, string candidates) 
        {
            this.totalVotes = totalVotes;
            this.winningCandidates = winningCandidates;
            this.candidates = candidates;
        }

        string totalVotes;
        string winningCandidates;
        string candidates;

        string showWinners() { return winningCandidates; }

        string showVotes() { return totalVotes; }

    }
}
