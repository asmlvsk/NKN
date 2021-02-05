using Microsoft.AspNetCore.Mvc;
using NKNProject.DataAccess;
using NKNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKNProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        TrackDataAccess dataAccess = new TrackDataAccess();
        // GET: api/<TracksController>
        public IEnumerable<TrackData> Get()
        {
            return dataAccess.GetAllTracks();
        }

        // GET api/<TracksController>/5
        [HttpGet("{id}")]
        public async Task<TrackData> Get(string id)
        {
            return await dataAccess.GetTrackData(id);
        }

        // POST api/<TracksController>
        [HttpPost]
        public async Task PostAsync([FromBody] TrackData trackData)
        {
            await dataAccess.AddTrack(trackData);
        }

        // PUT api/<TracksController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] TrackData trackData)
        {
            dataAccess.UpdateTrack(trackData);
        }

        // DELETE api/<TracksController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            dataAccess.DeleteTrack(id);
        }
    }
}
