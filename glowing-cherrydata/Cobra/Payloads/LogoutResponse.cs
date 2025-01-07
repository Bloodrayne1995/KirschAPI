using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads
{
    public class LogoutResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.LogoutResponse;
    }
}
