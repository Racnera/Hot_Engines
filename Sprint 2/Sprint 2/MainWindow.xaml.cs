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
        //globals 
        public DispatcherTimer gametimer = new DispatcherTimer();
        Tracks t = new Tracks();    //calls tracks
        public static int trackNum; //pulls from TrackSelection window
        GameState gameState = new GameState();
        Player p1;                  //player 1
        Player p2;                  //player 2 
        //public static string angle ="";     //angle debugging
        //public static double facing = 0;   
        //public static double facingactual = 0;


        public MainWindow()
        {   
            InitializeComponent();//start window
            gameState = GameState.MainMenu;//start timer
            gametimer.Tick += Gametimer_Tick;
            gametimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 120);
            
            
        }

        private void Gametimer_Tick(object sender, EventArgs e)
        {
            //angle = facing.ToString();                                                //angle debugging
            //lblcomputedangle.Content ="Computed Angle:"+facingactual.ToString();
            //lblangle.Content = "Angle :" +angle;
            if (gameState == GameState.Loading)
            {
                
                instructions.Visibility = Visibility.Visible;
                if (Keyboard.IsKeyToggled(Key.Space))
                {
                    gameState = GameState.GameOn;
                    instructions.Visibility = Visibility.Hidden;
                     
                }

            }
            if (gameState == GameState.GameOn)
            {
                p1.update(gameScreen);
                if (Keyboard.IsKeyToggled(Key.Space))
                {
                    gameState = GameState.Loading;
                }
            }
            
            if (Keyboard.IsKeyDown(Key.Q))
            {
                gameScreen.Children.Clear();
                instructions.Visibility = Visibility.Hidden;
                mainMenu.Visibility=Visibility.Visible;               
            }                  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {         
            TrackSelection TS = new TrackSelection();
            TS.ShowDialog();
        }


        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            p1= new Player();
            gameState = GameState.Loading;
            gametimer.Start();

            switch (trackNum) //switches, allows default and used for testing because I'm lazy. I have to click 3 less buttons to start testing
            {
                case 1:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    t.Track1(gameScreen);
                    p1.drawPlayer(gameScreen);
                    break;
                case 2:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    p1.drawPlayer(gameScreen);
                    t.Track2(gameScreen);
                    break;
                case 3:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    p1.drawPlayer(gameScreen);
                    t.Track3(gameScreen);
                    break;
                default:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    t.Track2(gameScreen);
                    p1.drawPlayer(gameScreen);
                    break;
            }
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            gameState = GameState.Loading;
        }
    }
}