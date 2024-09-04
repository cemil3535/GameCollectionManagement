using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
        public DateTime? ReleaseDate { get; set; } // null deegr alabilir
        public int? PlayTime { get; set; } // null deegr alabilir
        public byte[] CoverImage { get; set; }
    }
}
