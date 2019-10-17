using Strategy.Characters;
using Strategy.Strategies;
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

namespace Strategy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListBox EventBoard;
        public MainWindow()
        {
            InitializeComponent();
            EventBoard = EventListBox;
            // Фея
            IMovable flyPixy1 = new Fly();
            Pixy pixy1 = new Pixy(flyPixy1);
            pixy1.Move();
            // Орк
            IMovable walkOrc1 = new Walk();
            Orc orc1 = new Orc(walkOrc1);
            List<Character> characters = new List<Character>();
            characters.Add(orc1);
            pixy1.MoveGroup(characters);
            // Ельф
            IMovable flyElf1 = new Walk();
            Elf elf1 = new Elf(flyElf1);
            elf1.Move();
            characters = new List<Character>();
            characters.Add(orc1);
            characters.Add(pixy1);
            elf1.MoveGroup(characters);
            // Пегас
            IMovable walkAndFlyPegasus1 = new WalkAndFly();
            Pegasus pegasus1 = new Pegasus(walkAndFlyPegasus1);
            pegasus1.Move();
            characters = new List<Character>();
            characters.Add(orc1);
            characters.Add(pixy1);
            characters.Add(elf1);
            pegasus1.MoveGroup(characters);
        }
    }
}
