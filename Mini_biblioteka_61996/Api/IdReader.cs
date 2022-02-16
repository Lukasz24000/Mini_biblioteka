using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.Api
{
    public class IdReader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int PostCode { get; set; }
        public string All { get; set; }
    }
}