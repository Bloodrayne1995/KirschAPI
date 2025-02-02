using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class SetRemotePinRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.SetRemotePinRequest;

    private RemotePinState slot1 = RemotePinState.Disabled;
    private RemotePinState slot2 = RemotePinState.Disabled;
    private RemotePinState slot3 = RemotePinState.Disabled;
    private RemotePinState slot4 = RemotePinState.Disabled;

    [JsonPropertyName("remotepin1")]
    public string RemotePin1
    {
        get => ((int)slot1).ToString();
        set => slot1 = (RemotePinState)Enum.Parse(typeof(RemotePinState), value);
    }

    [JsonPropertyName("remotepin2")]
    public string RemotePin2
    {
        get => ((int)slot2).ToString();
        set => slot2 = (RemotePinState)Enum.Parse(typeof(RemotePinState), value);
    }
    
    [JsonPropertyName("remotepin3")]
    public string RemotePin3
    {
        get => ((int)slot3).ToString();
        set => slot3 = (RemotePinState)Enum.Parse(typeof(RemotePinState), value);
    }
    
    [JsonPropertyName("remotepin4")]
    public string RemotePin4
    {
        get => ((int)slot4).ToString();
        set => slot4 = (RemotePinState)Enum.Parse(typeof(RemotePinState), value);
    }
    
}