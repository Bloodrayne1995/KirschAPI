using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class GetNetworkConfigurationResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetNetworkConfigurationResponse;

        private NetworkInformation networkInformation = new();



        [JsonPropertyName("interface")]
        public string InterfaceName
        {
            get => networkInformation.InterfaceName.ToString();
            set => networkInformation.InterfaceName = (NetworkInterface)Enum.Parse(typeof(NetworkInterface), value);
        }

        [JsonPropertyName("useDhcp")]
        public bool UseDhcp
        {
            get => networkInformation.UseDhcp;
            set => networkInformation.UseDhcp = value;
        }

        [JsonPropertyName("networkMode")]
        [RegularExpression("^(Dhcp|StaticIp|Rfc3927)$")]
        public string NetworkMode
        {
            get => networkInformation.NetworkMode.ToString();
            set => networkInformation.NetworkMode = (NetworkMode)Enum.Parse(typeof(NetworkMode), value);
        }

        [JsonPropertyName("ipAddress")]
        [RegularExpression(
            "(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string IpAddress
        {
            get => networkInformation.IpAddress; 
            set => networkInformation.IpAddress = value;
        }

        [JsonPropertyName("ipNetmask")]
        [RegularExpression(
            "(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string IpNetmask
        {
            get => networkInformation.IpMask; 
            set => networkInformation.IpMask = value;
        }

        [JsonPropertyName("dns1")]
        [RegularExpression(
            "(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Dns1
        {
            get => networkInformation.Dns1; 
            set => networkInformation.Dns1 = value;
        }

        [JsonPropertyName("dns2")]
        [RegularExpression(
            "(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Dns2
        {
            get => networkInformation.Dns2; 
            set => networkInformation.Dns2 = value;
        }

        [JsonPropertyName("gateway")]
        [RegularExpression(
            "(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\r\n→4]|1{0,1}[0-9]){0,1}[0-9]))|(^$)")]
        public string Gateway
        {
            get => networkInformation.Gateway; 
            set => networkInformation.Gateway = value;
        } 


    }
}
