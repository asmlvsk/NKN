using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

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
        public string TrackImg { get; set; }
        [BsonElement(elementName: "TrackLinks")]
        public string TrackLinks { get; set; }
        [BsonElement(elementName: "TrackDescription")]
        public string TrackDescription { get; set; }
    }
}
