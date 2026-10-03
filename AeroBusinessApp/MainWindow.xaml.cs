using System;
using System.Windows;
using AeroBusinessApp.Pages;

namespace AeroBusinessApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Autho());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            BackButton.Visibility = MainFrame.CanGoBack ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
