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
    internal class ResultsInterface
    {
        Button returnButton = new Button();

        public void createGraphics()
        {
            returnButton.Content = "return to login";
            //show results, need acccess to voting results
        }

        public void showGraphics()
        {
            //clear screen
            //show the components you have
        }

        public void returnButton_Click(object sender, RoutedEventArgs e)
        {
            //return to the main screen
        }
    }
}
