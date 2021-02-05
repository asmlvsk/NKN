using MongoDB.Driver;
using NKNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKNProject.Data
{
    public class TrackDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public TrackDBContext()
        {
            var client = new MongoClient("mongodb+srv://Smail:FAzvgh3okwXbs9rz@krinzcluster.penh4.mongodb.net/NKNdb?retryWrites=true&w=majority");
            _mongoDatabase = client.GetDatabase("NKNdb");
        }

        public IMongoCollection<TrackData> Tracks
        {
            get
            {
                return _mongoDatabase.GetCollection<TrackData>("Tracks");
            }
        }
    }
}
