using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Gemini2Git.Objekte;
using equalidator;

namespace Gemini2Git.Test
{
    [TestClass]
    public class T_Interaktor
    {
        /// <summary>
        /// Extrahiere aus der Kopfzeile alle Git-Einträge
        /// </summary>
        [TestMethod, TestCategory("Interaktor")]
        public void Liefere_Git_Eintraege_für_Kopfzeile()
        {
            List<GruppeNameWert> expected = new List<GruppeNameWert>()
                {
                    new GruppeNameWert("Branches", "features", "features/issue_123456_Prj")
                  , new GruppeNameWert("Branches", "bug",  "bug/issue_123456_Prj")
                  , new GruppeNameWert("Branches", "hotfix",  "hotfix/issue_123456_Prj")
                };

            string kopfzeile = "Prj-123456 - Dies ist ein Projekt";
            string pfadKonfiguration = "Testdaten/Konfiguration.json";
            string filterGruppe = "Branches";


            Interaktor ia = new Interaktor();
            var actual = ia.Liefere_Git_Eintraege_für_Kopfzeile(kopfzeile, pfadKonfiguration, filterGruppe);
            Equalidator.AreEqual(expected, actual);
        }
    }
}
