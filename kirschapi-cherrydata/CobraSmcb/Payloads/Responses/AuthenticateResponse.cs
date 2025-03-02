using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Responses
{
    public class AuthenticateResponse : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.AuthenticateResponse;


        [RegularExpression("^[0-9a-f]{32}")]
        public string Response {  get; set; } = string.Empty;


    }
}
