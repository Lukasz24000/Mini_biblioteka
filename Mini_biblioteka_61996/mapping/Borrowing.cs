using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.mapping
{
    public class Borrowing
    {
        public virtual int Id { get; set; }
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual DateTime BorrowDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }

    }
}