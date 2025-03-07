﻿using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class LoginResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.LoginResponse;


        [JsonPropertyName("error")]
        public string Error { get; init; } = string.Empty;

        [JsonPropertyName("sessionId")]
        public string SessionId { get; init;} = string.Empty;

    }
}
