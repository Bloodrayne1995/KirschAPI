using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra
{
    /// <summary>
    /// Standard-Anfrage für die Cobra-Schnittstelle
    /// </summary>
    public class CobraMessage
    {

        [JsonPropertyName("header")]
        public CobraHeader Header { get; private set; } = new();

        [JsonPropertyName("payload")]
        public ICobraPayload? Payload { get; set; } = null;

        [JsonPropertyName("payloadType")]
        public string? PayloadType => Payload?.GetPayLoadType();

    }
}
