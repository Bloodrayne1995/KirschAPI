using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Responses
{
    public class InputPinResponse : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.InputPinResponse;



        [RegularExpression("^(Timeout|Pin|CancelButton|Error)$")]
        public string Code { get; set; } = "CancelButton";

        [RegularExpression("^[0-9]{0,64}$")]
        public string Pin {  get; set; } = string.Empty;


        public static InputPinResponse TimeoutResponse => new() { Code = "Timeout" };
        public static InputPinResponse PinResponse => new() { Code = "Pin" };
        public static InputPinResponse CancelResponse => new() { Code = "CancelButton" };
        public static InputPinResponse ErrorResponse => new() { Code = "Error" };

    }
}
