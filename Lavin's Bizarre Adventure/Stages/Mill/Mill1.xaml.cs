using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace textAdventure1.Stages.Mill
{
    public partial class Mill1 : PhoneApplicationPage
    {
        public Mill1()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, RoutedEventArgs e)
        {
            okButton1.Visibility = Visibility.Collapsed;
            mill.Text = "Circling around to the rear of the car, you pop open the trunk." + "\n" + "This is him, right?" + "\n" + "You turn around in surprise. There is a man standing there, a hulking beast of a man, easily 6'4 and weighing about 255lbs. He doesn't wait for you to respond and takes a peer over your shoulder, into the trunk." + "\n" + "Yep, this is it." + "\n" + "He reaches in to the trunk and pulls out a man, one John Lavin, and slings him onto his shoulder." + "\n" + "Come on." + "\n" + "He directed this towards you. John Lavin is in such a state of shock that he doesn't try to struggle or scream. Not that he could anyway, as you were the one the put duct tape around his mouth.";
            okButton2.Visibility = Visibility.Visible;
        }

        private void okButton2_Click(object sender, RoutedEventArgs e)
        {
            okButton2.Visibility = Visibility.Collapsed;
            mill.Text = "Prompt for stay or leave.";
            stayButton.Visibility = Visibility.Visible;
            goButton.Visibility = Visibility.Visible;
        }

        private void stay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Mill/Mill3.xaml", UriKind.Relative));
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Mill/Mill2.xaml", UriKind.Relative));
        }

    }
}