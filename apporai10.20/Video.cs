using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apporai10._20
{
    public class Video
    {
        public string Title { get; set; }
        public int Length { get; set; }

        public Video(string title, int length)
        {
            Title = title;
            Length = length;
        }
    }
}
