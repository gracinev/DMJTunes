using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Team_Project
{
    public sealed partial class Validation : UserControl
    {
        public Validation()
        {
            this.InitializeComponent();
            check.Visibility = Visibility.Collapsed;
            error.Visibility = Visibility.Collapsed;
        }
        public void DisplayValidation(bool result)
        {
            if (result == true)
            {
                check.Visibility = Visibility.Visible;
                error.Visibility = Visibility.Collapsed;
            }
            else
            {
                error.Visibility = Visibility.Visible;
                check.Visibility = Visibility.Collapsed;
            }

        }
    }
}
