using System.Text.Json.Serialization;
using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class GetDisplaySettingsRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.GetDisplaySettingsRequest;
    
    
    
}