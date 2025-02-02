using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class GetPairingInformationResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.GetPairingInformationResponse;
    
    [JsonPropertyName("pairingBlocks")]
    public PairingBlockList PairingBlocks {get; set;} = new PairingBlockList(); 
    
}