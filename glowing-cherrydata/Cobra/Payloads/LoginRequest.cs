using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads
{
    public class LoginRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.LoginRequest;

        //TODO: Secure Credentials
        private NetworkCredential cred = null;


        [JsonPropertyName("username")]
        public  string Username
        {
            get
            {
                return cred.UserName;
            }
        }

        [JsonPropertyName("password")]
        public string Password
        {
            get
            {
                return cred.Password;
            }
        }


        public LoginRequest(NetworkCredential cred)
        {
            this.cred = cred;
        }

        public LoginRequest(string username, string password)
        {
            this.cred = new NetworkCredential(username, password);
        }
    }
}
