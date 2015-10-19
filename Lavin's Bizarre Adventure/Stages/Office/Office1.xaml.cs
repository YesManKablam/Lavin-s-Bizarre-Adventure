using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace textAdventure1.Stages.Office
{
    public partial class Office1 : PhoneApplicationPage
    {
        private int mistake = 0;
        public Office1()
        {
            InitializeComponent();

        }

        private void correctButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Office/Office2.xaml", UriKind.Relative));
        }

        private void wrongButton1_Click(object sender, RoutedEventArgs e)
        {
            wrongButton1.Visibility = Visibility.Visible;
            mistake = mistake + 1;
            if (mistake == 2)
            {
                NavigationService.Navigate(new Uri("/Stages/Office/Office3.xaml", UriKind.Relative));
            }
        }

        private void wrongButton2_Click(object sender, RoutedEventArgs e)
        {
            wrongButton2.Visibility = Visibility.Visible;
            mistake = mistake + 1;
            if (mistake == 2)
            {
                NavigationService.Navigate(new Uri("/Stages/Office/Office3.xaml", UriKind.Relative));
            }
        }
    }
}