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
using NKNProject.Helpers;

namespace NKNProject.Shared
{
    public class TracksModel : ComponentBase, ITracksModel
    {
        [Inject] private HttpClient Http { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        [Inject] private IDialogService DialogService { get; set; }
        protected List<TrackData> trackList;
        protected TrackData track = new TrackData();
        protected bool disabled = true;
        protected string searchString = null;

        protected override async Task OnInitializedAsync()
        {
            Http = new HttpClient()
            {
                BaseAddress = new Uri(Constants.BASE_ADDRESS)
            };
            await GetTrack();
        }

        public async Task GetTrack()
        {
            trackList = await Http?.GetJsonAsync<List<TrackData>>(Constants.API_PATH);
        }

        public async Task DeleteTrack(string id)
        {
            if (track != null && track.Id != string.Empty)
            {
                await Http.DeleteAsync(Constants.API_PATH + id);
            }
            else
            {
                Snackbar.Add("Error", Severity.Error);
            }
            Snackbar.Add("Track Deleted", Severity.Success);
            this.StateHasChanged();
            await GetTrack();
        }

        public bool FilterFunc(TrackData track)
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

        protected async Task OpenAddDialog(bool _disabled)
        {
            disabled = _disabled;
            var parameters = new DialogParameters { ["isAdd"] = _disabled };
            var dialog = DialogService.Show<DialogComponent>("Add Track", parameters);
            var result = await dialog.Result;

        }
        protected async Task OpenEditDialog(TrackData track, bool _disabled)
        {
            disabled = _disabled;
            var parameters = new DialogParameters { ["isEdit"] = _disabled, ["track"] = track };
            var dialog = DialogService.Show<DialogComponent>("Edit Track", parameters);
            var result = await dialog.Result;
        }
    }
}
