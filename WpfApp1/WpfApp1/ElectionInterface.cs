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
        Button button = new Button();
        public void createGraphics()
        {
            //initialize the graphics
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

        public void handleInput(string candidate)
        {
            //when button is pressed to add a candidate (find how to handle that), add to the list
            //handle the if button pressed in main most likely?
            candidates.Add(candidate);
        }
    }
}
