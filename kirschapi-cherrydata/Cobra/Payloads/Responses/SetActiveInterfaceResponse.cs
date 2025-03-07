﻿using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class SetActiveInterfaceResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.SetActiveInterfaceResponse;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;

    }
}
