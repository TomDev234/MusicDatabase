using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase
{
    public class Track
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Number { get; set; }
        public string? VideoURL { get; set; }
        public string? Lyrics { get; set; }
        public int AlbumID { get; set; }
    }
}
