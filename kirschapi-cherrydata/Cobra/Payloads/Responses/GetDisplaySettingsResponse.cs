using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class GetDisplaySettingsResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.GetDisplaySettingsResponse;
    
    [JsonPropertyName("error")]
    public string Error  { get; set; } = string.Empty;
    
    [JsonIgnore]
    public DisplaySettings Settings { get; set; } = new();

    [JsonPropertyName("timeout")]    
    public int Timeout
    {
        get => Settings.Timeout;
        set => Settings.Timeout = value;
    }

    [JsonPropertyName("brightness")]
    public int Brightness
    {
        get => Settings.Brightness;
        set => Settings.Brightness = value;
    }

    [JsonPropertyName("touchSound")]
    public string TouchSound
    {
        get => Settings.TouchSound;
        set => Settings.TouchSound = value;
    }

    
}