using System.Text.Json.Serialization;

namespace s2.Models
{
    public class Responce
    {
        [JsonPropertyName("response")]
        public PersonLocation[] Response { get; set; }
    }
}
