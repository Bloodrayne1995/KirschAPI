using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class DeletePairingKeyRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.DeletePairingKeyRequest;

    [JsonPropertyName("blockId")]
    [Range(1,3)]
    public int BlockId { get; set; } = 0;
    
    [JsonPropertyName("keyId")]
    [Range(1,3)]
    public int KeyId { get; set; } = 0;


    public DeletePairingKeyRequest(PairingBlockKey key) : this(key.BlockIndex, key.Index){}

    public DeletePairingKeyRequest(PairingBlock block, int keyId) : this(block.Index, keyId) {}
    
    public DeletePairingKeyRequest(int blockId, int keyId)
    {
        BlockId = blockId;
        KeyId = keyId;
    }
    
}