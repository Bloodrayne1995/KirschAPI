using System.ComponentModel.DataAnnotations;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;

public class DisplaySettings
{

    [Range(0,3599)]
    public int Timeout { get; set; } = 0;

    [Range(10,100)]
    public int Brightness { get; set; } = 10;
    
    [RegularExpression(@"^(on|off)$")]
    public string TouchSound { get; set; } = "off";

}