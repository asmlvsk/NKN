using Microsoft.AspNetCore.Components;
using NKNProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using NKNProject.DataAccess;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;
using MudBlazor;

namespace NKNProject.Shared
{
    public class TracksModel : ComponentBase
    {
        [Inject] private HttpClient Http { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        protected List<TrackData> trackList;
        protected TrackData track = new TrackData();
        protected bool disabled = true;
        protected string searchString = null;
        
        protected override async Task OnInitializedAsync()
        {
            Http = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44338")
            };
            await GetTrack();
        }

        public async Task GetTrack()
        {            
            trackList = await Http?.GetJsonAsync<List<TrackData>>("/api/Tracks/");
        }

        protected async Task DeleteTrack(string id)
        {           
            if (track != null && track.Id != string.Empty)
            {
                await Http.DeleteAsync("/api/Tracks/" + id);
            }
            else
            {
                Snackbar.Add("Error", Severity.Error);
            }
            Snackbar.Add("Track Deleted", Severity.Success);
            this.StateHasChanged();
            await GetTrack();
        }

        protected bool FilterFunc(TrackData track)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (track.TrackGenre.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (track.TrackName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (track.TrackDescription.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{track.TrackReleaseDate}".Contains(searchString))
                return true;
            return false;
        }
    }
}
