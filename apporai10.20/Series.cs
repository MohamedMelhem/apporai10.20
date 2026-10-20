using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apporai10._20
{
    public class Series : IContent
    {
        private string title;
        private List<Video> videos;

        public Series(string title, Video video)
        {
            this.title = title;
            videos = new List<Video>();
            videos.Add(video);
        }

        public Series(string title, List<Video> videos)
        {
            this.title = title;
            this.videos = new List<Video>(videos);
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetLength()
        {
            int sum = 0;

            foreach (Video video in videos)
            {
                sum += video.Length;
            }

            return sum;
        }
    }
}
