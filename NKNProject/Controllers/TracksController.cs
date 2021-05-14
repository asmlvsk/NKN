using Microsoft.AspNetCore.Mvc;
using NKNProject.DataAccess;
using NKNProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NKNProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private readonly TrackDataAccess _dataAccess;
        public TracksController(TrackDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        // GET: api/<TracksController>
        [HttpGet]
        public IEnumerable<TrackData> GetTracks()
        {
            return _dataAccess.GetAllTracks();
        }

        // GET api/<TracksController>/5
        [HttpGet("{id}")]
        public async Task<TrackData> GetTrack(string id)
        {
            return await _dataAccess.GetTrackData(id) ?? new TrackData();
        }

        // POST api/<TracksController>
        [HttpPost]
        public void AddTrack([FromBody] TrackData trackData)
        {
            _ = _dataAccess.AddTrack(new TrackData
            {
                Id = trackData.Id,
                TrackName = trackData.TrackName,
                TrackGenre = trackData.TrackGenre,
                TrackDescription = trackData.TrackDescription,
                TrackReleaseDate = trackData.TrackReleaseDate,
                TrackImg = trackData.TrackImg,
                TrackLinks = trackData.TrackLinks
            });
        }

        // PUT api/<TracksController>/5
        [HttpPut]
        public void UpdTrack([FromBody] TrackData trackData)
        {
             _dataAccess.UpdateTrack(trackData);
        }

        // DELETE api/<TracksController>/5
        [HttpDelete("{id}")]
        public void DeleteTrack(string id)
        {
            _ = _dataAccess.DeleteTrack(id);
        }

    }
}
