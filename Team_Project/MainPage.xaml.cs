using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Team_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Login.LoginInfo.ContainsKey(username.Text))
            {
                if (Login.LoginInfo[username.Text] == password.Password)
                {
                    // Change the message dialog to page navigation!
                    MessageDialog message = new MessageDialog($"Welcome {username.Text}!");
                    message.ShowAsync();
                    username.Text = "";
                    password.Password = "";
                }
                else
                {
                    MessageDialog message = new MessageDialog("Invalid password. Please try again.");
                    message.ShowAsync();
                    username.Text = "";
                    password.Password = "";
                }
            }
            else
            {
                MessageDialog message = new MessageDialog($"{username.Text} not found. Try another username or register for an account.");
                message.ShowAsync();
                username.Text = "";
                password.Password = "";
            }

        }
    }
}
