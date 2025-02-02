using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class DeletePairingKeyResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.DeletePairingKeyResponse;
    
    [JsonPropertyName("error")]
    public string Error { get; set;} = string.Empty;
}