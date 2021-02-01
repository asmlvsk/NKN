using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NKNProject.Models
{
    public class TrackData
    {
        [Key]
        public Guid TrackId { get; set; }
        public string TrackName { get; set; }
        public string TrackGenre { get; set; }
        public DateTime TrackReleaseDate { get; set; }
    }
}
