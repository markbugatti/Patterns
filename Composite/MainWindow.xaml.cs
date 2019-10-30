using Composite.Composite;
using Composite.Leaf;
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

namespace Composite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Component operand1;
        Component operand2;
        Component operand3;
        Component operand4;
        Component operand5;
        Component operand6;
        Component multiply1;
        Component multiply2;
        Component plus1;
        Component plus2;
        Component plus3;
        public MainWindow()
        {
            InitializeComponent();

            operand1 = new Operand();
            operand2 = new Operand();
            operand3 = new Operand();
            operand4 = new Operand();
            operand5 = new Operand();
            operand6 = new Operand();

            multiply1 = new MultiplyComposite();
            multiply2 = new MultiplyComposite();

            plus1 = new PlusComposite();
            plus2 = new PlusComposite();
            plus3 = new PlusComposite();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            operand1.Add(Int32.Parse(field1.Text));
            operand2.Add(Int32.Parse(field2.Text));
            operand3.Add(Int32.Parse(field3.Text));
            operand4.Add(Int32.Parse(field4.Text));
            operand5.Add(Int32.Parse(field5.Text));
            operand6.Add(Int32.Parse(field6.Text));

            plus1.Add(operand1);
            plus1.Add(operand2);
            multiply1.Add(plus1);
            multiply1.Add(operand3);
            plus2.Add(operand5);
            plus2.Add(operand6);
            multiply2.Add(operand4);
            multiply2.Add(plus2);

            plus3.Add(multiply1);
            plus3.Add(multiply2);

            plus1.Execute();
            multiply1.Execute();

            plus2.Execute();
            multiply2.Execute();

            fieldResult.Text = plus3.Execute().ToString();
        }
    }
}
