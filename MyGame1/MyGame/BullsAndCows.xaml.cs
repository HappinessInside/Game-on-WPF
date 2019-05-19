using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Security.Principal;
using System.Text;
using System.Threading;
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
using System.Windows.Media.Animation;


namespace MyGame
{
    /// <summary>
    /// Interaction logic for BullsAndCows.xaml
    /// </summary>
    public partial class BullsAndCows : Window
    { 
        private bool flagEvent;
        private string UnknownNumber { get; set; }
        private bool GameIsWonStatus { get; set; }
        private int countOfStrokes { get; set; }
        public bool IsSure { get; set; }
       
        public BullsAndCows()
        {   
            InitializeComponent();
            B1.MouseDown += IsMouseDown;
            B2.MouseDown += IsMouseDown;
            B3.MouseDown += IsMouseDown;
            B4.MouseDown += IsMouseDown;
            Ball0.MouseDown += IsMouseDown;
            Ball1.MouseDown += IsMouseDown;
            Ball2.MouseDown += IsMouseDown;
            Ball3.MouseDown += IsMouseDown;
            Ball4.MouseDown += IsMouseDown;
            Ball5.MouseDown += IsMouseDown;
            Ball6.MouseDown += IsMouseDown;
            Ball7.MouseDown += IsMouseDown;
            Ball8.MouseDown += IsMouseDown;
            Ball9.MouseDown += IsMouseDown;
            StartTheGame();
         }

        private void StartTheGame()
        {
            countOfStrokes = 0;
            GameIsWonStatus = false;
            bool flag = false;
            while(!flag)
            {  Random r = new Random();
               UnknownNumber = r.Next(1023,9876).ToString();
               flag = true;
               for (int i = 0; i < 4; i++)
               {
                    for (int j = i + 1; j < 4; j++)
                    {
                        if (UnknownNumber[i] == UnknownNumber[j])
                        {
                            flag = false;
                            break;
                        }
                     }
                   if (!flag)
                   {
                       break;
                   }
               }
            }
         }
        private void FirstGame_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
                 
            SaveInformationOfTheGame();
            if (IsSure || GameIsWonStatus)
            {
                this.Owner.Show();
            }
            else
            {
                e.Cancel = true;
            }
                 
        }
        private void OpacityBtn_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "Sound_18567.wav";
            sp.Load();
            sp.Play();
           
            DoubleAnimation animationOpacityOn=new DoubleAnimation(Opacity=1, new Duration(TimeSpan.FromMilliseconds(1000)), FillBehavior.HoldEnd);
            animationOpacityOn.AutoReverse = true;
            Cow2.BeginAnimation(OpacityProperty,animationOpacityOn);

            if (B1.Opacity == 1 && B2.Opacity == 1 && B3.Opacity == 1 && B4.Opacity == 1)
            {
                
                string SelectedByPlayerNumber = B1.number.ToString() + B2.number.ToString() + B3.number.ToString() + B4.number.ToString();
                int countOfBulls = 0;
                int countOfCows = 0;
                if (SelectedByPlayerNumber[0] == '0')
                {
                    MessageBox.Show("Zero cannot stand in first position. It is a four digit number!");
                }
                else
                {
                    for (int i=0;i<4;i++)
                  {
                    for (int j = 0; j < 4; j++)
                    {
                        if (SelectedByPlayerNumber[i] == UnknownNumber[j])
                        {
                            if (i == j)
                            {
                                countOfBulls++;
                            }
                            else
                            {
                                countOfCows++;
                            }
                            break;
                        }
                    }
                    
                  }
                    TableOfResults.Text += SelectedByPlayerNumber + "   " + "Bulls:" + " " + countOfBulls + "  " + "Cows:" +" " + countOfCows + "\r\n";
                    countOfStrokes++;
                 if (countOfBulls == 4)
                 {
                    GameIsWonStatus = true;
                    MessageBox.Show("Congratulations! You guessed the number!");
                 } 
               }
            }
            else
            {
                MessageBox.Show("Set all the digits of the number and try again!");
            }
        }

        public void IsMouseDown(object sender, MouseEventArgs e)
        {
            flagEvent = false;
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data = new DataObject((ImageOfBall)sender);
                DragDrop.DoDragDrop(this, data, DragDropEffects.All);
                if (flagEvent)
                {
                    ((ImageOfBall) sender).Opacity = 0;
                    
                }
                
             }
        }

        private void Target(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(ImageOfBall))&& ((ImageOfBall)sender).Opacity==0)
            {
                flagEvent = true;
                ImageOfBall f = e.Data.GetData(typeof(ImageOfBall))as ImageOfBall;
                ((ImageOfBall)sender).number=f.number;
                ((ImageOfBall)sender).Source = f.Source;
                ((ImageOfBall) sender).Opacity = 1;
            }
        }

        private void Reference_Click(object sender, RoutedEventArgs e)
        {
            Reference page = new Reference();
            page.ShowDialog();

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            
            SaveInformationOfTheGame();
            if (IsSure || GameIsWonStatus)
            {
                ReturnToInitialSettings();
                StartTheGame();
            }
            
        }

        private void ReturnToInitialSettings()
        {
            TableOfResults.Clear();
            B1.Opacity = 0;
            B2.Opacity = 0;
            B3.Opacity = 0;
            B4.Opacity = 0;
            Ball1.InitialSettings();
            Ball2.InitialSettings();
            Ball0.InitialSettings();
            Ball3.InitialSettings();
            Ball4.InitialSettings();
            Ball5.InitialSettings();
            Ball6.InitialSettings();
            Ball7.InitialSettings();
            Ball8.InitialSettings();
            Ball9.InitialSettings();
         }

        private void SaveInformationOfTheGame()
        {
            IsSure = false;
            if (!GameIsWonStatus)
            {   
                Warning window = new Warning();
                window.owner = this;
                window.ShowDialog();
            }
            if(IsSure || GameIsWonStatus)
            {
            Saver saver = new Saver();
            Config cfg = saver.GetConfig();
            Record currentRecord = new Record(countOfStrokes, GameIsWonStatus);
            cfg.AddRecord(currentRecord);
            saver.Save(cfg);
           }
        }
        private void Progress_Click(object sender, RoutedEventArgs e)
        {
           ProgressRecords window = new ProgressRecords();
           window.WriteInformation();
           window.ShowDialog();
           
        }
    }
}
