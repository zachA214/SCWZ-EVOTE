﻿using System.ComponentModel.DataAnnotations.Schema;
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
    }
}

private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
{

}
    }

}
