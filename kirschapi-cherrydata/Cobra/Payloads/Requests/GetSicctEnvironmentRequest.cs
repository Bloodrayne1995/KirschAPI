using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class GetSicctEnvironmentRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.GetSicctEnvironmentRequest;


        [JsonPropertyName("which")]
        public SicctEnvironmentType Which { get; private set} = SicctEnvironmentType.Default;


        public static GetSicctEnvironmentRequest PU = new (SicctEnvironmentType.PU);
        public static GetSicctEnvironmentRequest TU = new (SicctEnvironmentType.TU);
        public static GetSicctEnvironmentRequest RU = new (SicctEnvironmentType.RU);
        public static GetSicctEnvironmentRequest SICCTLITE = new (SicctEnvironmentType.SICCTLITE);
        public static GetSicctEnvironmentRequest Default = new(SicctEnvironmentType.Default);



        public GetSicctEnvironmentRequest(SicctEnvironmentType env) {
            this.Which = env;
        }


    }
}
