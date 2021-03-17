using Microsoft.Extensions.Configuration;
using SpotifyAPI.Web;
using System.Threading.Tasks;

namespace NKNProject.Models
{
    public class SpotifyBuilder
    {
        public IConfiguration Configuration { get; }

        public SpotifyBuilder(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<SpotifyClient> BuildClient()
        {
            var config = SpotifyClientConfig
              .CreateDefault()
              .WithAuthenticator(new ClientCredentialsAuthenticator(Configuration["SpotifySettings:ClientID"], Configuration["SpotifySettings:ClientSecret"]));
            return new SpotifyClient(config);
        }
    }
        
}
