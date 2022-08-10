using System;
using System.Collections.Generic;
using System.Text;

namespace CustomProject_BernsCaay.Model
{
    internal class Articles
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Data> data { get; set; }
    }
}
