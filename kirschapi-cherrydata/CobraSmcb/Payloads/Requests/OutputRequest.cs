using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads.Requests
{
    public class OutputRequest : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.OutputRequest;


        [RegularExpression("^Slot [1234]$")]
        public string Slot { get; set; } = "Slot 1";

        [RegularExpression("^([0-9a-f][0-9a-f])+$")]
        public string Atr {  get; set; } = string.Empty;


        public string Message {  get; set; } = string.Empty;

        [RegularExpression("^(PinConfirm|PinResult)$")]
        public string MessageType {  get; set; } = "PinConfirm";

        [RegularExpression("^(Info|Warning)$")]
        public string MessageCode { get; set; } = "Info";

        public int Timeout { get; set; } = 0;


        public bool OkButton { get; set; } = false;

        public bool CancelButton { get; set; } = false;

        public bool ExpectResponse { get; set; } = false;


        [JsonIgnore]
        public bool IsInfo => MessageCode.ToLower().Equals("info");

        [JsonIgnore]
        public bool IsWarning => !IsInfo;

        [JsonIgnore]
        public bool IsConfirm => MessageType.ToLower().Equals("pinconfirm");
        [JsonIgnore]
        public bool IsResult => !IsConfirm;


    }
}
