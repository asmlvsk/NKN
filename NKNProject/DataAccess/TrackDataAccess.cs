using MongoDB.Bson;
using MongoDB.Driver;
using NKNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NKNProject.DataAccess
{
    // CRUD Options

    public class TrackDataAccess
    {
        private readonly IMongoCollection<TrackData> trackData;

        public TrackDataAccess(IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            trackData = database.GetCollection<TrackData>("Tracks");
        }

        public List<TrackData> GetAllTracks()
        {
            try
            {
                return trackData.Find(_ => true).ToList();
            }
            catch
            {

                throw;
            }
        }

        // Create
        public async Task AddTrack(TrackData track)
        {
            try
            {
                await trackData.InsertOneAsync(track);
            }
            catch
            {

                throw;
            }
        }

        // Read
        public async Task<TrackData> GetTrackData(string trackId)
        {
            try
            {
                FilterDefinition<TrackData> filterDefinition = Builders<TrackData>.Filter.Eq("Id", trackId);
                return await trackData.Find(filterDefinition).FirstOrDefaultAsync();
            }
            catch
            {

                throw;
            }
        }

        // Update
        public void UpdateTrack(TrackData track)
        {
            try
            {
                trackData.ReplaceOne(filter: g => g.Id == track.Id, replacement: track);
            }
            catch
            {

                throw;
            }
        }

        // Delete
        public async Task<bool> DeleteTrack(string id)
        {
            try
            {
                DeleteResult actionResult =  await trackData.DeleteOneAsync(Builders<TrackData>.Filter.Eq("Id", id));
                return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
            }
            catch
            {

                throw;
            }
        }
    }
}
