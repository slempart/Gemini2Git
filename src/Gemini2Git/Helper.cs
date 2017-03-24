using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Gemini2Git
{
    public static class Helper
    {
        internal static string[] Split_Kopfzeile_in_ID_und_Titel(string kopfzeile)
        {
            string pattern = "(?<! - .*) - ";
            Regex rx = new Regex(pattern,
                    RegexOptions.IgnoreCase
               );

            return rx.Split(kopfzeile);
        }
    }
}
