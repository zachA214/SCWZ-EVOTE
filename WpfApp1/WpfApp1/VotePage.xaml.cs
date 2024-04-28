using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for VotePage.xaml
    /// </summary>
    public partial class VotePage : Page
    {

        public List<string> testList { get; } = new List<string>
        {
            "Zach",
            "Willow",
            "Christian",
            "Sarah"
        };

        public VotePage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button && button.Content is string name)
            {
                //put in data, record that the user has voted
                MessageBox.Show($"Vote for {name} recorded");
                voteTextBox.Text = "Vote has been recorded, please press exit";
                buttonList.Visibility = Visibility.Hidden;

            }
        }
        private void exit_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
