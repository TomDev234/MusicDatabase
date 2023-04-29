using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase
{
    internal class Album
    {
        public int ID { get; set; }
        public string? Albumname { get; set; }
        public string? Artistname { get; set; }
        public int Year { get; set; }
        public string? ImageURL { get; set; }
        public string? Description { get; set; }
    }
}
