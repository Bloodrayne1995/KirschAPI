using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class SetVpnTlsConfigurationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.SetVpnTlsConfigurationRequest;


    private VpnTlsConfiguration _config = null;
    
    [JsonPropertyName("clientCert")]
    [RegularExpression("\"(^-----BEGIN [A-Z ]{0,16}CERTIFICATE-----(\\n|\\r|\\r\\n)([0-9a-zA-Z+/\n \u2192=]{64}(\\n|\\r|\\r\\n))*([0-9a-zA-Z+/=]{1,63}(\\n|\\r|\\r\\n))?-----END [A-Z ]{0,16}\n \u2192CERTIFICATE-----( |\\n|\\r|\\r\\n){0,4}$)|($^)")]
    [MaxLength(102400)]
    public string ClientCertificate => _config.ClientCertificate;

    [JsonPropertyName("clientCertPrivateKey")]
    [RegularExpression("(^-----BEGIN [A-Z ]{0,16}PRIVATE KEY-----(\\n|\\r|\\r\\n)([0-9a-zA-Z+/\n \u2192=]{64}(\\n|\\r|\\r\\n))*([0-9a-zA-Z+/=]{1,63}(\\n|\\r|\\r\\n))?-----END [A-Z ]{0,16}\n \u2192PRIVATE KEY-----( |\\n|\\r|\\r\\n){0,4}$)|($^)")]
    [MaxLength(102400)]
    public string PrivateKey => _config.PrivateKey;

    [JsonPropertyName("tlsClientIdType")]
    [RegularExpression("^(fingerprint|subject)$")]
    public string TlsClientIdType => _config.TlsClientIdType;


    public SetVpnTlsConfigurationRequest(VpnTlsConfiguration config)
    {
        _config = config;
    }



}