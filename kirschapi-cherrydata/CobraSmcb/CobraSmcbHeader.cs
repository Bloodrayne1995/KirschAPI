using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb
{
    public class CobraSmcbHeader
    {

        [JsonPropertyName("MsgId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string MessageId { get; set; } = string.Empty;

        [JsonPropertyName("InReplyToId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string InReplyToMessageId { get; set; } = string.Empty;

        [JsonPropertyName("SessionId")]
        [RegularExpression("[0-9a-f]{32}")]
        public string SessionId { get; set; } = string.Empty;

    }
}
