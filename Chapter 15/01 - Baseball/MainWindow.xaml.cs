using System.Windows;

namespace _01___Baseball
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseballSimulator baseball;

        public MainWindow()
        {
            InitializeComponent();
            baseball = FindResource("basebalSimulator") as BaseballSimulator;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baseball.PlayBall();
        }
    }
}
