using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class GetPairingInformationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.GetPairingInformationRequest;
    
}