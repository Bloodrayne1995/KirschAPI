using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Requests
{
    public class InputPinRequest : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.InputPinRequest;

        [RegularExpression("^Slot [1234]$")]
        public string Slot { get; set; } = "Slot 1";

        [RegularExpression("^([0-9a-f][0-9a-f])+$")]
        public string Atr {  get; set; } = string.Empty;


        public string Prompt {  get; set; } = string.Empty;

        public string Message {  get; set; } = string.Empty;

        [RegularExpression("^Validate$")]
        public string MessageType {  get; set; } = "Validate";

        [Range(0,int.MaxValue)]
        public int MinLen { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int MaxLen { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int TimeoutFirst { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int TimeoutOther { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int TimeoutAll { get; set; } = 0;

        public bool OkButton { get; set; } = false;

        public bool CancelButton { get; set; } = false;



    }
}
