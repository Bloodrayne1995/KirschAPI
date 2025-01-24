using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class SetVpnMschapConfigurationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.SetVpnMschapConfigurationRequest;
    
    
    private VpnMschapConfiguration _config; 
    
    [JsonPropertyName("mschapUsername")]
    public string Username => _config.Username;
    
    [JsonPropertyName("mschapPassword")]
    public string Password => _config.Password;
    
    [JsonPropertyName("mschapClientIdType")]
    public string ClientIdType => _config.ClientIdType;
    
    [JsonPropertyName("mschapClientIdText")]
    public string ClientIdText => _config.ClientIdText;
    
    
    
}