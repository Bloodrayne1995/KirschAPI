﻿using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class DeletePinpadPairingRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.DeletePinpadPairingRequest;



    }
}
