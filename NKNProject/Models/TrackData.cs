using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;

namespace NKNProject.Models
{
    public class TrackData : MongoDbEntity
    {
        public string TrackName { get; set; }
        public string TrackGenre { get; set; }
        public DateTime? TrackReleaseDate { get; set; }
        public Uri TrackImg { get; set; }
        public string TrackLinks { get; set; }
        public string TrackDescription { get; set; }

        public TrackData()
        {
        }

        public TrackData(string id, string trackName, string trackGenre, string trackDescription, DateTime trackReleaseDate)
        {
            Id = id;
            TrackName = trackName;
            TrackGenre = trackGenre;
            TrackDescription = trackDescription;
            TrackReleaseDate = trackReleaseDate;
        }
    }
}
