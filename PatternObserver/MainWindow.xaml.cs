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

namespace PatternObserver
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();

            mainWindow = this;

            Publisher Publisher1 = new Publisher();
            Post NewPost = new Post();
            Publisher1.AddObserver(NewPost);

            JournalHuman human1 = new JournalHuman();
            NewspaperHuman human2 = new NewspaperHuman();

            
            NewPost.AddObserver(human1);
            NewPost.AddObserver(human2);

            Publisher1.NotifyObservers();
            NewPost.NotifyObservers();
            

        }
    }
}
