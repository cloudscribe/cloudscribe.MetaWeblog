
using System;
using System.Globalization;

namespace cloudscribe.MetaWeblog
{
    public static class Utils
    {
        public static string GetDateTimeStringForFileName(bool includeMiliseconds = false)
        {
            var d = DateTime.Now;          

            var dateString = d.ToString("yyyyMMddhhmmss");
            if (includeMiliseconds)
            {
                return dateString + d.Millisecond.ToString("d3");
            }
            return dateString;
        }
       

        public static string ConvertDatetoISO8601(this DateTime date)
        {
            //produces e.g. 2020-01-04T13:13:52
            return date.ToString("s", CultureInfo.InvariantCulture);
        }

        //iso8601 often come in slightly different flavours rather than the standard "s" that string.format supports.
        //http://stackoverflow.com/a/17752389
        //static readonly string[] formats = { 
        //    // Basic formats
        //    "yyyyMMddTHHmmsszzz",
        //    "yyyyMMddTHHmmsszz",
        //    "yyyyMMddTHHmmssZ",
        //    // Extended formats
        //    "yyyy-MM-ddTHH:mm:sszzz",
        //    "yyyy-MM-ddTHH:mm:sszz",
        //    "yyyy-MM-ddTHH:mm:ssZ",
        //    "yyyyMMddTHH:mm:ss:zzz",
        //    "yyyyMMddTHH:mm:ss:zz",
        //    "yyyyMMddTHH:mm:ss:Z",
        //    "yyyyMMddTHH:mm:ss",
        //    // All of the above with reduced accuracy
        //    "yyyyMMddTHHmmzzz",
        //    "yyyyMMddTHHmmzz",
        //    "yyyyMMddTHHmmZ",
        //    "yyyy-MM-ddTHH:mmzzz",
        //    "yyyy-MM-ddTHH:mmzz",
        //    "yyyy-MM-ddTHH:mmZ",
        //    // Accuracy reduced to hours
        //    "yyyyMMddTHHzzz",
        //    "yyyyMMddTHHzz",
        //    "yyyyMMddTHHZ",
        //    "yyyy-MM-ddTHHzzz",
        //    "yyyy-MM-ddTHHzz",
        //    "yyyy-MM-ddTHHZ"
        //};

    }
}
