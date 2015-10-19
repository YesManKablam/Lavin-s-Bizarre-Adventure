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
using System.IO.IsolatedStorage;

namespace textAdventure1.Stages.Car
{
    public partial class Car1 : PhoneApplicationPage
    {
        public Car1()
        {
            InitializeComponent();

        }

        private void look1_Click(object sender, EventArgs e)
        {
            look1button.Visibility = Visibility.Collapsed;
            car1.Text = "The 1987 Volvo you are sitting in certainly has seen better days. However, when all things are considered, it has held up pretty well.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            compartmentButton1.Visibility = Visibility.Collapsed;
            car1.Text = "You reach over and open the compartment. Inside there is an employee ID, insurance papers, pamphlets from when the car was bought, a packet of tissues and a wallet.";
            lookID.Visibility = Visibility.Visible;
            lookWallet.Visibility = Visibility.Visible;
        }

        private void lookID_Click(object sender, RoutedEventArgs e)
        {
            lookID.Visibility = Visibility.Collapsed;
            car1.Text = "A Gentech employee ID, owned by one John Lavin. On the right side of the card, there is a picture of John Lavin.";
        }

        private void lookWallet_Click(object sender, RoutedEventArgs e)
        {
            lookWallet.Visibility = Visibility.Collapsed;
            car1.Text = "About $100, and $2:50 in loose change.";
            moveBackseat.Visibility = Visibility.Visible;
        }

        private void moveBackseat_Click(object sender, RoutedEventArgs e)
        {
            moveBackseat.Visibility = Visibility.Collapsed;
            car1.Text = "As soon as you begin to move to the back of the car, the motorbike in front of you inches forward slightly. This is your chance. You inche forward too, excited about being on very small step closer to freedom. As soon as you do that, you divert your attention back to the car. You have a backseat to explore afterall.";
            confirm.Visibility = Visibility.Visible;
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stages/Car/Car2.xaml", UriKind.Relative));
        }


    }
}