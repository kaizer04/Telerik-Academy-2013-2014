using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsSystem.Models
{
    public class Article
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public DateTime DateCreated { get; set; }

        public int Likes { get; set; }
    }
}
