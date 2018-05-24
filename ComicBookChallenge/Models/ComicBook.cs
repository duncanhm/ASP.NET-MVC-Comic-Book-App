using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookChallenge.Models
{
    public class ComicBook
    {
        public int ComicBookId { get; set; }
        public string ComicTitle { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeTitle { get; set; }
        public List<Character> Characters { get; set; }
    }
}