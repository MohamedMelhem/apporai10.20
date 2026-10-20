using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace apporai10._20
{
    public class StreamingPlatform
    {
        private List<IContent> contents = new List<IContent>();

        public void AddContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent GetLongestContent()
        {
            if (contents.Count == 0)
                return null;

            IContent longest = contents[0];

            foreach (IContent content in contents)
            {
                if (content.GetLength() > longest.GetLength())
                {
                    longest = content;
                }
            }

            return longest;
        }
    }
}
