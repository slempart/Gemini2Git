using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git.Objekte;
using Gemini2Git.Funktionen;
using equalidator;

namespace Gemini2Git.Test.Funktionen
{
    /// <summary>
    /// Summary description for T_AttributHelper
    /// </summary>
    [TestClass]
    public class T_AttributHelper
    {

        public class GeminiEintrag_Testklasse
        {
            public GeminiEintrag_Testklasse(string projektkürzel, string nummer, string titel)
        {
                Projektkürzel = projektkürzel;
                Nummer = nummer;
                Titel = titel;
            }
            /// <summary>
            /// Gibt den Nummer eines Gemini-Eintrages zurück
            /// </summary>
            [GitAttribut("<Nummer>")]
            public string Nummer { get; private set; }

            /// <summary>
            /// Gibt den Projektkürzel eines GitAttritbut_Testklasse zurück
            /// </summary>
            [GitAttribut("<Gemini-Projekt>")]
            public string Projektkürzel { get; private set; }

            /// <summary>
            /// Gibt den Titel eines GitAttritbut_Testklasse zurück
            /// </summary>
            public string Titel { get; private set; }
        }

        /// <summary>
        /// Liefert die Liste EigenschaftAttribut zu einer Klasse mit Git-Attributen.
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Liefert_Liste_EigenschaftAttribut_mit_2_Einträgen()
        {
            
            List<EigenschaftAttribut> expected = new List<EigenschaftAttribut>() { new EigenschaftAttribut("Nummer", "<Nummer>")
                                                                                   , new EigenschaftAttribut("Projektkürzel", "<Gemini-Projekt>")
                                                                                 };


            List<EigenschaftAttribut> actual = AttributHelper.Liefere_Liste_Attribute<GeminiEintrag_Testklasse>();

            Equalidator.AreEqual(expected, actual);
        }

        /// <summary>
        /// Liefert die Liste AttributWert zu einer Klasse mit Git-Attributen.
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Liefert_Liste_AttributWert_mit_2_Einträgen()
        {

            List<AttributWert> expected = new List<AttributWert>() { new AttributWert("<Nummer>", "123456")
                                                                    , new AttributWert("<Gemini-Projekt>","Prj")
                                                                   };


            GeminiEintrag_Testklasse geminiEintrag = new GeminiEintrag_Testklasse(
                                                        projektkürzel: "Prj",
                                                        nummer: "123456",
                                                        titel: "Dies ist ein Projekt");

            List<EigenschaftAttribut> eigenschaftAttributs = new List<EigenschaftAttribut>() { new EigenschaftAttribut("Nummer", "<Nummer>")
                                                                                   , new EigenschaftAttribut("Projektkürzel", "<Gemini-Projekt>")
                                                                                 };

            List<AttributWert> actual = AttributHelper.Liefere_Liste_Werte<GeminiEintrag_Testklasse>(geminiEintrag, eigenschaftAttributs);

            Equalidator.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ersetzt in der Zeichenkett die Platzhalter aus der Liste AttributWert.
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Ersetze_Liste_AttributWert_mit_2_Einträgen()
        {

            List<AttributWert> attributWert = new List<AttributWert>() { new AttributWert("<Nummer>", "123456")
                                                                    , new AttributWert("<Gemini-Projekt>","Prj")
                                                                   };


            string expected = "features/issue_123456_Prj";

            string wert = "features/issue_<Nummer>_<Gemini-Projekt>";



            string actual = AttributHelper.Ersetze_Liste_Werte(wert, attributWert);

            Assert.AreEqual(expected, actual);
        }
    }
}
