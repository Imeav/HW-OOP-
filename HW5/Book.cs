using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class Book : Product
    {
        public int PageCount { get; set; }

        public string Publisher { get; set; } = "";

        public List<string> Authors { get; set; } = new List<string>();
    }
}

