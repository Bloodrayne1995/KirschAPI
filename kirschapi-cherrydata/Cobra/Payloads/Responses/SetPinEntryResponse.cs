using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class SetPinEntryResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.SetPinEntryResponse;


        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;


    }
}
