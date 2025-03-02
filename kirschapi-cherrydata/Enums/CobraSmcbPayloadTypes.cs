using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Enums
{
    public static class CobraSmcbPayloadTypes
    {

        public static string Notify => "Notify";
        public static string Cancel => "Cancel";

        public static string AuthenticateRequest => "AuthenticateRequest";
        public static string AuthenticateResponse => "AuthenticateResponse";

        public static string OutputRequest => "OutputRequest";
        public static string OutputResponse => "OutputResponse";

        public static string InputPinRequest => "InputPinRequest";
        public static string InputPinResponse => "InputPinResponse";

    }
}
