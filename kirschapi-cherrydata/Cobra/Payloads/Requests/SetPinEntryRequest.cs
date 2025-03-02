using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class SetPinEntryRequest : ICobraPayload
    {

        public string GetPayLoadType() => CobraRequestType.SetPinEntryRequest;


        [JsonPropertyName("mode")]
        [RegularExpression("^(scrambled|unscrambled)$")]
        public string Mode { get; set; } = "scrambled";


    }
}
