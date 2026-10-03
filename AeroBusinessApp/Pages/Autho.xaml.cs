using System.Windows;
using System.Windows.Controls;

namespace AeroBusinessApp.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void EnterGuestButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                MessageBox.Show("Введите логин.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                LoginTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordInput.Password))
            {
                MessageBox.Show("Введите пароль.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                PasswordInput.Focus();
                return;
            }

            MessageBox.Show("Авторизация пользователя будет реализована в следующей части проекта.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
