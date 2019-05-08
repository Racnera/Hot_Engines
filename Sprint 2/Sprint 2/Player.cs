///314243
///5/3/19
///Player class and wall detection
///includes updating the player's location, angle and hit detection


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
namespace Sprint_2
{

    class Player
    {
        ImageBrush sprite;
        BitmapImage bitmap = new BitmapImage(new Uri("pixil-frame-0.png", UriKind.Relative));

        //player globals
        //Ethan Hunter
        double ang = 0;   //displays the angle on game window if toggled on
        double i = 0;     //used to change the direction the player is facing 
        int speed = 5; //constant for circle movement
        Point position = new Point(50,50); //position of car on screen
        Rectangle car = new Rectangle();
        Canvas canvas;
        double angle = 0; //secondary angle used in facing positions, used for radian to degree conversion
        //double test = 90;
        /// <summary>
        /// Call player
        /// </summary>
        public Player()
        { 
            Point centre = new Point();      //centre of player     
            Canvas.SetLeft(car, position.X); 
            Canvas.SetTop(car, position.Y);
            car.RenderTransformOrigin = new Point(0.5, 0.5);//centre of car
            centre = car.RenderTransformOrigin; //appoints the centre of the car to our point of rotation           
        }       
        /// <summary>
        /// Recreates the player, includes movement and rotation based on keys pressed
        /// </summary>
        /// Ethan Hunter & Austin McKee
        public void update(Canvas c)
        {
            //Ethan Hunter
            angle = (Math.PI*i/180);//sin and cos work in RAD, this is the conversion           
            canvas = c;

            //Austin McKee, modified by Ethan Hunter
            if (Keyboard.IsKeyDown(Key.Up))//press 'up' arrow key
            {
                //sin and cos math done by Ethan Hunter
                position.Y -= speed*(Math.Cos(angle)); //goes up if facing up (cos0 =1), no change if facing right/left (cos90/270)
                position.X += speed*(Math.Sin(angle)); //goes right if facing right, no change if facing up
                Canvas.SetTop(car, position.Y);
                Canvas.SetLeft(car, position.X);
            }
            else if (Keyboard.IsKeyDown(Key.Down)) //press 'down' arrow key
            {
                position.Y += speed*(Math.Cos(angle)); //goes down if facing up, no change if facing right/left
                position.X -= speed*(Math.Sin(angle)); //goes left if facing right, no change if up
                Canvas.SetTop(car, position.Y);
                Canvas.SetLeft(car, position.X);
            }
            //Ethan Hunter
            if (Keyboard.IsKeyDown(Key.Right)) //checks for rotation clockwise
            {
                i += 57.2958/10;  //turn speed is 1 radian/constant
                angle = i;       //used in displaying the angle, and movement speed    //debugging
                if(angle > 360) { angle -= 360; } //resets if over 360degrees
                //ang = i;              //debugging
            }
            else if (Keyboard.IsKeyDown(Key.Left)) //checks rotation counter-clockwise
            {
                i -= 57.2958/10;   
                angle = i;
                if(angle <  0) { angle += 360; }
                // ang = i;             //used in displaying the angle      //debugging
            }
            car.RenderTransform = new RotateTransform() { Angle = i};    //draws the car at the new facing angle
           //MainWindow.facing = ang;            //sends this info to the mainwindow, shows it on game screen. only used for debugging; degrees
           // MainWindow.facingactual = angle;    // ||  radians
            
        }
        /// <summary>
        /// Draw the player in the starting position
        /// </summary>
        /// <param name="c">
        /// MainWindow.gameScreen
        /// </param>
        public void drawPlayer(Canvas c)
        {
            sprite = new ImageBrush(bitmap);         //sprite/character model
            sprite.Stretch = Stretch.None;        
            sprite.AlignmentX = AlignmentX.Left;
            sprite.AlignmentY = AlignmentY.Top;
            sprite.Viewport = new Rect(0, 0, 100, 100);
            car.Fill = sprite;
            //car.Fill = Brushes.Aqua;                  //solid model instead of sprite
            canvas = c;
            car.Width = 30;
            car.Height = 30;
            c.Children.Add(car); //puts character on canvas
           
        }

    }
}
