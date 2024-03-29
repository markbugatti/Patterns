﻿using System;
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

namespace FactoryMethod
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Grid grid;
        public MainWindow()
        {
            InitializeComponent();
            grid = PlayField;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Figure figure = Creator.Create("worm", 1, 1);
            Figure figure1 = Creator.Create("zet", 2, 2);
            Figure figure2 = Creator.Create("te", 4, 2);
            Figure figure3 = Creator.Create("square" ,5, 1);
            Figure figure4 = Creator.Create("el", 1, 5);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
