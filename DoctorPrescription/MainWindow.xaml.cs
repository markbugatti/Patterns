using System;
using System.Text;
using System.Windows;

namespace DoctorPrescription
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Создать рецепт
            Prescript prescript = new Prescript(
                "надо лечиться",
                new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, DateTime.Today.Day));
            // вывести на экран
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Рецепт: {0}\nДействителен до: {1}\n", prescript.Appointment, prescript.Term);
            listBox1.Items.Add(stringBuilder);
            // задать новое время для того же рецепта.
            DateTime dateTime = prescript.Term;
            prescript = prescript.Clone(
                new DateTime(dateTime.Year, dateTime.Month + 1, dateTime.Day));
            // вывести на экран
            stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Рецепт: {0}\nCрок продлен: {1}\n", prescript.Appointment, prescript.Term);
            listBox1.Items.Add(stringBuilder);
        }
    }
}
