using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace MyGame
{
   public class ImageOfBall: Image
    {
       
        public int number { get; set; }
        public int initialNumber
        {
            get;
            set; 
        }
        public ImageSource initialSourse { get; set; }

        public void InitialSettings()
        {
            number = initialNumber;
            Source = initialSourse;
            Opacity = 1;
        }
    }
}
