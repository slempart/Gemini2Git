using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    public class Gruppe
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        private Gruppe()
        { }

        /// <summary>
        /// Konstruktor zum Instanzieren von Gruppe 
        /// </summary>
        /// <param name="gruppenName">GruppenName</param>
        public Gruppe(string gruppenName)
        {
            GruppenName = gruppenName;

        }

        /// <summary>
        /// Gruppe
        /// </summary>
        public string GruppenName { get; private set; }
    }
}
