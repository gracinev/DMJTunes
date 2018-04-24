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
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            error.Visibility = Visibility.Collapsed;
            if (login.ValidateInfo(username.Text, password.Password) == false)
            {
                error.Visibility = Visibility.Visible;
                error.Text = $"{username.Text} already exists. Please try another username.";
            }  
            else
            {
                login.ValidateInfo(username.Text, password.Password);
                username.Text = "";
                password.Password = "";
            }
        }

        private bool RegistrationValidation(string validate)
        {
            btnRegister.IsEnabled = false;
            if (!string.IsNullOrWhiteSpace(validate))
            {
                return true;
            }
            else
            {
                error.Visibility = Visibility.Visible;
                error.Text = "Please enter a valid username and/or password";
                return false;
            }
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.IsEnabled = false;
            btnRegister.IsEnabled = false;
            if (RegistrationValidation(username.Text) == false)
            {
                usernameValidation.DisplayValidation(false);
                error.Text = "Please enter a valid username";
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
            RegistrationValidation(password.Password);
            if (password.Password.Length < 8 || RegistrationValidation(password.Password) == false)
            {
                error.Visibility = Visibility.Visible;
                error.Text = "Enter a password that is greater than 8 characters";
                passwordValidation.DisplayValidation(false);
            }
            else
            {
                passwordValidation.DisplayValidation(true);
                error.Visibility = Visibility.Collapsed;
                btnRegister.IsEnabled = true;
            }
        }
    }
}
