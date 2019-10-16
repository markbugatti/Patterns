using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AbstractFactory
{
    public class Poster
    {
        public static void AddPoster(Movie movie)
        {
            // add image
            Image image = new Image();
            image.Width = 400;
            image.Source = new BitmapImage(movie.PosterPath);
            // add textblock with text
            TextBlock textBlock = new TextBlock();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(@"Sound language: {0}; Subtitles language {1}", movie.SoundLanguage, movie.SubtitlesLanguage);
            textBlock.Text = stringBuilder.ToString();
            textBlock.FontSize = 16;
            textBlock.Margin = new System.Windows.Thickness(10);
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            // add image and textblock to stack Panel
            StackPanel posterPanel = new StackPanel();
            posterPanel.Children.Add(image);
            posterPanel.Children.Add(textBlock);
            // add grid to stackpanel
            MainWindow.stackPanel.Children.Add(posterPanel);
        }
    }
}
