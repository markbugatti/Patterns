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

namespace Flyweight
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Timer getTimer;
        public Timer returnTimer;
        public Timer stopTimer;
        public static ListBox ReportListBox { get; private set; }
        BacteriaFactory bacteriaFactory;

        StringBuilder stringBuilder = new StringBuilder();
        private List<string> shapes;

        /*alive bacteria*/
        Queue<Bacterium> bacteria;
        
        /*Report is canceled after session value reaches 20*/
        int session = 0;

        public MainWindow()
        {
            InitializeComponent();
            ReportListBox = ListBox1;

            shapes = new List<string>();
            shapes.Add("square");
            shapes.Add("round");

            bacteriaFactory = new BacteriaFactory();
            bacteria = new Queue<Bacterium>();

            /*first timer*/
            getTimer = new Timer();
            getTimer.Interval = 1150;
            getTimer.Elapsed += GetTimer_Elapsed;
            getTimer.Enabled = true;

            /*second timer*/
            returnTimer = new Timer();
            returnTimer.Interval = 2000;
            returnTimer.Elapsed += ReturnTimer_Elapsed;
            returnTimer.Enabled = true;
        }

        private void GetTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (session < 20)
            {
                Random random = new Random();

                int size = random.Next(1, 10);
                int i = random.Next(0, shapes.Count - 1);
                string shape = shapes[i];

                ConcreteBacterium bacterium = (ConcreteBacterium)bacteriaFactory.GetBacteria(size, shape);
                bacteria.Enqueue(bacterium);

                stringBuilder.Clear();
                stringBuilder.AppendFormat("з'явилася нова бактерія із формою: {0}, розміром {1} та індексом {2}", bacterium.Shape, bacterium.Size, bacterium.Id);
                Dispatcher.Invoke(() =>
                {
                    ReportListBox.Items.Add(stringBuilder);
                });
                session++;
            }
            else
            {
                getTimer.Stop();
                returnTimer.Stop();
            }
            
        }

        private void ReturnTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (bacteria.Count > 0)
            {
                ConcreteBacterium bacterium = (ConcreteBacterium)bacteria.Dequeue();
                bacteriaFactory.ReturnBacteria(bacterium);

                stringBuilder.Clear();
                stringBuilder.AppendFormat("вмерла бактерія із формою: {0}, розміром {1} та індексом {2}", bacterium.Shape, bacterium.Size, bacterium.Id);
                Dispatcher.Invoke(() =>
                {
                    ReportListBox.Items.Add(stringBuilder);
                });
            }
        }
    }

    public abstract class Bacterium
    {
        // Operation - Explore, ExtrinisicStates are size and shape
        public abstract void Adjust(int size, string shape);
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
        public override void Adjust(int size, string shape)
        {
            Size = size;
            Shape = shape;
        }
    }
}