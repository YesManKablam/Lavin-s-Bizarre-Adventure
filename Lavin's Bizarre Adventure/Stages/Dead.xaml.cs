using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace textAdventure1.Stages
{
    public partial class Dead : PhoneApplicationPage
    {
        public Dead()
        {
            InitializeComponent();
            dead.Text = "Your friends are dead." + "\n" + "Your family is dead." + "\n" + "Your pets are dead." + "\n" + "You suck at life." + "\n" + "The whole world hates you." + "\n" + "You're going to Hell." + "\n" + "Live with it." + "\n" + "Game Over." + "\n\n\n" + "But don't feel bad, you can always........";
        }

        private void tryAgain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Car/Car1.xaml", UriKind.Relative));
        }
    }
}