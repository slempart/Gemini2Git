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

        public class GitAttritbut_Testklasse
        {
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


            List<EigenschaftAttribut> actual = AttributHelper.Liefere_Liste_Attribute<GitAttritbut_Testklasse>();

            Equalidator.AreEqual(expected, actual);
        }

    }
}
