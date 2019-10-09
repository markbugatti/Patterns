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
        protected string Shape { get; set; }
        public Bacterium(string shape)
        {
            Shape = shape;
        }
        public abstract void Find(string colony);
    }

    public class squareBacterium : Bacterium
    {
        public squareBacterium() : base("square") { }

        public override void Find(string colony)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("this square bacterium find in {0}", colony);
            MainWindow.ReportListBox.Items.Add(stringBuilder.ToString());
        }
    }

    public class RoundBacterium : Bacterium
    {
        public RoundBacterium() : base("round")
        {

        }

        public override void Find(string colony)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("this round bacterium find in {0}", colony);
            MainWindow.ReportListBox.Items.Add(stringBuilder.ToString());
        }
    }

    // Factory
    public class BacteriumAccounting
    {
        Dictionary<string, Bacterium> bacteria = new Dictionary<string, Bacterium>();
        public BacteriumAccounting()
        {
            bacteria.Add("Round", new RoundBacterium());
            bacteria.Add("Square", new squareBacterium());
        }

        public Bacterium GetBacterium(string key)
        {
            if (bacteria.ContainsKey(key))
                return bacteria[key];
            else
                return null;
        }
    }
}
