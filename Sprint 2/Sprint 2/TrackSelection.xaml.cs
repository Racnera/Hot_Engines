///Ethan Hunter,314243
///5/3/2019
///new window to choose a track, when the 'start'game button is pressed, the window should close and load the map in a new window


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
using System.Windows.Shapes;

namespace Sprint_2
{
    /// <summary>
    /// Interaction logic for TrackSelection.xaml
    /// </summary>
    public partial class TrackSelection : Window
    {
       
        public TrackSelection()
        {
            InitializeComponent();
        }
       
    private void rbTrack_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void TrackSelection_Click(object sender, RoutedEventArgs e)
        {
            if (rbTrack1.IsChecked == true)
            {
                
                //Track1 t1 = new Track1();
                MainWindow.trackNum = 1;
                DialogResult = true;
                

            }
            if (rbTrack2.IsChecked == true)
            {
                
                MainWindow.trackNum = 2;
                DialogResult = true;
                
            }
            
        }
    }
}
