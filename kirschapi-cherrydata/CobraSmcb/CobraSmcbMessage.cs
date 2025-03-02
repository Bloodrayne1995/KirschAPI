using Bloodrayne1995.KirschAPI.CherryData.Cobra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb
{
    public class CobraSmcbMessage
    {
        [JsonPropertyName("Header")]
        public CobraHeader Header { get; private set; } = new();

        [JsonPropertyName("Payload")]
        public ICobraSmcbPayload? Payload { get; set; } = null;

        [JsonPropertyName("PayloadType")]
        public string? PayloadType => Payload?.GetPayLoadType();
    }
}
