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
    public class SetActiveInterfaceRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.SetActiveInterfaceRequest;

        [JsonPropertyName("activeInterface")]
        [RegularExpression("^(ethernet|usbRndis|usbCdcEcm)$")]
        public string ActiveInterface { get; private set; } = "ethernet";


        public static SetActiveInterfaceRequest Ethernet => new() { ActiveInterface = "ethernet" };
        public static SetActiveInterfaceRequest UsbRndis => new() { ActiveInterface = "usbRndis" };
        public static SetActiveInterfaceRequest UsbCdcEcm => new() { ActiveInterface = "usbCdcEcm" };


        private SetActiveInterfaceRequest() { }



    }
}
