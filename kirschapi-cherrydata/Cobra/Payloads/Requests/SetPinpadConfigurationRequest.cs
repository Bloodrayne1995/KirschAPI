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
    public class SetPinpadConfigurationRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.SetPinpadConfigurationRequest;


        [JsonPropertyName("enabled")]
        [RegularExpression("^(enabled|disabled)$")]
        public string Enabled { get; set; } = "disabled";
    }
}
