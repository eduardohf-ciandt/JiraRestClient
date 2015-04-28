using System;

namespace TechTalk.JiraRestClient
{
    public class Release
    {
        public String self { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string released { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
