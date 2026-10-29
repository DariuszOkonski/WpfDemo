using System.Windows;
using System.Windows.Controls;

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

            Button myButton = new Button();
            myButton.Content = "B";

            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);

            Grid myGrid = (Grid)FindName("myGrid");
            myGrid.Children.Add(myButton);
        }
    }
}