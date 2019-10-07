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
            PlayButton playButton = ((PlayButton)sender);
            string content = playButton.Content.ToString();
            if (content == "") {
                if (game.History.Count == 0)
                {
                    counter = 0;
                }
                string name = playButton.Name;
                ButtonMomento buttonMomento = new ButtonMomento(name, content);
                game.History.Push(buttonMomento);

                if ((counter % 2) == 0)
                    content = "X";
                else
                    content = "0";
                counter++;

                ((Button)sender).Content = content;
            }
            else
            {
                MessageBox.Show("Эта клеточка уже занята");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (game.History.Count > 0)
            {
                ButtonMomento buttonMomento = game.History.Pop();
                PlayButton playButton = (PlayButton)this.FindName(buttonMomento.Name);
                playButton.RestoreState(buttonMomento);
            }
            else
            {
                MessageBox.Show("Вы отменили все возможные ходы");
            }
        }
    }
}
