using System.Collections.Generic;
using System.Windows;
using apporai10._20;

namespace apporai10._20
{
    public partial class MainWindow : Window
    {
        private StreamingPlatform platform;

        public MainWindow()
        {
            InitializeComponent();

            platform = new StreamingPlatform();

            Video movieVideo = new Video("Inception", 148);
            Movie movie = new Movie(movieVideo);

            List<Video> episodes = new List<Video>
            {
                new Video("1. epizód", 40),
                new Video("2. epizód", 45),
                new Video("3. epizód", 50)
            };

            Series series = new Series("Példa sorozat", episodes);

            platform.AddContent(movie);
            platform.AddContent(series);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IContent longest = platform.GetLongestContent();

            if (longest != null)
            {
                ResultText.Text =
                    $"Cím: {longest.GetTitle()}\n" +
                    $"Hossz: {longest.GetLength()} perc";
            }
            else
            {
                ResultText.Text = "Nincs tartalom.";
            }
        }
    }
}