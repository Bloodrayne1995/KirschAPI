using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class SmcbAuthenticationResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.SmcbAuthenticationResponse;
    
    [JsonPropertyName("key")]
    [RegularExpression("^[0-9a-f]{64}$")]
    public string Key { get; set; } = "";
    
    
}