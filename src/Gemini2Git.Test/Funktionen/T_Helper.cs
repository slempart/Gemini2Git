using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git.Funktionen;
using Gemini2Git.Objekte;
using System.Collections.Generic;

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

        




    }
}
