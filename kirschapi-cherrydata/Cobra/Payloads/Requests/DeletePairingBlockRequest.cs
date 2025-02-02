using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class DeletePairingBlockRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.DeletePairingBlockRequest;


    [JsonPropertyName("blockId")]
    [Range(0,3)]
    public int BlockId { get; set; } = 0;

    
    public DeletePairingBlockRequest(int blockId) => BlockId = blockId;

    public DeletePairingBlockRequest(PairingBlock x) => BlockId = x.Index;

}