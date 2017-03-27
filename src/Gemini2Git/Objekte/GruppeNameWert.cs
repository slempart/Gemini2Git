using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    public class GruppeNameWert
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        private GruppeNameWert()
        { }

        /// <summary>
        /// Konstruktor zum Instanzieren von GruppeNameWert 
        /// </summary>
        /// <param name="gruppe">Gruppe</param>
        /// /// <param name="name">Name</param>
        /// <param name="wert">Wert</param>
        public GruppeNameWert(string gruppe, string name, string wert)
        {
            Gruppe = gruppe;
            Name = name;
            Wert = wert;
        }

        /// <summary>
        /// Gruppe
        /// </summary>
        public string Gruppe { get; private set; }

        /// <summary>
        /// Gruppe
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Wert
        /// </summary>
        public string Wert { get; private set; }
    }
}
