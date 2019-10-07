using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryMethod
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Grid grid;
        private static Timer aTimer;
        public static Figure figure;
        public MainWindow()
        {
            InitializeComponent();
            grid = PlayField;
            figure = new FigureWorm();
        }

        private static void setTimer()
        {
            aTimer = new Timer(700);
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.Enabled = true;
        }

        public static void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                figure.moveDown();
            });

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setTimer();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                figure.moveLeft();
            }
            if( e.Key == Key.Right)
            {
                figure.moveRight();
            }
        }
    }
}
