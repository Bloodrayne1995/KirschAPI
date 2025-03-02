using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Responses
{
    public class OutputResponse : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.OutputResponse;


        [RegularExpression("^(Timeout|OkButton|CancelButton|Error)$")]
        public string Code { get; set; } = "CancelButton";


        public static OutputResponse TimeoutResponse() => new() { Code = "Timeout" };
        public static OutputResponse OkResponse() => new() { Code = "OkButton" };
        public static OutputResponse CancelResponse() => new() { Code = "CancelButton" };
        public static OutputResponse ErrorResponse() => new() { Code = "Error" };

    }
}
