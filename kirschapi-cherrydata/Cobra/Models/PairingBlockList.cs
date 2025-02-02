using System.Collections;
using System.Text.Json.Serialization;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

public class PairingBlockList : IEnumerable<PairingBlock>
{
    
    [JsonIgnore]
    private List<PairingBlock> _pairingBlocks = new List<PairingBlock>();

    [JsonPropertyName("pairingBlock1")]
    public PairingBlock Block1
    {
        get => _pairingBlocks[0];
        set => _pairingBlocks[0] = value;
    }

    [JsonPropertyName("pairingBlock2")]
    public PairingBlock Block2
    {
        get => _pairingBlocks[1];
        set => _pairingBlocks[1] = value;
    }

    [JsonPropertyName("pairingBlock3")]
    public PairingBlock Block3
    {
        get => _pairingBlocks[2];
        set => _pairingBlocks[2] = value;
    }

    public PairingBlockList()
    {
        _pairingBlocks.Add(new PairingBlock(1));
        _pairingBlocks.Add(new PairingBlock(2));
        _pairingBlocks.Add(new PairingBlock(3));
    }
    
    
    public IEnumerator<PairingBlock> GetEnumerator()
    {
        return _pairingBlocks.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    
}