using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    /// <summary>
    /// Typ von Eigenschaft(Property) und Attribut (Key-Value)
    /// </summary>
    public class EigenschaftAttribut
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        private EigenschaftAttribut()
        { }

           /// <summary>
        /// Konstruktor zum Instanzieren von EigenschaftAttribut 
        /// </summary>
        /// <param name="eigenschaft"></param>
        /// <param name="attribut"></param>
        public EigenschaftAttribut(string eigenschaft, string attribut)
        {
            Eigenschaft = eigenschaft;
            Attribut = attribut;
        }

        /// <summary>
        /// Attribute
        /// </summary>
        public string Attribut { get; private set; }

        /// <summary>
        /// Eigenschaft(Property)
        /// </summary>
        public string Eigenschaft { get; private set; }
    }
}
