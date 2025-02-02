namespace Bloodrayne1995.KirschAPI.CherryData.Enums;

public enum UpdateState : int
{
    Unknown = 0,
    Idle = 1,
    IdleSignature = 2,
    IdleVersion = 4,
    BusyRemote = 8,
    BusyUpload = 16,
    BusySICCT = 32,
    BusyData = 64,
    BusyReboot = 128,
    BusyGracePeriod = 256,
    
    
}