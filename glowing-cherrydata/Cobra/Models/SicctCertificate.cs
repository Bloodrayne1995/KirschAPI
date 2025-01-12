using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Models
{
    public class SicctCertificate
    {

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("fingerprint")]
        [RegularExpression("^[0-9A-F]{64}$")]
        public string Fingerprint { get; set; } = string.Empty;

    }
}
