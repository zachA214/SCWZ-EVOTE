using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ElectionResults
    {
        public ElectionResults(int totalVotes, int winningCandidates, int candidates) 
        {
            this.totalVotes = totalVotes;
            this.winningCandidates = winningCandidates;
            this.candidates = candidates;
        }

        int totalVotes;
        int winningCandidates;
        int candidates;

        void showWinners() { }

        void showVotes() { }

    }
}
