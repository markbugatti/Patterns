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

namespace PatternsMomento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter = 0;
        GameHistory game;
        public MainWindow()
        {
            InitializeComponent();
            game = new GameHistory();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(game.History.Count == 0)
            {
                counter = 0;
            }
            PlayButton button = (PlayButton)sender;
            string content = button.Content.ToString();
            if (content == "")
            {
                ButtonMomento buttonMomento = new ButtonMomento(button.Name, content);
                game.History.Push(buttonMomento);

                if ((counter % 2) == 0)
                    content = "X";
                else
                    content = "0";
                counter++;

                ((Button)sender).Content = content;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (game.History.Count != 0)
            {
                ButtonMomento buttonMomento = game.History.Pop();
                PlayButton button = (PlayButton)this.FindName(buttonMomento.Name);
                button.RestoreState(buttonMomento);
            }
        }
    }
}
