using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class GetVpnTlsConfigurationResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.GetVpnTlsConfigurationResponse;

    private VpnTlsConfiguration _intern = new();
    
    [JsonPropertyName("error")]
    public string Error {get; set;} = string.Empty;

    [JsonPropertyName("clientCert")]
    [RegularExpression(
        "(^-----BEGIN [A-Z ]{0,16}CERTIFICATE-----(\\n|\\r|\\r\\n)([0-9a-zA-Z+/\n \u2192=]{64}(\\n|\\r|\\r\\n))*([0-9a-zA-Z+/=]{1,63}(\\n|\\r|\\r\\n))?-----END [A-Z ]{0,16}\n \u2192CERTIFICATE-----( |\\n|\\r|\\r\\n){0,4}$)|($^)")]
    [MinLength(32)]
    [MaxLength(102400)]
    public string ClientCertificate
    {
        get => _intern.ClientCertificate;
        set => _intern.ClientCertificate = value;
    }

    [JsonPropertyName("tlsClientIdType")]
    [RegularExpression("^(fingerprint|subject)$")]
    public string TlsClientIdType
    {
        get => _intern.TlsClientIdType;
        set => _intern.TlsClientIdType = value;
    }

}