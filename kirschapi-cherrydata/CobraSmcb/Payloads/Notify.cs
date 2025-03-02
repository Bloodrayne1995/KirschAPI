using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.CobraSmcb.Payloads
{
    public class Notify : ICobraSmcbPayload
    {
        public string GetPayLoadType() => CobraSmcbPayloadTypes.Notify;

        [Range(0,13)]
        public int Code { get; set; } = 0;


        public string GetCodeMessage()
        {
            switch (Code)
            {
                case 0:
                    return "Success";
                case 1:
                    return "ParserError";
                case 2:
                    return "AuthenticationRequired";
                case 3:
                    return "AuthenticationDenied";
                case 4:
                    return "InvalidSessionId";
                case 5:
                    return "InvalidMessageId";
                case 6:
                    return "InvalidInReplyToId";
                case 7:
                    return "MissingInReplyToId";
                case 8:
                    return "InvalidChallengeResponse";
                case 9:
                    return "MissingPin";
                case 10:
                    return "InvalidPin";
                case 11:
                    return "InvalidPinLength";
                case 12:
                    return "UnexpectedPin";
                case 13:
                    return "InvalidOutputCode";

            }
            return "unknown";
        }


        public string GetCodeInterpretation()
        {
            switch (Code)
            {
                case 0:
                    return "All good";
                case 1:
                    return "Failed to decode JSON data";
                case 2:
                    return "Message requires authentication";
                case 3:
                    return "Authentication not successful";
                case 4:
                    return "Invalid SessionId field";
                case 5:
                    return "Invalid or missing MessageId field";
                case 6:
                    return "Invalid InReplyToId field";
                case 7:
                    return "Missing InReplyToId field";
                case 8:
                    return "Invalid InvalidChallengeResponse field";
                case 9:
                    return "Missing Pin field";
                case 10:
                    return "Invalid Pin field";
                case 11:
                    return "Invalid Pin length";
                case 12:
                    return "Pin field present, but not expected";
                case 13:
                    return "The code from a output response was invalid";
            }
            return "unknown";
        }


    }
}
