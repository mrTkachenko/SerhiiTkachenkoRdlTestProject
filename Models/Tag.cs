using Newtonsoft.Json;

namespace SerhiiTkachenkoTestRdl.Models
{
    public class Tag
    {
        public Tag()
        {

        }

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
