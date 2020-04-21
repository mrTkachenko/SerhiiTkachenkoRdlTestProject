using Newtonsoft.Json;

namespace SerhiiTkachenkoTestRdl.Models
{
    public class DeleteResponse
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
