using Bloodrayne1995.KirschAPI.CherryData.Cobra.Models;
using Bloodrayne1995.KirschAPI.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.CherryData.Cobra.Payloads.Requests
{
    public class SetServiceAnnouncementRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.SetServiceAnnouncementRequest;


        public ServiceAnnouncement ServiceAnnouncement { get; private set; } = new();

        public SetServiceAnnouncementRequest(ServiceAnnouncement s)
        {
            ServiceAnnouncement = s;
        }



        [JsonPropertyName("active")]
        public string Active
        {
            get => ServiceAnnouncement.Active;
            set => ServiceAnnouncement.Active = value;
        }

        [JsonPropertyName("interval")]
        public int Interval
        {
            get => ServiceAnnouncement.Interval;
            set => ServiceAnnouncement.Interval = value;
        }

        [JsonPropertyName("unicast")]
        public string Unicast
        {
            get => ServiceAnnouncement.Unicast;
            set => ServiceAnnouncement.Unicast = value;
        }


        [JsonPropertyName("unicastPort")]
        public int UnicastPort
        {
            get => ServiceAnnouncement.UnicastPort;
            set => ServiceAnnouncement.UnicastPort = value;
        }

        [JsonPropertyName("unicastIp")]
        public string UnicastIp
        {
            get => ServiceAnnouncement.UnicastIp;
            set => ServiceAnnouncement.UnicastIp = value;
        }


    }
}
