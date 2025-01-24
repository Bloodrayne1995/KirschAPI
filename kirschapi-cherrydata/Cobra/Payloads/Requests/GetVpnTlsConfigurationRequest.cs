using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests;

public class GetVpnTlsConfigurationRequest : ICobraPayload
{
    public string GetPayLoadType() => CobraRequestType.GetVpnTlsConfigurationRequest;
    
}