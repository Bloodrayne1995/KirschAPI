using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class SetLoginCredentials : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.SetLoginCredentialsRequest;
    
    [JsonPropertyName("username")]
    [RegularExpression("^admin$")]
    public string Username{get; set;} = "admin";
    
    [JsonPropertyName("adminPassword")]
    [MaxLength(256)]
    public string AdminPassword { get; set; } = "";
    
    [JsonPropertyName("PasswordType")]
    [RegularExpression("^(remotemgmt|sicct)$")]
    public string PasswordType { get; set; } = "remotemgmt";
    
    [JsonPropertyName("passwordUser")]
    [MaxLength(256)]
    public string PasswordUser {get; set;} = "";
    
    [JsonPropertyName("newPassword")]
    [MaxLength(256)]
    public string NewPassword { get; set; } = "";
    
}