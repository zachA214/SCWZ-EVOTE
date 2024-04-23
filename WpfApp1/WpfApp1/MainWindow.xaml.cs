using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

        }
        private void buttonPressed(object sender, RoutedEventArgs e)
{
    Button clickedButton = sender as Button;
    if (clickedButton != null)
    {
        if (clickedButton.Name == "loginButton")
        {
            //validate user
            string message = $"Please enter voting code:";
        }
        else if (clickedButton.Name == "signUpButton")
    {
        //something??
        string message = $"aaa";
    }
    else if (clickedButton.Name == "Enter")
    {
        //Check with voting codes we have
        //show voting info and ask for input
        clickedButton.Name = "Vote!";
        clickedButton.Content = "Vote";
    }
    else if (clickedButton.Name == "Vote!")
    {
        //put in data
        //go back to sign in
        clickedButton.Name = "loginButton";
        clickedButton.Content = "log in";
    }
    }
}

private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
{

}
    }

}
