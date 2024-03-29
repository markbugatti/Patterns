﻿using System;
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

namespace AbstractFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static StackPanel stackPanel;
        public MainWindow()
        {
            InitializeComponent();
            stackPanel = MovieStackPanel;
            Movie movie = FilmFactory.Create("Narnia", "russian");
            movie = FilmFactory.Create("Narnia", "german");
            movie = FilmFactory.Create("Avengers", "ukrainian");
            movie = FilmFactory.Create("Avengers", "english");
            movie = FilmFactory.Create("LionTheKing", "english");
            movie = FilmFactory.Create("LionTheKing", "ukrainian");
            
        }
    }
}
