using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads.Requests
{
    public class SetEnvironmentRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.SetEnvironmentRequest;

        [JsonPropertyName("environment")]
        [RegularExpression("^(PU|RU|TU)$")]
        public string Environment { get; set; } = "PU";

    }
}
