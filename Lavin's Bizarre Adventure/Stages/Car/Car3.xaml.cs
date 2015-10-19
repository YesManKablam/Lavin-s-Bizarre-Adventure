using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;

namespace textAdventure1.Stages.Car
{
    public partial class Car3 : PhoneApplicationPage
    {
        public Car3()
        {
            InitializeComponent();
        }

        private void moveOffice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Office/Office1.xaml", UriKind.Relative));
        }

        private void moveDock_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Dock/Dock1.xaml", UriKind.Relative));
        }

        private void moveMill_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Mill/Mill1.xaml", UriKind.Relative));
        }
    }
}