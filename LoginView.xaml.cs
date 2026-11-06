using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;

            string? envPw = System.Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Entered correct password");
                }
                else
                {
                    MessageBox.Show("Wntered wrong password");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }

        }
    }
}
