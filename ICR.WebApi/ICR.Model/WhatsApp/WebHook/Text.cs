using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Text
    {
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
