using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public BullsAndCows owner { get; set; }
        public Warning()
        {
            InitializeComponent();
           
        }
        public void IsSure(object sender, RoutedEventArgs e)
        {
            owner.IsSure = true;
            this.Close();
        }
        public void IsNotSure(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
