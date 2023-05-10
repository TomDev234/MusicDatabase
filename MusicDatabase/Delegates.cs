using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase
{
    public class Delegates
    {
        public delegate void EditAlbumCallback();
        public delegate void EditTrackCallback();
        public static EditAlbumCallback? albumCallback;
        public static EditTrackCallback? trackCallback;
    }
}
