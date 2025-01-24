using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class SetVpnConfigurationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.SetVpnConfigurationRequest;
    
    [JsonPropertyName("useVpn")]
    [RegularExpression("^(off|tls|mschap)$")]
    public string UseVPN { get; init; } = "off";
    
    [JsonPropertyName("serverIpAddress")]
    [RegularExpression("(^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]).){3,3}(25[0-5]|(2[0\n\u21924]|1{0,1}[0-9]){0,1}[0-9])$)|(^$)")]
    public string ServerIpAddress { get; set; } = string.Empty;
    
    [JsonPropertyName("caCertPath")]
    [RegularExpression("(^-----BEGIN [A-Z ]{0,16}CERTIFICATE-----(\\n|\\r|\\r\\n)([0-9a-zA-Z+/\n \u2192=]{64}(\\n|\\r|\\r\\n))*([0-9a-zA-Z+/=]{1,63}(\\n|\\r|\\r\\n))?-----END [A-Z ]{0,16}\n \u2192CERTIFICATE-----(|\\n|\\r|\\r\\n){0,4}$)|($^)")]
    [MaxLength(102400)]
    public string CaCert { get; set; } = string.Empty;

    [JsonPropertyName("dpdDelay")]
    [Range(0,65535)]
    public int DpdDelay { get; set; } = 0;
    
    [JsonPropertyName("dpdTimeout")]
    [Range(0,65535)]
    public int DpdTimeout { get; set; } = 0;
    
    [JsonPropertyName("crlUri")]
    [RegularExpression("^((https?://[^\\\\\\\\,' ]+){1}(,(https?://[^\\\\\\\\,' ]+){1}){0,})$|(^$)")]
    [MaxLength(102400)]
    public string CrlUri {get;set;} = string.Empty;



}