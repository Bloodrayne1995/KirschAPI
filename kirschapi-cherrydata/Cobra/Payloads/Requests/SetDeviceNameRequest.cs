using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class SetDeviceNameRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.SetDeviceNameRequest;


        [JsonPropertyName("deviceName")]
        [RegularExpression("^[-~]{1,32}$")]
        public string DeviceName { get; set; } = string.Empty;

        [JsonPropertyName("idleScreenMessage")]
        [RegularExpression("^[-~ÄäÖöÜüß§]{1,32}$")]
        public string IdleScreenMessage { get; set; } = string.Empty;


    }
}
