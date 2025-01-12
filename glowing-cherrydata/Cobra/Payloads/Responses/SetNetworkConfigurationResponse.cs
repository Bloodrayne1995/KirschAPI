using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads.Responses
{
    public class SetNetworkConfigurationResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.SetNetworkConfigurationResponse;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;
    }
}
