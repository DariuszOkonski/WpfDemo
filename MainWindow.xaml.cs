using System.Windows;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>()
        {
            new Person{Name="Jannick", Age=30 },
            new Person{Name="Marc", Age=20},
            new Person{Name="Maria", Age=40},
            new Person{Name="Scott", Age=35},
            new Person{Name="Lucas", Age=27}
        };


        public MainWindow()
        {
            InitializeComponent();

            ListBoxNames.ItemsSource = People;
        }
    }
}