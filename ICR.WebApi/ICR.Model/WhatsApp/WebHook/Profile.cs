using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Profile
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
