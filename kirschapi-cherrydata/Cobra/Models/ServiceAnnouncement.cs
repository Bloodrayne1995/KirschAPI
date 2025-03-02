using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models
{
    public class ServiceAnnouncement
    {

        [JsonPropertyName("error")]
        public string Error {  get; set; } = string.Empty;

        [JsonPropertyName("active")]
        [RegularExpression("^(on|off)$")]
        public string Active { get; set; } = "off";

        [JsonPropertyName("interval")];
        [Range(1,30)]
        public int Interval { get; set; } = 1;

        [JsonPropertyName("unicast")]
        [RegularExpression("^(on|off)$")]
        public string Unicast { get; set; } = "off";

        [JsonPropertyName("unicastPort")]
        [Range(0,65535)]
        public int UnicastPort { get; set; } = 0;

        [JsonPropertyName("unicastIp")]
        [RegularExpression("(^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0-\r\n˓→4]|1{0,1}[0-9]){0,1}[0-9])$)|(^$)")]
        public string UnicastIp { get; set; } = "0.0.0.0";



    }
}
