using FluentValidation.Results;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Responses
{
    public class BaseApiResponse<TDataTransferObject>
    {
        public bool IsSuccess { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TDataTransferObject Data { get; set; }

        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Exception { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ValidationFailure> ValidationErrors { get; set; }
    }
}
