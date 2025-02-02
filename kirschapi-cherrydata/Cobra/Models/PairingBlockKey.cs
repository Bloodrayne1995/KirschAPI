using System.Text.Json.Serialization;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

public class PairingBlockKey
{

    [JsonIgnore] public int Index { get; set; } = 0;
    [JsonIgnore] public int BlockIndex { get; set; } = 0;
    
    [JsonPropertyName("certificateFingerpring")]
    public string CertificateFingerprint { get; set; } = string.Empty;
    
    [JsonPropertyName("key")]
    public string Key { get; set; } = string.Empty;

    public PairingBlockKey(int index, int blockIndex)
    {
        Index = index;
        BlockIndex = blockIndex;
    }
    
}