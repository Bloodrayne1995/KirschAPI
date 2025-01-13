using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class GetNetworkConfigurationResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetNetworkConfigurationResponse;

        [JsonPropertyName("interface")]
        public string InterfaceName {  get; set; } = string.Empty;

        [JsonPropertyName("useDhcp")]
        public bool UseDhcp { get; set; }

        [JsonPropertyName("networkMode")]
        [RegularExpression("^(Dhcp|StaticIp|Rfc3927)$")]
        public string NetworkMode { get; set; } = string.Empty;

        [JsonPropertyName("ipAddress")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string IpAddress { get; set; } = string.Empty;

        [JsonPropertyName("ipNetmask")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string IpNetmask { get; set; } = string.Empty;

        [JsonPropertyName("dns1")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Dns1 { get; set; } = string.Empty;

        [JsonPropertyName("dns2")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Dns2 { get; set; } = string.Empty;

        [JsonPropertyName("gateway")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Gateway { get; set; } = string.Empty;


    }
}
