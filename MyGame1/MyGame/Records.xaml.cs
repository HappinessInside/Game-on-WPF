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

namespace MyGame
{
    /// <summary>
    /// Interaction logic for Records.xaml
    /// </summary>
    public partial class ProgressRecords : Window
    {
        public ProgressRecords()
        {
            InitializeComponent();
        }

        public void WriteInformation()
        {
            Saver saver = new Saver();
            Config cfg = saver.GetConfig();
            CountOfAllGames.Text=cfg.GetNumberOfRecords().ToString();
            CountOfWonGames.Text = cfg.GetNumberOfWonGames().ToString();
            PercentOfWonGames.Text = cfg.PercentOfWinnings().ToString()+"%";
            BestResult.Text = cfg.GetBestRecord();
        }
    }
}
