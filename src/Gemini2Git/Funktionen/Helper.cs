using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Gemini2Git.Objekte;
using Gemini2Git.Models;

namespace Gemini2Git.Funktionen
{
    public static class Helper
    {
        /// <summary>
        /// Trennt ein Kopfzeile(Gemini-Eintrag) in den Schlüssel(Key) und den Titel
        /// </summary>
        /// <param name="kopfzeile">Gemini-Eintrag</param>
        /// <returns></returns>
        internal static string[] Split_Kopfzeile_in_Key_und_Titel(string kopfzeile)
        {
            string pattern = "(?<! - .*) - ";
            Regex rx = new Regex(pattern,
                    RegexOptions.IgnoreCase
               );

            return rx.Split(kopfzeile);
        }

        /// <summary>
        /// Trennt den Schlüssel(Key) in Projektkürzel und Nummer
        /// </summary>
        /// <param name="key">Schlüssel</param>
        /// <returns></returns>
        internal static string[] Split_Key_in_Projektkürzel_und_Nummer(string key)
        {
            string pattern = "(?<!-.*)-";
            Regex rx = new Regex(pattern,
                    RegexOptions.IgnoreCase
               );

            return rx.Split(key);
        }

        public static GeminiEintrag Extrahiere_GeminiEintrag(string kopfzeile)
        {
            string[] key_titel = Helper.Split_Kopfzeile_in_Key_und_Titel(kopfzeile);
            string[] projektkürzel_nummer = Helper.Split_Key_in_Projektkürzel_und_Nummer(key_titel[0]);

            return new GeminiEintrag(projektkürzel: projektkürzel_nummer[0]
                                        , nummer: projektkürzel_nummer[1]
                                        , key: key_titel[0]
                                        , titel: key_titel[1]);

        }


        public static List<GruppeNameWert>Liefere_GruppeNameWert(string filterGruppe, List<AttributWert> attributWerts, Konfig konfig)
        {
            return konfig.Gruppen
                            .Where(w => (w.Gruppe == filterGruppe || filterGruppe == null))
                            .SelectMany(x => x.Eintraege, (parent, child) =>
                                                    new GruppeNameWert(
                                                               gruppe: parent.Gruppe,
                                                               name: child.Name,
                                                               wert: AttributHelper.Ersetze_Liste_Werte(child.Wert, attributWerts)
                                                               )
                            ).ToList();
        }


        public static List<Gruppe> Liefere_Gruppen( Konfig konfig)
        {
            return konfig.Gruppen
                            .Select(x => new Gruppe(
                                                    gruppenName: x.Gruppe
                                                    )
                            ).ToList();
        }

    }
}
