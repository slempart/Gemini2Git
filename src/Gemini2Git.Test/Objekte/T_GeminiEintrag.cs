using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git.Objekte;

namespace Gemini2Git.Test.Objekte
{
	[TestClass]
	public class T_GeminiEintrag
	{
        /// <summary>
        /// Test der Equals-Methode, dass zwei Gemini-Einträge gleich sind. Nummer: "12345"
        /// </summary>
        [TestMethod, TestCategory("Objekte")]
        public void GeminiEintrag_Equals_Name_Test()
        {
            string nummer = "12345";
            GeminiEintrag actual = new GeminiEintrag(nummer: nummer, key: null, projektkürzel: null, titel: null);

            string nummer2 = "12345";
            GeminiEintrag expected = new GeminiEintrag(nummer: nummer2, key: null, projektkürzel: null, titel: null);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test der Equals-Methode, dass zwei Gemini-Einträge ungleich sind. Nummer: "12345" und Nummer: "12346"
        /// </summary>
        [TestMethod, TestCategory("Objekte")]
        public void GeminiEintrag_Not_Equals_Name_Test()
        {
            string nummer = "12345";
            GeminiEintrag actual = new GeminiEintrag(nummer: nummer, key: null, projektkürzel: null, titel: null);

            string nummer2 = "12346";
            GeminiEintrag expected = new GeminiEintrag(nummer: nummer2, key: null, projektkürzel: null, titel: null);

            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test, dass die Rückgabe Key: Prj-12345 ist, wenn der Key des Gemini-Eintrags Prj-12345 ist.
        /// </summary>
        [TestMethod, TestCategory("Objekte")]
        public void GeminiEintrag_ToString()
        {
            string key = "Prj-12345";
            GeminiEintrag geminiEintrag = new GeminiEintrag(nummer: null, key: key, projektkürzel: null, titel: null);

            string expected = "Key: Prj-12345";

            string actual = geminiEintrag.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
