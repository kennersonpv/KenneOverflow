using System;
using System.Collections.Generic;
using System.Text;

namespace KenneOverflow
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Creation { get; set; }
        private int VoteCount { get; set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Creation = DateTime.Now;
            VoteCount = 0;
        }

        public int VoteUp()
        {
            VoteCount = VoteCount + 1;
            return VoteCount;
        }

        public int VoteDown()
        {
            if (VoteCount > 0)
            { 
                VoteCount = VoteCount - 1; 
            }
            return VoteCount;
        }
    }
}
