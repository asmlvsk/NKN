using NKNProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NKNProject.DataAccess
{
    public interface ITrackDataAccess
    {
        Task AddTrack(TrackData track);
        Task<bool> DeleteTrack(string id);
        List<TrackData> GetAllTracks();
        Task<TrackData> GetTrackData(string trackId);
        void UpdateTrack(TrackData track);
    }
}