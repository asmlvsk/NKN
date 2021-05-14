using NKNProject.Models;
using System.Threading.Tasks;

namespace NKNProject.Shared
{
    public interface ITracksModel
    {
        Task DeleteTrack(string id);
        bool FilterFunc(TrackData track);
        Task GetTrack();
    }
}