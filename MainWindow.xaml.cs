using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBoxNames.ItemsSource = new List<string>()
            {
                "Jannick",
                "Peter",
                "Maria",
                "Marc"
            };
        }
    }
}