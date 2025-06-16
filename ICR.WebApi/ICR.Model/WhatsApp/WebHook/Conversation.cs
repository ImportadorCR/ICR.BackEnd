using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Conversation
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("expiration_timestamp")]
        public string? ExpirationTimestamp { get; set; }

        [JsonPropertyName("origin")]
        public Origin? Origin { get; set; }
    }
}
