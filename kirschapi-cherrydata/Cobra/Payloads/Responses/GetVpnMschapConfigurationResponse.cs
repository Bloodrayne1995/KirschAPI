using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class GetVpnMschapConfigurationResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.GetVpnMschapConfigurationRequest;
    
    private VpnMschapConfiguration _config = new();
    
    [JsonPropertyName("error")]
    public string Error { get; set; } = string.Empty;

    [JsonPropertyName("mschapUsername")]
    [RegularExpression("(^[^\\\\t\\\\r\\\\n\\\\v\\\\f]{0,511}[^\\\\t\\\\r\\\\n\\\\v\\\\f ]$)|(^$)")]
    public string Username
    {
        get => _config.Username;
        set => _config.Username = value;
    }

    [JsonPropertyName("mschapClientIdType")]
    [RegularExpression("^(off|serialnumber|text)$")]
    public string ClientIdType
    {
        get => _config.ClientIdType;
        set => _config.ClientIdType = value;
    }

    [JsonPropertyName("mschapClientIdText")]
    [RegularExpression("^[-~]{1,256}$")]
    public string ClientIdText
    {
        get => _config.ClientIdText;
        set => _config.ClientIdText = value;
    }
    
    
    
    
}