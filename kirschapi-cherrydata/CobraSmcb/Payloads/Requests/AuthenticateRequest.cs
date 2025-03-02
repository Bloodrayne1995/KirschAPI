using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Requests
{
    public class AuthenticateRequest : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.AuthenticateRequest;

        [RegularExpression("^1.0$")]
        public string ApiVersion { get; set; } = "1.0";

        [RegularExpression("^[0-9a-f]{64}$")]
        public string Challenge { get; set; } = string.Empty;

    }
}
