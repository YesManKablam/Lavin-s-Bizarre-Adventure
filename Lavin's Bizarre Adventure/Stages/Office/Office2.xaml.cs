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
    public partial class Office2 : PhoneApplicationPage
    {
        public Office2()
        {
            InitializeComponent();
        }

        private void lookButton_Click(object sender, RoutedEventArgs e)
        {
            lookButton.Visibility = Visibility.Collapsed;
            desk.Text = "The desk is fairly well organised.Cabinet to your left.";
            cabinetButton.Visibility = Visibility.Visible;
        }

        private void cabinetButton_Click(object sender, RoutedEventArgs e)
        {
            cabinetButton.Visibility = Visibility.Collapsed;
            desk.Text = "Tis locked. You sit back up and face the desk.";
            computerButton.Visibility = Visibility.Visible;
        }

        private void computerButton_Click(object sender, RoutedEventArgs e)
        {
            computerButton.Visibility = Visibility.Collapsed;
            desk.Text = "The computer flickers on. Hand on your shoulder. Ded";
            dedButton.Visibility = Visibility.Visible;
        }

        private void dedButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Office/Office3.xaml", UriKind.Relative));
        }
    }
}