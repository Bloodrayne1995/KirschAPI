using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class GetVpnInformationResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.GetVpnInformationResponse;
    
    [JsonPropertyName("error")]
    public string Error  { get; set; } = string.Empty;
    
    [JsonPropertyName("useVpn")]
    [RegularExpression("^(off|tls|mschap)$")]
    public string UseVpn { get; set; } = "off";
    
    [JsonPropertyName("serverIpAddress")]
    [RegularExpression("\"(^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\n\u21924]|1{0,1}[0-9]){0,1}[0-9])$)|(^$)")]
    public string ServerIpAddress { get; set; } = string.Empty;
    
    [JsonPropertyName("serverCertFp")]
    [RegularExpression("(^[0-9A-F]{2}(:[0-9A-F]{2}){31}$)|(^$)")]
    public string ServerCertFps { get; set; } = string.Empty;
    
    [JsonPropertyName("clientCertFp")]
    [RegularExpression("(^[0-9A-F]{2}(:[0-9A-F]{2}){31}$)|(^$)")]
    public string ClientCertFp { get; set; } = string.Empty;

    [JsonPropertyName("caCertFp")]
    [RegularExpression("(^[0-9A-F]{2}(:[0-9A-F]{2}){31}$)|(^$)")]
    public string CaCertFps { get; set; } = string.Empty;

    [JsonPropertyName("serverCertSubject")]
    public string ServerCertSubject { get; set; } = string.Empty;
    
    [JsonPropertyName("clientCertSubject")]
    public string ClientCertSubject { get; set; } = string.Empty;
    
    [JsonPropertyName("caCertSubject")]
    public string CaCertSubject { get; set; } = string.Empty;
    
    [JsonPropertyName("mschapUsername")]
    [RegularExpression("(^[^\\\\t\\\\r\\\\n\\\\v\\\\f]{0,511}[^\\\\t\\\\r\\\\n\\\\v\\\\f ]$)|(^$)")]
    public string MsChapUsername { get; set; } = string.Empty;
    
    [JsonPropertyName("crlUri")]
    [RegularExpression("^((https?://[^\\\\\\\\,' ]+){1}(,(https?://[^\\\\\\\\,' ]+){1}){0,})$|(^$)")]
    [MaxLength(102400)]
    public string CrlUri { get; set; } = string.Empty;

    [JsonPropertyName("dpdDelay")]
    [Range(0,65535)]
    public int DpdDelay { get; set; } = 0;

    [JsonPropertyName("dpdTimeout")]
    [Range(0,65535)]
    public int DpdTimeout { get; set; } = 0;
    
    [JsonPropertyName("status")]
    [RegularExpression("^(up|down|off)$|(^$)")]
    public string Status { get; set; } = "off";
    
    [JsonPropertyName("localIp")]
    [RegularExpression("(^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\n\u21924]|1{0,1}[0-9]){0,1}[0-9])$)|(^$)")]
    public string LocalIp { get; set; } = string.Empty;

}