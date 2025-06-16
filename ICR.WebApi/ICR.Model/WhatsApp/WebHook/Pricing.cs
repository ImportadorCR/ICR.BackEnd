﻿using System.Text.Json.Serialization;

namespace ICR.Model.WhatsApp.WebHook
{
    public class Pricing
    {
        [JsonPropertyName("billable")]
        public bool? Billable { get; set; }

        [JsonPropertyName("pricing_model")]
        public string? PricingModel { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }
    }

}
