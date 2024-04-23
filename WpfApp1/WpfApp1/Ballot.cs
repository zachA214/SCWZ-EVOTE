using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Ballot
    {
        private string voterName;
        private bool voteMade;

        public Ballot(string userName)
        {
            voterName = userName;
            voteMade = false;
        }
    }
}
