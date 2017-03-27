using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gemini2Git.Models;
using Newtonsoft.Json;

namespace Gemini2Git.Funktionen
{
    public static class KonfigHelper
    {
        internal static string GetRootedDirectoryPath(string path)
        {
            return Path.IsPathRooted(path) ? path.Replace("\\", "/") : Path.Combine(Environment.CurrentDirectory, path).Replace("\\", "/");
        }

        public static Konfig Lade_Konfiguration(string relativerPfad)
        {
            string pfad = GetRootedDirectoryPath(relativerPfad);

            return JsonConvert.DeserializeObject<Konfig>(File.ReadAllText(pfad));
        }
    }
}
