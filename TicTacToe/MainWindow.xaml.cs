using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Dictionary<Player, ImageSource> imageSources = new()
        {
            { Player.X, new BitmapImage(new Uri("pack://application:,,,/Assets/X15.png")) },
            { Player.O, new BitmapImage(new Uri("pack://application:,,,/Assets/O15.png")) }
        };

        private readonly Image[,] imageControls = new Image[3, 3];
        private readonly GameState gameState = new GameState();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
