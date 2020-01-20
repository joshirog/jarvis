using Newtonsoft.Json;

namespace setours.jarvis.transversal.common.Bases.Requests
{
    public class BaseAuditRequest
    {
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

        [JsonProperty(PropertyName = "brwoser")]
        public string Browser { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
    }
}
