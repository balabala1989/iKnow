using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace iKnow
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void askeMeButtom_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Index.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if ((e.Orientation & PageOrientation.Portrait) == (PageOrientation.Portrait))
            {
                askeMeButtom.Margin = new Thickness(105, 240, 125, 412);

                knowMeButton.Margin = new Thickness(105, 437, 125, 212);
            }
            else
            {
                askeMeButtom.Margin = new Thickness(248, 171, 230, 481);

                knowMeButton.Margin = new Thickness(248, 316, 230, 342);
            }
        }

        private void knowMeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Knowme.xaml", UriKind.Relative));
        }

        
        
    }
}