using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git.Funktionen;
using Gemini2Git.Objekte;
using System.Collections.Generic;
using Gemini2Git.Models;
using equalidator;

namespace Gemini2Git.Test.Funktionen
{
    [TestClass]
    public class T_Helper
    {
        /// <summary>
        /// Extrahiere aus der Kopfzeile den Schlüssel(Key) und den Titel
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Split_Kopfzeile_in_Key_und_Titel()
        {
            string[] expected = new string[2] { "Prj-123456", "Dies ist ein Projekt" };

            string kopfzeile = "Prj-123456 - Dies ist ein Projekt";
            string[] actual = Helper.Split_Kopfzeile_in_Key_und_Titel(kopfzeile);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        /// <summary>
        /// Extrahiere aus dem Schlüssel(Key) das Projektkürzel und den Titel
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Split_Key_in_Projektkürzel_und_Nummer()
        {
            string[] expected = new string[2] { "Prj", "123456" };

            string key = "Prj-123456";
            string[] actual = Helper.Split_Key_in_Projektkürzel_und_Nummer(key);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        /// <summary>
        /// Extrahiere aus der Kopfzeile in einen Gemini-Eintrag
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Extrahiere_Kopfzeile_in_GeminiEintrag()
        {
            GeminiEintrag expected = new GeminiEintrag(key: "Prj-123456",
                                                        projektkürzel: "Prj",
                                                        nummer: "123456",
                                                        titel: "Dies ist ein Projekt");

            string kopfzeile = "Prj-123456 - Dies ist ein Projekt";
            GeminiEintrag actual = Helper.Extrahiere_GeminiEintrag(kopfzeile);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Extrahiere aus der Konfiguraton die Gruppennamen
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Extrahiere_Gruppen()
        {
            List<Gruppe> expected = new List<Gruppe>() { new Gruppe("Branches"),
                                                         new Gruppe("Pull request")
                                                         };

            Konfig konfig = new Konfig() { Gruppen = new List<GruppeEintraege>() 
                                             { new GruppeEintraege() {  Gruppe="Branches", Eintraege = new List<Eintrag>() }
                                              ,new GruppeEintraege() {  Gruppe="Pull request", Eintraege = new List<Eintrag>() }
                                             }
                                            };

            List<Gruppe> actual = Helper.Liefere_Gruppen(konfig);


            Equalidator.AreEqual(expected, actual);
        }

        /// <summary>
        /// Extrahiere aus der Konfiguraton für Branches die GruppeNameWert-Liste
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Extrahiere_GruppeNameWert()
        {
            List<GruppeNameWert> expected = new List<GruppeNameWert>()
                                                { new GruppeNameWert("Branches", "features", "features/issue_1233_Prj"),
                                                  new GruppeNameWert("Branches", "bug", "bug/issue_1277_Prj")
                                                };

            string filterGruppe = "Branches";
            List<AttributWert> attributWerts = new List<AttributWert>();
           
            Konfig konfig = new Konfig()
            {
                Gruppen = new List<GruppeEintraege>()
                                             { new GruppeEintraege()
                                                        {  Gruppe="Branches", Eintraege = new List<Eintrag>()
                                                            { new Eintrag() { Name = "features", Wert = "features/issue_1233_Prj" }
                                                              ,new Eintrag() { Name = "bug", Wert = "bug/issue_1277_Prj" } }
                                                        }
                                              ,new GruppeEintraege()
                                                       {  Gruppe="Pull request", Eintraege = new List<Eintrag>()
                                                            { new Eintrag() { Name = "features", Wert = "features/issue_1244_Prj" }
                                                              ,new Eintrag() { Name = "bug", Wert = "bug/issue_1255_Prj" } }
                                                        }
                                                       
                                             }
            };

            List<GruppeNameWert> actual = Helper.Liefere_GruppeNameWert(filterGruppe, attributWerts, konfig);


            Equalidator.AreEqual(expected, actual);
        }






    }
}
