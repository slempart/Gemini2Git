using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gemini2Git.Objekte;
using Gemini2Git.Funktionen;
using Gemini2Git.Models;
using equalidator;

namespace Gemini2Git.Test.Funktionen
{
    /// <summary>
    /// Summary description for T_KonfigHelper
    /// </summary>
    [TestClass]
    public class T_KonfigHelper
    {

        [TestMethod, TestCategory("Funktionen")]
        public void Ermittle_Pfad()
        {
            string expected = "c:/users";

            string path = "c:\\users";
            string actual = KonfigHelper.GetRootedDirectoryPath(path);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Lädt die Konfiguration
        /// </summary>
        [TestMethod, TestCategory("Funktionen")]
        public void Lade_Konfiguration()
        {

            Konfig expected = new Konfig()
            {
                Gruppen = new List<GruppeEintraege>()
                                        {  new GruppeEintraege() {
                                              Gruppe = "Branches"
                                            , Eintraege = new List<Eintrag>() {
                                                      new Eintrag() {  Name = "features", Wert = "features/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "bug", Wert = "bug/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "hotfix", Wert = "hotfix/issue_<Nummer>_<Gemini-Projekt>"}
                                            }
                                                }
                ,new GruppeEintraege() {
                                              Gruppe = "Pull request"
                                            , Eintraege = new List<Eintrag>() {
                                                      new Eintrag() {  Name = "features", Wert = "features/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "bug", Wert = "bug/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "hotfix", Wert = "hotfix/issue_<Nummer>_<Gemini-Projekt>"}
                                            }
                                                }
                ,
                new GruppeEintraege()
                {
                    Gruppe = "Kommentar"
                                            ,
                    Eintraege = new List<Eintrag>() {
                                                      new Eintrag() {  Name = "features", Wert = "features/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "bug", Wert = "bug/issue_<Nummer>_<Gemini-Projekt>"}
                                                    , new Eintrag() {  Name = "hotfix", Wert = "hotfix/issue_<Nummer>_<Gemini-Projekt>"}
                                            }
                }
            }
            };


            string relativerPfad = "Testdaten/Konfiguration.json";
            Konfig actual = KonfigHelper.Lade_Konfiguration(relativerPfad);

            Equalidator.AreEqual(expected, actual);
        }
    }
}
