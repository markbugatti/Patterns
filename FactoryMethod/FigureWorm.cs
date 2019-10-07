using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMethod
{
    class FigureWorm : Figure
    {
        public FigureWorm()
        {
            create();
        }

        public override void create()
        {
            this.coordinates = new Point(0, 0);

            this.points = new List<Point>();

            this.points.Add(new Point(0, 0));
            this.points.Add(new Point(0, 1));
            this.points.Add(new Point(0, 2));
            this.points.Add(new Point(0, 3));

            this.buttons = new List<GameObject>();

            this.buttons.Add(new GameObject(Brushes.Black));
            this.buttons.Add(new GameObject(Brushes.Black));
            this.buttons.Add(new GameObject(Brushes.Black));
            this.buttons.Add(new GameObject(Brushes.Black));

            MainWindow.grid.Children.Add(buttons[0]);
            MainWindow.grid.Children.Add(buttons[1]);
            MainWindow.grid.Children.Add(buttons[2]);
            MainWindow.grid.Children.Add(buttons[3]);

            buttons[0].SetValue(Grid.RowProperty, 0);
            buttons[1].SetValue(Grid.ColumnProperty, 1);
            buttons[2].SetValue(Grid.ColumnProperty, 2);
            buttons[3].SetValue(Grid.ColumnProperty, 3);
        }

        public override void moveDown()
        {
            
            object baseButton = buttons[0].GetValue(Grid.RowProperty);

            if ((int)baseButton < MainWindow.grid.RowDefinitions.Count){
                foreach (GameObject button in buttons)
                {
                    object current = button.GetValue(Grid.RowProperty);
                    button.SetValue(Grid.RowProperty, (int)current + 1);
                }
            }
        }

        public override void moveLeft()
        {
            int buttonColumn = (int)buttons[0].GetValue(Grid.ColumnProperty);

            int buttonRow = (int)buttons[0].GetValue(Grid.RowProperty);
            int rowsCount = MainWindow.grid.RowDefinitions.Count;

            if (buttonRow < rowsCount - 1) {
                if (buttonColumn - 1 >= 0)
                {
                    foreach (GameObject button in buttons)
                    {
                        object current = button.GetValue(Grid.ColumnProperty);
                        button.SetValue(Grid.ColumnProperty, (int)current - 1);
                    }
                }
            }
        }

        public override void moveRight()
        {
            int buttonColumn = (int)buttons[3].GetValue(Grid.ColumnProperty);
            int columnsCount = MainWindow.grid.ColumnDefinitions.Count;

            int buttonRow = (int)buttons[3].GetValue(Grid.RowProperty);
            int rowsCount = MainWindow.grid.RowDefinitions.Count;

            if (buttonRow < rowsCount - 1) {
                if (buttonColumn < columnsCount - 1)
                {
                    foreach (GameObject button in buttons)
                    {
                        object current = button.GetValue(Grid.ColumnProperty);
                        button.SetValue(Grid.ColumnProperty, (int)current + 1);
                    }
                }
            }
        }
    }
}
