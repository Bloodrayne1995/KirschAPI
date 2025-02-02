using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses;

public class GetUpdateStateResponse : ICobraPayload
{
    public string GetPayLoadType() => CobraResponseType.GetUpdateStateResponse;

    [JsonIgnore]
    public UpdateState StateEnum { get; set; } = UpdateState.Unknown;

    [JsonPropertyName("state")]
    public string State
    {
        get => StateEnum.ToString();
        set 
        {
            switch (value.ToLower())
            {
                case "idle":
                    StateEnum = UpdateState.Idle;
                    break;
                case "idle (invalid signature)":
                    StateEnum = UpdateState.IdleSignature;
                    break;
                case "idle (invalid version)":
                    StateEnum = UpdateState.IdleVersion;
                    break;
                case "busy (remote management)":
                    StateEnum = UpdateState.BusyRemote;
                    break;
                case "busy (remote management upload)":
                    StateEnum = UpdateState.BusyUpload;
                    break;
                case "busy (sicct)":
                    StateEnum = UpdateState.BusySICCT;
                    break;
                case "busy (writing data)":
                    StateEnum = UpdateState.BusyData;
                    break;
                case "busy (waiting for reboot)":
                    StateEnum = UpdateState.BusyReboot;
                    break;
                case "busy (grace period)":
                    StateEnum = UpdateState.BusyGracePeriod;
                    break;
                default:
                    StateEnum = UpdateState.Unknown;
                    break;
            }
        }
    }
    
    
    [JsonPropertyName("error")]
    public string Error {get;set;} = string.Empty;
    
}