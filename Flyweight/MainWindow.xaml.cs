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

namespace Flyweight
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListBox ReportListBox { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            ReportListBox = ListBox1;
        }

    }

    public abstract class Bacterium
    {
        // Operation - Explore, ExtrinisicStates are size and shape
        public abstract void Explore(int size, string shape);
    }

    public class ConcreteBacterium : Bacterium
    {
        // intrinsicState is id
        public int Id { get; private set; }
        public int Size { get; private set; }
        public string Shape { get; private set; }
        public ConcreteBacterium(int id)
        {
            Id = id;
        }
        public override void Explore(int size, string shape)
        {
            Size = size;
            Shape = shape;
        }
    }

    public class UnsharedConcreteBacterium : Bacterium
    {
        public int Size { get; private set; }
        public string Shape { get; private set; }

        public override void Explore(int size, string shape)
        {
            Size = size;
            Shape = shape;
        }
    }
}
