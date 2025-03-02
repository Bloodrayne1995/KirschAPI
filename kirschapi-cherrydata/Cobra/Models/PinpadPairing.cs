using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models
{
    public class PinpadPairing
    {


        [JsonPropertyName("fingerprint")]
        [RegularExpression("^[0-9a-fA-F]{96}$")]
        public string Fingerprint { get; set; } = string.Empty;

        [JsonPropertyName("lastIp")]
        [RegularExpression("(^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-\r\n˓→5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])$)|(^$)")]
        public string LastIp {  get; set; } = string.Empty;

        [JsonPropertyName("lastInterface")]
        [RegularExpression("^(local|extern)$")]
        public string LastInterface { get; set; } = string.Empty;

        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = string.Empty;


    }
}
