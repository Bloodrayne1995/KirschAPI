using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads.Responses
{
    public class GetDeviceInformationResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetDeviceInformationResponse;


        [JsonPropertyName("error")]
        public string Error {  get; set; } = string.Empty;


        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; } = string.Empty;

        [JsonPropertyName("productShortName")]
        public string ProductShortName {  get; set; } = string.Empty;

        [JsonPropertyName("hwVersion")]
        public string HardwareVersion {  get; set; } = string.Empty;

        [JsonPropertyName("productType")]
        public string ProductType {  get; set; } = string.Empty;

        [JsonPropertyName("productTypeVersion")]
        public string ProductTypeVersion {  get; set; } = string.Empty;

        [JsonPropertyName("fwVersion")]
        public string FirmwareVersion {  get; set; } = string.Empty;

        [JsonPropertyName("fwGroupVersion")]
        public string FirmwareGroupVersion {  get; set; } = string.Empty;

        [JsonPropertyName("buildVersion")]
        public string BuildVersion {  get; set; } = string.Empty;


        [JsonPropertyName("environment")]
        public string Environment {  get; set; } = string.Empty;

        [JsonPropertyName("activeInterface")]
        public string ActiveInterface {  get; set; } = string.Empty;

        [JsonPropertyName("useDhcp")]
        public bool UseDhcp {  get; set; } = false;

        //TODO: Enum ( Dhcp , StaticIp, Rfc3927)
        [JsonPropertyName("networkMode")]
        [RegularExpression("(Dhcp)|(StaticIp)|(Rfc3927)")]
        public string NetworkMode {  get; set; } = string.Empty;

        [JsonPropertyName("ipAddress")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0→4]|1{0,1}[0 - 9]){0,1}[0 - 9]))|(^$)")]
        public string IPAdress {  get; set; } = string.Empty;

        [JsonPropertyName("ipNetmask")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0→4]|1{0,1}[0 - 9]){0,1}[0 - 9]))|(^$)")]
        public string Netmask {  get; set; } = string.Empty;

        [JsonPropertyName("dns1")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0→4]|1{0,1}[0 - 9]){0,1}[0 - 9]))|(^$)")]
        public string DNS1 {  get; set; } = string.Empty;

        [JsonPropertyName("dns2")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0→4]|1{0,1}[0 - 9]){0,1}[0 - 9]))|(^$)")]
        public string DNS2 {  get; set; } = string.Empty;

        [JsonPropertyName("gateway")]
        [RegularExpression("(((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0→4]|1{0,1}[0 - 9]){0,1}[0 - 9]))|(^$)")]
        public string Gateway {  get; set; } = string.Empty;

        [JsonPropertyName("deviceName")]
        public string DeviceName {  get; set; } = string.Empty;

        [JsonPropertyName("idleScreenMessage")]
        public string IdleScreenMessage {  get; set; } = string.Empty;

        [JsonPropertyName("remotepin1")]
        public int RemotePin1 {  get; set; } = int.MinValue;

        [JsonPropertyName("remotepin2")]
        public int RemotePin2 {  get; set; } = int.MinValue;

        [JsonPropertyName("remotepin3")]
        public int RemotePin3 {  get; set; } = int.MinValue;

        [JsonPropertyName("remotepin4")]
        public int RemotePin4 {  get; set; } = int.MinValue;

        [JsonPropertyName("bootloaderVersion")]
        public string BootloaderVersion {  get; set; } = string.Empty;

        [JsonPropertyName("ethernetMacAddress")]
        [RegularExpression("([0-9a-f]{2})(:[0-9a-f]{2}){5}")]
        public string EthernetMacAddress {  get; set; } = string.Empty;

        [JsonPropertyName("usbMacAddress")]
        [RegularExpression("([0-9a-f]{2})(:[0-9a-f]{2}){5}")]
        public string UsbMacAddress {  get; set; } = string.Empty;

        [JsonPropertyName("usbHostMacAddress")]
        [RegularExpression("([0-9a-f]{2})(:[0-9a-f]{2}){5}")]
        public string UsbHostMacAddress {  get; set; } = string.Empty;

        [JsonPropertyName("smcktProductTypeVersion")]
        public string SmcktProductTypeVersion {  get; set; } = string.Empty;

        [JsonPropertyName("smcktSerialNumber")]
        public string SmcktSerialNumber {  get; set; } = string.Empty;

        [JsonPropertyName("smcktPersonalization")]
        [RegularExpression("(RSA)|(ECC)|(RSA,ECC)|(^$)")]
        public string SmcktPersonalization {  get; set; } = string.Empty;

        [JsonPropertyName("smcktExpirationDateAUT")]
        [RegularExpression("([0-9]{8})|(^$)")]
        public string SmcktExpirationDateAUT {  get; set; } = string.Empty;

        [JsonPropertyName("smcktExpirationDateAUT2")]
        [RegularExpression("([0-9]{8})|(^$)")]
        public string SmcktExpirationDateAUT2 {  get; set; } = string.Empty;

        [JsonPropertyName("smcktExpirationDateAUTD")]
        [RegularExpression("([0-9]{8})|(^$)")]
        public string SmcktExpirationDateAUTD {  get; set; } = string.Empty;



        


    }
}
