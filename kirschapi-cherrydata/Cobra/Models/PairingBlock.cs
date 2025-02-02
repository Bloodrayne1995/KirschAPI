using System.Collections;
using System.Text.Json.Serialization;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

public class PairingBlock : IEnumerable<PairingBlockKey>
{

    [JsonIgnore]
    private List<PairingBlockKey> _pairingBlockKeys = null;

    [JsonIgnore] 
    public int Index { get; private set; } = 0;
    
    [JsonPropertyName("isUsed")]
    public bool IsUsed { get; set; } = false;




    [JsonPropertyName("key1")]
    public PairingBlockKey Key1
    {
        get => _pairingBlockKeys[0];
        set => _pairingBlockKeys[0] = value;
    }

    [JsonPropertyName("key2")]
    public PairingBlockKey Key2
    {
        get => _pairingBlockKeys[1];
        set => _pairingBlockKeys[1] = value;
    }
    
    [JsonPropertyName("key3")]
    public PairingBlockKey Key3
    {
        get => _pairingBlockKeys[2];
        set => _pairingBlockKeys[2] = value;
    }
    
    [JsonIgnore]
    public PairingBlockKey FirstKey => Key1;
    
    [JsonIgnore]
    public PairingBlockKey SecondKey => Key2;
    
    [JsonIgnore]
    public PairingBlockKey ThirdKey => Key3;


    public PairingBlock(int index)
    {
        Index = index;
        _pairingBlockKeys = new List<PairingBlockKey>();
        _pairingBlockKeys.Add(new PairingBlockKey(1,Index));
        _pairingBlockKeys.Add(new PairingBlockKey(2,Index));
        _pairingBlockKeys.Add(new PairingBlockKey(3,Index));
    }

    public IEnumerator<PairingBlockKey> GetEnumerator()
    {
        return _pairingBlockKeys.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}