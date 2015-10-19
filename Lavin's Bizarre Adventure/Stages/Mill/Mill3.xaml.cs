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
    public partial class Mill3 : PhoneApplicationPage
    {
        public Mill3()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Dead.xaml", UriKind.Relative));
        }
    }
}