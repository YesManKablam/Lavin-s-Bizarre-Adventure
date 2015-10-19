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
    public partial class Office3 : PhoneApplicationPage
    {
        public Office3()
        {
            InitializeComponent();
        }

        private void ded_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Dead.xaml", UriKind.Relative));
        }

        private void ded_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Dead.xaml", UriKind.Relative));
        }
    }
}