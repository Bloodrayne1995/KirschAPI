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
    public class GetNetworkConfigurationRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.GetNetworkConfigurationRequest;


        [JsonPropertyName("interface")]
        [RegularExpression("^(ethernet|usbRndis|usbCdcEcm)$")]
        public string InterfaceName { get; set; } = "ethernet";


        public static GetNetworkConfigurationRequest Ethernet => new() { InterfaceName = "ethernet" };
        public static GetNetworkConfigurationRequest UsbRndis => new() { InterfaceName = "usbRndis" };
        public static GetNetworkConfigurationRequest UsbCdc => new() { InterfaceName = "usbCdcEcm" };



        protected GetNetworkConfigurationRequest() { }


    }
}
