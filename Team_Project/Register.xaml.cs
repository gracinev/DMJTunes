using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Team_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        Login login = new Login();
        public Register()
        {
            this.InitializeComponent();
            btnRegister.IsEnabled = false;
            error.Visibility = Visibility.Collapsed;
            password.IsEnabled = false;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (login.ValidateInfo(username.Text, password.Password) == false)
            {
                error.Visibility = Visibility.Visible;
                error.Text = $"{username.Text} already exists. Please try another username.";
                password.Password = "";
                usernameValidation.Visibility = Visibility.Collapsed;
                passwordValidation.Visibility = Visibility.Collapsed;
                error.Visibility = Visibility.Collapsed;
            }  
            else
            {
                login.ValidateInfo(username.Text, password.Password);
                usernameValidation.Visibility = Visibility.Collapsed;
                passwordValidation.Visibility = Visibility.Collapsed;
                error.Visibility = Visibility.Collapsed;
               
            }
        }

        private bool ValidateNull(string validate)
        {
            btnRegister.IsEnabled = false;
            if (string.IsNullOrWhiteSpace(validate))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnRegister.IsEnabled = false;
            if (ValidateNull(username.Text) == false)
            {
                error.Visibility = Visibility.Visible;
                usernameValidation.DisplayValidation(false);
                error.Text = "Please enter a valid username";
                password.IsEnabled = false;
            }
            else
            {
                error.Visibility = Visibility.Collapsed;
                usernameValidation.DisplayValidation(true);
                password.IsEnabled = true;
            }
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            btnRegister.IsEnabled = false;
            error.Visibility = Visibility.Collapsed;
            if (ValidateNull(password.Password) == false || password.Password.Length <= 6)
            {
                error.Visibility = Visibility.Visible;
                passwordValidation.DisplayValidation(false);
                error.Text = "Enter a password that is greater than 6 characters";
            }
            else
            {
                passwordValidation.DisplayValidation(true);
                btnRegister.IsEnabled = true;
            }
        }
    }
}
