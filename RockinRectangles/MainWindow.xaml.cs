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

namespace RockinRectangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FirstMove(object sender, RoutedEventArgs e)
        {
            double windowHeight = this.ActualHeight;
            double windowWidth = this.ActualWidth;
            Random rando = new Random();
            int xMovement = rando.Next(200) - 1;
            int yMovement = rando.Next(300) - 1;

            Canvas.SetTop(RockyRectangle, xMovement);
            Canvas.SetLeft(RockyRectangle, yMovement);

            //RockyRectangle.HorizontalAlignment = xMovement;
            //RockyRectangle.VerticalAlignment = yMovement;
            RockyRectangle.Fill = Brushes.BurlyWood;
        }
    }
}
