using System.Windows;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person()
        {
            Name = "Jannick",
            Age = 30
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;

            //MainContent.Content = new LoginView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}