﻿using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Phone
    {
        [JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }
        
        [JsonPropertyName("wa_id")]
        public string? WaId { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
