using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class GetVpnInformationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.GetVpnInformationRequest;
    
}