using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace textAdventure1
{
    public partial class Play : PhoneApplicationPage
    {
        public Play()
        {
            InitializeComponent();
        }

        private void mainBody_TextBlock(object sender, TextChangedEventArgs e)
        {

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Car/Car1.xaml", UriKind.Relative));
        }
    }
}