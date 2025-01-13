using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra
{
    public class CobraHeader
    {
        [JsonPropertyName("msgId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string MessageId { get; set; } = string.Empty;

        [JsonPropertyName("inReplyToId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string InReplyToMessageId { get; set; } = string.Empty;

        [JsonPropertyName("sessionId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string SessionId { get; set; } = string.Empty;



    }
}
