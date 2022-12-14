using System;
using System.Collections.Generic;
using System.Text;

namespace CustomProject_BernsCaay.Model
{
    internal class Data
    {
        public string title { get; set; }
        public string url { get; set; }
        public string author { get; set; }
        public int? num_comments { get; set; }
        public int? story_id { get; set; }
        public string story_title { get; set; }
        public string story_url { get; set; }
        public long? parent_id { get; set; }
        public long? created_at { get; set; }
    }
}
