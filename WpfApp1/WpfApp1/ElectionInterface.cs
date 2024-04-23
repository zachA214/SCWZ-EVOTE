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
    internal class ElectionInterface
    {
        List<string> candidates = new List<string>();
        TextBox input = new TextBox();
        Button addCandidateButton = new Button();
        Button exitAddCandidateButton = new Button();
        TextBox codeInput = new TextBox();
        Button codeButton = new Button();
        string voteCode = "";
        public void createGraphics()
        {
            addCandidateButton.Content = "Add candidate";
        }

        public void showGraphics()
        {
            //clear the screen
            //show the graphics
        }

        public List<string> getUserInput()
        {
            return candidates;
        }

        public void addCandidateButton_Click(object sender, RoutedEventArgs e)
        {
            candidates.Add(input.Text);
        }

        public void exitAddCandidateButton_Click(object sender, RoutedEventArgs e)
        {
            //clear this screen and go back to the login screen
        }

        public void codeButton_Click(object sender, RoutedEventArgs e)
        {
            if(codeInput.Text != "")
            {
                voteCode = codeInput.Text;
            }
        }

        public string getVoteCode()
        {
            return voteCode;
        }
    }
}
