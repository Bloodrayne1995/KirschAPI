using Bloodrayne1995.GlowingSpark.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloodrayne1995.KirschAPI.Utils
{
    public static class DateUtils
    {


        public string GetDateForDevice(DateTime dt, DeviceEnum dType)
        {
            if (dType == DeviceEnum.Cherry)
            {
                return dt.ToString("yyyyMMdd");
            }
            return dt.ToShortDateString();

        }

        public DateTime GetDateFromString(string dtString, DeviceEnum dType)
        {
            if (dType == DeviceEnum.Cherry)
            {
                return DateTime.ParseExact(dtString, "yyyyMMdd");
            }
            return DateTime.MinValue; 
        }

    }


}
