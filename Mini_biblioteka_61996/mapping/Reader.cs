using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.mapping
{
    public class Reader
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Street { get; set; }
        public virtual int StreetNumber { get; set; }
        public virtual int PostCode { get; set; }
    }
}