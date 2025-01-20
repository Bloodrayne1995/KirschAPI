using Bloodrayne1995.KirschAPI.CherryData.Enums;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

public class NetworkInformation
{
    
    
    public NetworkInterface InterfaceName { get; set; } = NetworkInterface.Ethernet;

    public bool UseDhcp { get; set; } = false;

    public NetworkMode NetworkMode { get; set; } = NetworkMode.Undefined;
    
    public string IpAddress { get; set; } = string.Empty;
    
    public string IpMask { get; set; } = string.Empty;
    
    public string Dns1 { get; set; } = string.Empty;
    public string Dns2 { get; set; } = string.Empty;
    
    public string Gateway { get; set; } = string.Empty;
    


}