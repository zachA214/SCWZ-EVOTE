using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Election
    {
        public Election(string startDate = "", string mEndDate = "")
        {
            mStartDate = startDate;
            mEndDate = mEndDate;
        }

        private string mStartDate;
        private string mEndDate;
        private List<Candidate> mCandidateList;
        private ElectionResults mResults;
        private List<Position> mPositionsList;


        public string getStartDate() { return mStartDate; }
        public string getEndDate() { return mEndDate;}
        public void setStartDate(string startDate) { mStartDate = startDate; }
        public void setEndDate(string endDate) {  mEndDate = endDate; }

        public void addCandidate(Candidate newCandidate) { mCandidateList.Add(newCandidate); }
        public void addPosition(Position newPosition) { mPositionList.Add(newPosition); 
        void void showResults() { return mResults;}

    }
}
