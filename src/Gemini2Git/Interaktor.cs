using Gemini2Git.Funktionen;
using Gemini2Git.Models;
using Gemini2Git.Objekte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git
{
    public class Interaktor
    {


        public List<GruppeNameWert> Liefere_Git_Eintraege_für_Kopfzeile(string kopfzeile, string pfadKonfiguration, string filterGruppe)
        {
            List<GruppeNameWert> gruppeNameWerts = new List<GruppeNameWert>();
            // 1. Kopfzeile extrahieren
            GeminiEintrag geminiEintrag = Helper.Extrahiere_GeminiEintrag(kopfzeile);

            // 2. Attribute laden
            List<EigenschaftAttribut> eigenschaftAttributs = AttributHelper.Liefere_Liste_Attribute<GeminiEintrag>();

            // 3. Werte laden
            List<AttributWert> attributWerts = AttributHelper.Liefere_Liste_Werte<GeminiEintrag>(geminiEintrag, eigenschaftAttributs);

            // 4.Konfiguration laden
            Konfig konfig = KonfigHelper.Lade_Konfiguration(pfadKonfiguration);

            // 5.
            gruppeNameWerts = konfig.Gruppen
                .Where(w => (w.Gruppe == filterGruppe || filterGruppe == null))
                .SelectMany(x => x.Eintraege, (parent, child) => 
                                        new GruppeNameWert(
                                                   gruppe: parent.Gruppe,
                                                   name: child.Name,
                                                   wert: AttributHelper.Ersetze_Liste_Werte(child.Wert, attributWerts)
                                                   )
                ).ToList();

            
            return gruppeNameWerts;
        }
    }
}
