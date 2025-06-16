using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Button
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
    }
}
