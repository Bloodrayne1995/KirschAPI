using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models
{
    public class SicctEnvironment
    {

        [JsonPropertyName("version")]
        public string Version { get; set; }  = string.Empty;

        [JsonPropertyName("certs")]
        public List<SicctCertificate> Certificates { get; set; } = new();

        


    }
}
