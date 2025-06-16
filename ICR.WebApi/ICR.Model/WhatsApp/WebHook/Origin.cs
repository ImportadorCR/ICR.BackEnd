using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Origin
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
