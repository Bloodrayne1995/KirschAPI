using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads
{
    public class Cancel : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.Cancel;

        [RegularExpression("^[0-9a-f]{32}$")]
        public string RequestId { get; set; } = string.Empty;
    }
}
