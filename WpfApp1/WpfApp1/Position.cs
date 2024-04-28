using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Position
    {
        public: 
        Position(string title = "", string responsibilities = "")
        {
            this.mTitle = title;
            this.mResponsibilities = responsibilities;
        }

        string getTitle() { return this.mTitle; }

        string getResponsibilities() { return this.mResponsibilities; }

        void setTitle(string newTitle) { this.mTitle = newTitle; }

        void setResponsibilities(string newRes) { this.mResponsibilities = newRes; }

        private:
            string mTitle;
        string mResponsibilities;
    }
}
