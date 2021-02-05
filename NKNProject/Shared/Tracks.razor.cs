using Microsoft.AspNetCore.Components;
using NKNProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace NKNProject.Shared
{
    public class TracksModel : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected List<TrackData> trackList;

        protected TrackData track = new TrackData();
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;

        protected string SearchString { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetTrack();
        }

        protected async Task GetTrack()
        {
            trackList = await Http.GetJsonAsync<List<TrackData>>("https://localhost:44338/api/Tracks");
        }

        protected void AddTrack()
        {
            track = new TrackData();
            this.modalTitle = "Add Track";
            this.isAdd = true;
        }

        protected async Task EditTrack(string id)
        {
            track = await Http.GetJsonAsync<TrackData>("https://localhost:44338/api/Tracks/" + id);
            this.modalTitle = "Edit Track";
            this.isAdd = true;
        }

        protected async Task SaveTrack()
        {
            if (track.Id != null)
            {
                await Http.PutJsonAsync("/tracks/Edit", track);
            }
            else
            {
                await Http.PostJsonAsync("/tracks/Create", track);
            }
            this.isAdd = false;
            await GetTrack();
        }

        protected async Task DeleteConfirm(string id)
        {
            track = await Http.GetJsonAsync<TrackData>("/tracks/Details" + id);

            this.isDelete = true;
        }

        protected async Task DeleteTrack(string id)
        {
            await Http.DeleteAsync("/tracks/Delete/" + id);

            this.isDelete = false;
            await GetTrack();
        }

        protected void CloseModal()
        {
            this.isDelete = false;
            this.isAdd = false;
        }
    }
}
