using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    /// <summary>
    /// Typ von Attribut (Key-Value) und Wert 
    /// </summary>
    public class AttributWert
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        private AttributWert()
        { }

        /// <summary>
        /// Konstruktor zum Instanzieren von EigenschaftAttribut 
        /// </summary>
        /// <param name="attribut">Attribut</param>
        /// <param name="wert">Wert</param>
        public AttributWert(string attribut, string wert)
        {
            Attribut = attribut;
            Wert = wert;
        }

        /// <summary>
        /// Attribute
        /// </summary>
        public string Attribut { get; private set; }

        /// <summary>
        /// Eigenschaft(Property)
        /// </summary>
        public string Wert { get; private set; }
    }
}
