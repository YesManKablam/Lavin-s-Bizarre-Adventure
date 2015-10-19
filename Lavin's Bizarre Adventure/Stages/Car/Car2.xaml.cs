using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace textAdventure1.Stages.Car
{
    public partial class Car2 : PhoneApplicationPage
    {
        public Car2()
        {
            InitializeComponent();
        }

        private void exButton_Click(object sender, RoutedEventArgs e)
        {
            exButton.Visibility = Visibility.Collapsed;
            backseat.Text = "Nothing much. Chuckun Rull";
            eatButton.Visibility = Visibility.Visible;
        }

        private void eatButton_Click(object sender, RoutedEventArgs e)
        {
            eatButton.Visibility = Visibility.Collapsed;
            backseat.Text = "Uted da Chuckun rull. Cars are now beeping";
            frontButton.Visibility = Visibility.Visible;
        }

        private void frontButton_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Car/Car3.xaml", UriKind.Relative));
        }


    }
}