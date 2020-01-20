using Newtonsoft.Json;

namespace setours.jarvis.transversal.common.Bases.Requests
{
    public class BaseApiRequest<TDataTransferObject>
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audit")]
        public BaseAuditRequest Audit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "data")]
        public TDataTransferObject Data { get; set; }
    }
}
