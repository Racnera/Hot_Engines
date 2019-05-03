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
        //player globals
        double d = 5;    
        int i = 0;
        int speed = 5;
        Point position = new Point(50,50);
        Rectangle car = new Rectangle();
        Rectangle Wall = new Rectangle();
        Canvas canvas;
        double angle = 0;
        public Player()
        { 

            Point centre = new Point();           
            Canvas.SetLeft(car, position.X);
            Canvas.SetTop(car, position.Y);
            car.RenderTransformOrigin = new Point(0.5, 0.5);
            centre = car.RenderTransformOrigin;
        }
        
        public void update(Canvas c)
        {
             
            canvas = c;
            if (Keyboard.IsKeyDown(Key.Up))
            {
                position.Y -= speed*(Math.Cos(angle));
                position.X -= speed*(Math.Sin(angle));
                Canvas.SetTop(car, position.Y);
                Canvas.SetLeft(car, position.X);
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                position.Y += speed*(Math.Cos(angle));
                position.X += speed *(Math.Sin(angle));
                Canvas.SetTop(car, position.Y);
                Canvas.SetLeft(car, position.X);
               

            }
            if (Keyboard.IsKeyDown(Key.Right))
            {
                car.RenderTransform = new RotateTransform()
                { Angle = i };
                angle = i;
                i += 10;
 
            }

        }
        public void drawPlayer(Canvas c)
        {   canvas = c;
            car.Width = 50;
            car.Height = 50;
            car.Fill = Brushes.Aqua;
            c.Children.Add(car);
            position.X = 0;
            position.Y = 0;
        }

    }
}
