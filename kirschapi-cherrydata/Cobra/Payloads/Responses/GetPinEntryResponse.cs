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
    public class GetPinEntryResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetPinEntryResponse;


        [JsonPropertyName("error")]
        public string Error { get; set; }   = string.Empty;


        [JsonPropertyName("mode")]
        [RegularExpression("^(scrambled|unscrambled)$")]
        public string Mode { get; set; } = "scrambled";


    }
}
