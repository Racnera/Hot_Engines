///EthanHunter 314243
///5/3/2019
///Tracks and their layouts, 


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

    public class Tracks
    {
        /// <summary>
        ///Tracks and their layouts
        /// </summary>
        Canvas canvas;
        Rectangle wall1 = new Rectangle();
        Rectangle wall2 = new Rectangle();
        Rectangle wall3 = new Rectangle();
        Rectangle wall4 = new Rectangle();

        Point wall1Pos = new Point();
        Point wall2Pos = new Point();
        Point wall3Pos = new Point();
        Point wall4Pos = new Point();
        public void Track1(Canvas c)
        {
            canvas = c;
            wall1.Height = 600;
            wall1.Width = 800;
            wall1Pos.Y = 300;
            wall1Pos.X = 200;
            wall1.Fill = Brushes.Green;
            canvas.Children.Add(wall1);
            Canvas.SetLeft(wall1, 100);

        }
        public void Track2(Canvas c)
        {
            canvas = c;
            wall1.Height = 600;
            wall1.Width = 800;
            wall1Pos.Y = 100;
            wall1Pos.X = 200;
            wall1.Fill = Brushes.Green;
            canvas.Children.Add(wall1);
            Canvas.SetLeft(wall1, wall1Pos.X);
            Canvas.SetTop(wall1, wall1Pos.Y);
            
        }
        public void Track3(Canvas c)
        {

        }
    }
}
