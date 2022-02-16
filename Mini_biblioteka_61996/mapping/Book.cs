using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.mapping
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual int Year { get; set; }

    }
}