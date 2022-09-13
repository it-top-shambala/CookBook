using System.Windows;

namespace CookBook.App.Windows.AuthorizationWindow;

public partial class AuthorizationWindow : Window
{
    public AuthorizationWindow()
    {
        InitializeComponent();
    }

    private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
    {
        InputLogin.Clear();
        InputPassword.Clear();
    }

    private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
    {
        var login = InputLogin.Text;
        var password = InputPassword.Password;

        if (login == "login" && password == "123")
        {
            MessageBox.Show("Вы успешно авторизовались!");
            new MainWindow.MainWindow().Show();
            this.Close();
        }
        else
        {
            MessageBox.Show("Вы ввели неправильно логин или пароль");
        }
    }
}
