using System.Collections.Generic;
using Newtonsoft.Json;

namespace SerhiiTkachenkoTestRdl.Models
{
    public class Pet
    {
        public Pet()
        {

        }

        public Pet(int id, string name, Category category, List<string> photoUrls,
            List<Tag>tags, string status)
        {
            Id = id;
            Name = name;
            Category = category;
            PhotoUrls = photoUrls;
            Tags = tags;
            Status = status;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }

        [JsonProperty(PropertyName = "photoUrls")]
        public List<string> PhotoUrls { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
