using System;

namespace EF
{
    public class Blog
    {
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public string Title { get; set; }

        public int Id { get; set; }

        public List<Tag> Tags { get; set; }
    }
}