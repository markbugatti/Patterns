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
using WashingMachine.Programs;

namespace WashingMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Machine machine;
        public MainWindow()
        {
            InitializeComponent();
            machine = new Machine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (DoorIsClosed.IsChecked == true) {
                button.Content = "Відкрити";
                DoorIsOpen.IsChecked = true;
            }
            else
            {
                button.Content = "Закрити";
                DoorIsClosed.IsChecked = true;
            }
        }

        private void PutClothesButton_Click(object sender, RoutedEventArgs e)
        {
            // якщо речі покладені та двері відкриті
            // перевірити кількість речей
            if(DoorIsOpen.IsChecked == true)
            {
                if (WeightTextBox.Text != "")
                {
                    int weight = Int32.Parse(WeightTextBox.Text);
                    if (weight <= machine.tank.maxWeight)
                    {
                        machine.tank.Weight = weight;
                    }
                    else
                    {
                        // вивести в консоль, що вага занадто велика
                    }
                }
            }
        }

        private void ContainerBButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainerB_IsFull.IsChecked == true)
            {
                ContainerB_IsEmpty.IsChecked = true;
            }
            else
            {
                ContainerB_IsFull.IsChecked = true;
            }
        }

        private void ContainerAButton_Click(object sender, RoutedEventArgs e)
        {
            if(ContainerA_IsFull.IsChecked == true)
            {
                ContainerA_IsEmpty.IsChecked = true;
            }
            else
            {
                ContainerA_IsFull.IsChecked = true;
            }
        }

        private void ContainerSmallButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainerSmall_IsFull.IsChecked == true)
            {
                ContainerSmall_IsEmpty.IsChecked = true;
            }
            else
            {
                ContainerSmall_IsFull.IsChecked = true;
            }
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            
            Program program = new Cotton(machine);
            if (ProgramSynthetic_RadioButton.IsChecked == true)
            {
                program = new Synthetics(machine);
            }
            else if (ProgramCombined_RadioButton.IsChecked == true)
            {
                program = new Combined(machine);
            }
            await program.StartAsync();
        }
    }
}
