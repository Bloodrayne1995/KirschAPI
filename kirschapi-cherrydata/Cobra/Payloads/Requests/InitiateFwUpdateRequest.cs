using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class InitiateFwUpdateRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.InitiateFwUpdateRequest;
    
    [JsonPropertyName("updateUrl")]
    [MaxLength(256)]
    [RegularExpression("^https?://.+")]
    public string UpdateUrl {get ; set;} = "https://";
}