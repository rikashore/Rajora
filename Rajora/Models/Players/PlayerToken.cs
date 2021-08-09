using Newtonsoft.Json;

namespace Rajora
{
    public class PlayerToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public PlayerToken(string token)
        {
            Token = token;
        }
    }
}