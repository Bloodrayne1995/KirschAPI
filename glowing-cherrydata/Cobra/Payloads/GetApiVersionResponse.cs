using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads
{
    public class GetApiVersionResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetApiVersionResponse;

        [JsonPropertyName("id")]
        public string ApiVersion { get; init; } = string.Empty;

    }
}
