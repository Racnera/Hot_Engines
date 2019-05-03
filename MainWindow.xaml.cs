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
using System.Windows.Threading;

namespace Sprint_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

        enum GameState { MainMenu,Loading,TrackSelection,Time,GameOn}
    
    public partial class MainWindow : Window
    {
        //global
        public DispatcherTimer gametimer = new DispatcherTimer();
        Tracks t = new Tracks();
        public static int trackNum;
        GameState gameState = new GameState();
        Player p1 = new Player();

        public MainWindow()
        {   
            InitializeComponent();
            gameState = GameState.MainMenu;
            gametimer.Tick += Gametimer_Tick;
            gametimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);
            gametimer.Start();
        }

        private void Gametimer_Tick(object sender, EventArgs e)
        {
            p1.update(canvas);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrackSelection TS = new TrackSelection();
            TS.ShowDialog();
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            if (trackNum == 2)
            {
                gameState = GameState.Loading;
                selectTrack.Visibility = Visibility.Hidden;
                startGame.Visibility = Visibility.Hidden;
                p1.drawPlayer(canvas);
                t.Track2(canvas);
            }
        }
    }
}
