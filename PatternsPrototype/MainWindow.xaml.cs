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

namespace PatternsPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string TextTitle = "Обратная польская запись";
        static string Text = "обра́тная по́льская запись " +
            "(англ. reverse polish notation, rpn) – " +
            "форма записи математических и логических выражений, " +
            "в которой операнды расположены перед знаками операций. также именуется " +
            "как обратная польская запись, обратная бесскобочная запись, " +
            "постфиксная нотация, бесскобочная символика лукасевича, польская " +
            "инверсная запись, ПОЛИЗ.";
        Prototype Article;
        Prototype ArticleBackup;
        public MainWindow()
        {
            InitializeComponent();

            Article = new ConcratePrototype1(TextTitle, Text);
            ArticleBackup = Article.Clone();
            
            TextBoxTitle.Text = Article.Title;
            TextBoxText.Text = Article.Text;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTitle.IsReadOnly = false;
            TextBoxText.IsReadOnly = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBoxTitle.IsReadOnly = true;
            TextBoxText.IsReadOnly = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Article = ArticleBackup.Clone();
            TextBoxTitle.Text = Article.Title;
            TextBoxText.Text = Article.Text;
        }
    }

}
