using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class ErrorData
    {
        [JsonPropertyName("details")]
        public string? Details { get; set; }
    }
}
