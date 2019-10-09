using FactoryMethod.Creators;
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
        public MainWindow()
        {
            InitializeComponent();
            grid = PlayField;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Creator creator = new WormCreator();
            Figure figure = creator.Create(1, 1);
            creator = new ZetCreator();
            Figure figure1 = creator.Create(2, 2);
            creator = new TeCreator();
            Figure figure2 = creator.Create(4, 2);
            creator = new SquareCreator();
            Figure figure3 = creator.Create(5, 1);
            creator = new ElCreator();
            Figure figure4 = creator.Create(1, 5);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
