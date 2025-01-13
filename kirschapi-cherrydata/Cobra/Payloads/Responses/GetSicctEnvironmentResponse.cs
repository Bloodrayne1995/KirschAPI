using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Responses
{
    public class GetSicctEnvironmentResponse : ICobraPayload
    {
        public string GetPayLoadType() => CobraResponseType.GetSicctEnvironmentResponse;

        [JsonPropertyName("error")]
        public string Error {  get; set; }  = string.Empty;


        [JsonPropertyName("pu")]
        public SicctEnvironment? Productive { get; set; } = null;

        [JsonPropertyName("ru")]
        public SicctEnvironment? Reference { get; set; } = null;

        [JsonPropertyName("tu")]
        public SicctEnvironment? Test { get; set; } = null;

        [JsonPropertyName("sicctlite")]
        public SicctEnvironment? SicctLite { get; set; } = null;


        [JsonIgnore]
        public SicctEnvironment? PU => Productive;

        [JsonIgnore]
        public SicctEnvironment? RU => Reference;

        [JsonIgnore]
        public SicctEnvironment? TU => Test;


    }
}
