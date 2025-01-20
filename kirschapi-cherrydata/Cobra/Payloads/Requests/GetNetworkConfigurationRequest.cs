using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class GetNetworkConfigurationRequest : ICobraPayload
    {

        private NetworkInformation networkInformation = new();
        
        public string GetPayLoadType() => CobraRequestType.GetNetworkConfigurationRequest;


        [JsonPropertyName("interface")]
        [RegularExpression("^(ethernet|usbRndis|usbCdcEcm)$")]
        public string InterfaceName
        {
            get => networkInformation.InterfaceName.ToString();
            set => networkInformation.InterfaceName = (NetworkInterface)Enum.Parse(typeof(NetworkInterface), value);
        }

        [JsonIgnore]
        public NetworkInformation Information
        {
            get => networkInformation;
            set => networkInformation = (NetworkInformation)value;
        }


        public static GetNetworkConfigurationRequest Ethernet => new() { InterfaceName = NetworkInterface.Ethernet.ToString() };
        public static GetNetworkConfigurationRequest UsbRndis => new() { InterfaceName = NetworkInterface.UsbRndis.ToString() };
        public static GetNetworkConfigurationRequest UsbCdc => new() { InterfaceName = NetworkInterface.UsbCdcEcm.ToString() };
        
        
        


        protected GetNetworkConfigurationRequest() { }


    }
}
