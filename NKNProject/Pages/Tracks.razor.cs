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

namespace NKNProject.Shared
{
    public class TracksModel : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }

        protected List<TrackData> trackList;

        protected TrackData track = new TrackData();
        private TrackData selectedTrack = null;
        protected string modalTitle { get; set; }
        protected bool dialogIsOpen = false;
        protected bool _isEdit = false;
        protected bool snackBar = false;
        protected bool _isDelete = false;
        protected bool _isAdd = false;

        protected string SearchString { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Http.BaseAddress = new Uri("https://localhost:44338");
            await GetTrack();
        }

        protected async Task GetTrack()
        {            
            trackList = await Http.GetJsonAsync<List<TrackData>>("/api/Tracks/");
        }

        protected async Task DeleteTrack(string id)
        {           
            if (track != null && track.Id != string.Empty)
            {
                await Http.DeleteAsync("/api/Tracks/" + id);
            }
            snackBar = true;
            _isDelete = true;
            this.StateHasChanged();
            await GetTrack();
        }

        protected void OpenDialog(bool isEdit)
        {            
            _isEdit = isEdit;
            if (!_isEdit) 
            {
                track = new TrackData();                
            } 
            dialogIsOpen = true;
        }

        protected async Task OkClickAsync()
        {
            dialogIsOpen = false;
            if (!_isEdit) _ = Http.PostJsonAsync("/api/Tracks/", track);
            else _ = Http.PutJsonAsync("/api/Tracks/", track);
            StateHasChanged();
            await GetTrack();
        }

        protected void CloseModal()
        {
            dialogIsOpen = false;
        }

        protected void SelectionChanged(object tr)
        {
            var currentTrack = (TrackData)tr;
            if (currentTrack != null)
            {
                track = currentTrack;
                selectedTrack = new TrackData(
                    currentTrack.Id,
                    currentTrack.TrackName,
                    currentTrack.TrackGenre,
                    currentTrack.TrackDescription,
                    currentTrack.TrackReleaseDate);
            }
            else
            {
                selectedTrack = new TrackData();
            }
            if (_isDelete) _ = this.DeleteTrack(selectedTrack.Id);
        }
    }
}
