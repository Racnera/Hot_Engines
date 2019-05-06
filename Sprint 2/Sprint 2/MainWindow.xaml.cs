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
        //globaldouble 
        public DispatcherTimer gametimer = new DispatcherTimer();
        Tracks t = new Tracks();
        public static int trackNum;
        GameState gameState = new GameState();
        Player p1 = new Player();
        public static string angle ="";
        public static double facing = 0;
        public static double facingactual = 0;


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
            angle = facing.ToString();
            lblcomputedangle.Content ="Computed Angle:" +facingactual.ToString();
            lblangle.Content = "Angle :" +angle;
            if (gameState == GameState.Loading)
            {
                if (Keyboard.IsKeyToggled(Key.Space))
                {
                    gameState = GameState.GameOn;
                }
            }
            if (gameState == GameState.GameOn)
            {
                p1.update(canvas);
            }
            if (Keyboard.IsKeyToggled(Key.Space))
            {
                gameState = GameState.Loading;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            TrackSelection TS = new TrackSelection();
            TS.ShowDialog();
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            gameState = GameState.Loading;
            switch (trackNum) //switches, allows default and used for testing because I'm lazy. I have to click 3 less buttons to start testing
            {
                case 1:
                    gameState = GameState.Loading;
                    selectTrack.Visibility = Visibility.Hidden;
                    startGame.Visibility = Visibility.Hidden;
                    p1.drawPlayer(canvas);
                    t.Track1(canvas);
                    break;
                case 2:
                    gameState = GameState.Loading;
                    selectTrack.Visibility = Visibility.Hidden;
                    startGame.Visibility = Visibility.Hidden;
                    p1.drawPlayer(canvas);
                    t.Track2(canvas);
                    break;
                case 3:
                    gameState = GameState.Loading;
                    selectTrack.Visibility = Visibility.Hidden;
                    startGame.Visibility = Visibility.Hidden;
                    p1.drawPlayer(canvas);
                    t.Track3(canvas);
                    break;
                default:
                    gameState = GameState.Loading;
                    selectTrack.Visibility = Visibility.Hidden;
                    startGame.Visibility = Visibility.Hidden;
                    p1.drawPlayer(canvas);
                    t.Track2(canvas);
                    break;
            }
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            gameState = GameState.Loading;
        }
    }
}