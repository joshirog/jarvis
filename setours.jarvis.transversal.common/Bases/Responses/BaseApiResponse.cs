using FluentValidation.Results;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Responses
{
    public class BaseApiResponse<TDataTransferObject>
    {
        [JsonProperty(PropertyName = "is_success")]
        public bool IsSuccess { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "data")]
        public TDataTransferObject Data { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exception")]
        public string Exception { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "validation_errors")]
        public IEnumerable<ValidationFailure> ValidationErrors { get; set; }
    }
}
