using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.Data.POCOs
{
    public class AlbumInfo
    {
        public string Title { get; set; }
        public int TotalAlbumTracks { get; set; }
        public decimal TotalPriceForalbumtracks { get; set; }
        public int AverageTrackLengthA { get; set; }
        public int AverageTrackLengthB { get; set; }
    }
}
