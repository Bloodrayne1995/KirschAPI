using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class GetPinpadInformationResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetPinpadConfigurationResponse;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;

        [JsonPropertyName("enabled")]
        [RegularExpression("^(enabled|disabled)$")]
        public string Enabled { get; set; } = "disabled";

        [JsonPropertyName("pairing")]
        public PinpadPairing Pairing { get; set; } = new();

        [JsonPropertyName("peer")]
        public PinpadPeer Peer { get; set; } = new();
    }
}
