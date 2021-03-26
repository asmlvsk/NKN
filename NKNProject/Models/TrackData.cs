using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;

namespace NKNProject.Models
{
    public class TrackData : MongoDbEntity
    {
        [BsonElement(elementName: "TrackName")]
        public string TrackName { get; set; }
        [BsonElement(elementName: "TrackGenre")]
        public string TrackGenre { get; set; }
        [BsonElement(elementName: "TrackReleaseDate")]
        public DateTime? TrackReleaseDate { get; set; }
        [BsonElement(elementName: "TrackImg")]
        public Uri TrackImg { get; set; }
        [BsonElement(elementName: "TrackLinks")]
        public string TrackLinks { get; set; }
        [BsonElement(elementName: "TrackDescription")]
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
