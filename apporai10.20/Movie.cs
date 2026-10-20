using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace apporai10._20
{
    public class Movie : IContent
    {
        private Video video;

        public Movie(Video video)
        {
            this.video = video;
        }

        public string GetTitle()
        {
            return video.Title;
        }

        public int GetLength()
        {
            return video.Length;
        }
    }
}
