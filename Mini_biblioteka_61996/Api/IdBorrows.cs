using Mini_biblioteka_61996.mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.Api
{
    public class IdBorrows
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string Reader { get; set; }
        public String BorrowDate { get; set; }
        public String ReturnDate { get; set; }
    }
}