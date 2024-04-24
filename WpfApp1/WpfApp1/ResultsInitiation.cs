using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ResultsInitiation
    {
        public ResultsInitiation() { } 
        ElectionResults createResult(string name, string totalVotes, string winningCandidates, string candidates)
        {
            var results = new ElectionResults(totalVotes, winningCandidates, candidates);
            return results;
        }
    }
}
