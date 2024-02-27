using System.Text.Json.Serialization;

namespace s2.Models
{
    public class PersonLocation
    {
        [JsonPropertyName("personCode")]
        public long PersonCode { get; set; }
        [JsonPropertyName("personRole")]
        public string PersonRole { get; set; }
        [JsonPropertyName("lastSecurityPointNumber")]
        public long LastSecurityPointNumber { get; set; }
        [JsonPropertyName("lastSecurityPointDirection")]
        public string? LastSecurityPointDirection { get; set; }
        [JsonPropertyName("lastSecurityPointTime")]
        public DateTime LastSecurityPointTime { get; set; }
    }
}
