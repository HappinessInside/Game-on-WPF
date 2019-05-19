using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace MyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            Welcome.Content = "Welcome to the game \"Bulls and cows\"!";
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "для-презентаций-музыка-2.wav";
            sp.Load();
            sp.PlayLooping();
        }

        private void FirstGameBtn_Click(object sender, RoutedEventArgs e)
        {   
            BullsAndCows FirstGameWindow = new BullsAndCows();
            FirstGameWindow.Owner=this;
            this.Hide();
            FirstGameWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            FirstGameWindow.ShowDialog();
           
        }
        
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }
        private void Reference_Click(object sender, RoutedEventArgs e)
        {
            Reference page = new Reference();
            page.ShowDialog();

        }


    }
}
