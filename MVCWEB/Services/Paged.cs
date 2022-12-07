using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.Services
{
    public class Paged<T> where T : class
    {
        public IEnumerable<T> List { get; set; }
        public int Count { get; set; }
    }
}