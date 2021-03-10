namespace NKNProject.Models
{
    public interface ISpotifySettings
    {
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
    }
    public class SpotifySettings : ISpotifySettings
    {
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
    }
}
