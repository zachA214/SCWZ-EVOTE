using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal class VoteInterface
    {
        Button voteButton = new Button();

        //maybe tweak this to fit what we are going for better
        ListBox candidateList = new ListBox();
        
        string userChoice = "";

        public string getUserInput()
        {
            return userChoice;
        }

        public void createGraphics()
        {
            voteButton.Content = "Vote!";
            //view data and make the graphics based on that
        }

        public void updateGraphics()
        {
            //apply the graohic changes to the screen, find how to clear the screen and put the new stuff in
        }
    }
}
