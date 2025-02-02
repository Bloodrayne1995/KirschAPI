using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class SetRemotePinResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.SetRemotePinResponse;
    
    [JsonPropertyName("error")]
    public string Error {get; set;} = string.Empty;
}