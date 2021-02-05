using MongoDB.Driver;
using NKNProject.Data;
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
        TrackDBContext db = new TrackDBContext();

        public List<TrackData> GetAllTracks()
        {
            try
            {
                return db.Tracks.Find(_ => true).ToList();
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
                await db.Tracks.InsertOneAsync(track);
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
                FilterDefinition<TrackData> filterDefinition = Builders<TrackData>.Filter.Eq("TrackId", trackId);
                return await db.Tracks.FindAsync(filterDefinition).Result.FirstOrDefaultAsync();
            }
            catch
            {

                throw;
            }
        }

        // Update
        public async void UpdateTrack(TrackData track)
        {
            try
            {
                await db.Tracks.ReplaceOneAsync(filter: g => g.Id == track.Id, replacement: track);
            }
            catch
            {

                throw;
            }
        }

        // Delete
        public async void DeleteTrack(string id)
        {
            try
            {
                FilterDefinition<TrackData> filterDefinition = Builders<TrackData>.Filter.Eq("TrackId", id);
                await db.Tracks.DeleteOneAsync(filterDefinition);
            }
            catch
            {

                throw;
            }
        }
    }
}
