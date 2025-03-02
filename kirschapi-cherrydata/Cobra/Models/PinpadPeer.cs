using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models
{
    public class PinpadPeer
    {

        [JsonPropertyName("fwVersion")]
        public string FwVersion { get; set; } = string.Empty;

        [JsonPropertyName("hwVersion")]
        public string HwVersion { get; set; } = string.Empty;


        [JsonPropertyName("macAddress")]
        public string MacAddress {  get; set; } = string.Empty;

    }
}
