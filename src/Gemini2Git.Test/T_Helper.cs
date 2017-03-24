using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git;


namespace Gemini2Git.Test
{
    [TestClass]
    public class T_Helper
    {
        /// <summary>
        /// Extrahiere aus Kopfzeile in die ID und Titel
        /// </summary>
        [TestMethod]
        public void Split_Kopfzeile_in_ID_und_Titel()
        {
            string[] expected = new string[2] { "Prj-123456", "Dies ist ein Projekt" };

            string kopfzeile = "Prj-123456 - Dies ist ein Projekt";
            string[] actual = Helper.Split_Kopfzeile_in_ID_und_Titel(kopfzeile);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}
