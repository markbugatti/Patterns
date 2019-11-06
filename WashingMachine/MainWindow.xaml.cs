using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WashingMachine.Devices.Mechanical.Containers;
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
            machine = new Machine(ProgramConsoleListBox, SystemConsoleListBox);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (machine.door.IsUnblocked == true)
            {
                Button button = (Button)sender;
                if (DoorIsClosed.IsChecked == true)
                {
                    button.Content = "Закрити";
                    DoorIsOpen.IsChecked = true;
                }
                else
                {
                    button.Content = "Відкрити";
                    DoorIsClosed.IsChecked = true;
                }
            }
        }

        private void PutClothesButton_Click(object sender, RoutedEventArgs e)
        {
            // якщо речі покладені та двері відкриті
            // перевірити кількість речей
            if (DoorIsOpen.IsChecked == true)
            {
                if (WeightTextBox.Text != "")
                {
                    decimal weight = decimal.Parse(WeightTextBox.Text);
                    if (weight <= machine.tank.maxWeight)
                    {
                        machine.tank.Weight = weight;
                        MessageBox.Show("Речі покладено");
                    }
                    else
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendFormat("Занадто багато речей. Максимум {0} кг", machine.tank.maxWeight.ToString());
                        MessageBox.Show(stringBuilder.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Покладіть речі");
                }
            }
            else
            {
                MessageBox.Show("Відкрийте дверцята");
            }
        }

        private void ContainerBButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainerB_IsFull.IsChecked == true)
            {
                ContainerB_IsEmpty.IsChecked = true;
                machine.containerB.Fill();
            }
            else
            {
                ContainerB_IsFull.IsChecked = true;
            }
        }

        private void ContainerAButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainerA_IsFull.IsChecked == true)
            {
                ContainerA_IsEmpty.IsChecked = true;
                machine.containerA.Fill();
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
                machine.containerSmall.Fill();
            }
            else
            {
                ContainerSmall_IsFull.IsChecked = true;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (DoorIsClosed.IsChecked == true)
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
                // заполнить лоток
                program.Start();
            }
            else
            {
                MessageBox.Show("Закрийте двері");
            }
        }

        private void ProgramSynthetic_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Заблакировать кнопку 2, разблакировать кнопку 1 и 3
            ContainerAButton.IsEnabled = false;
            ContainerBButton.IsEnabled = true;
            ContainerSmallButton.IsEnabled = true;
            EmptyContainer();
        }

        private void ProgramCombined_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Заблакировать кнопку 3, разблакировать кнопку 1 и 2
            ContainerSmallButton.IsEnabled = false;
            ContainerAButton.IsEnabled = true;
            ContainerBButton.IsEnabled = true;
        }

        private void ProgramCotton_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Заблакировать кнопку 3, разблакировать кнопку 1 и 2
            ContainerSmallButton.IsEnabled = false;
            ContainerAButton.IsEnabled = true;
            ContainerBButton.IsEnabled = true;
            EmptyContainer();
        }

        public void FillContainer(Type type)
        {
            if (type == typeof(ContainerA))
            {
                ContainerA_IsFull.IsChecked = true;
                machine.containerA.Fill();
            }
            else if (type == typeof(ContainerB))
            {
                ContainerB_IsFull.IsChecked = true;
                machine.containerB.Fill();
            }
            else if (type == typeof(ContainerSmall))
            {
                ContainerSmall_IsFull.IsChecked = true;
                machine.containerSmall.Fill();
            }
        }
        public void EmptyContainer(/*Type type*/)
        {
            ContainerSmall_IsEmpty.IsChecked = true;
            ContainerB_IsEmpty.IsChecked = true;
            ContainerA_IsEmpty.IsChecked = true;
            machine.containerA.Empty();
            machine.containerSmall.Empty();
            machine.containerB.Empty();

        }
    }
}
