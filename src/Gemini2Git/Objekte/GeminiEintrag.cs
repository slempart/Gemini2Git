using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    /// <summary>
    /// Hält die Eigenschaften eines Gemini-Eintrages
    /// </summary>
    public class GeminiEintrag
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        private GeminiEintrag()
        { }

        /// <summary>
        /// Konstruktor zum Erstellen eines GeminiEintrages
        /// </summary>
        /// <param name="projektkürzel">Projektkürzel</param>
        /// <param name="nummer">Nummer</param>
        /// <param name="key">Schlüssel(Key)</param>
        /// <param name="titel">Titel</param>
        public GeminiEintrag(string projektkürzel, string nummer, string key, string titel) : this()
        {
            Projektkürzel = projektkürzel;
            Nummer = nummer;
            Key = key;
            Titel = titel;
        }

        /// <summary>
        /// Gibt den Nummer eines Gemini-Eintrages zurück
        /// </summary>
        public string Nummer { get; private set; }

        /// <summary>
        /// Gibt den Projektkürzel eines Gemini-Eintrages zurück
        /// </summary>
        public string Projektkürzel { get; private set; }

        /// <summary>
        /// Gibt den Titel eines Gemini-Eintrages zurück
        /// </summary>
        public string Titel { get; private set; }

        /// <summary>
        /// Gibt die Schlüssel(Key) eines Gemini-Eintrages zurück
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Vergleicht den GemimiEintrag mit einem anderen Objekt
        /// </summary>
        /// <param name="obj">Das andere Objekt, mit dem verglichen werden soll</param>
        /// <returns>Gibt true zurück, wenn sie gleich sind, andernfalls false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            GeminiEintrag other = obj as GeminiEintrag;
            return this.Nummer == other.Nummer;
        }

        /// <summary>
        /// Gibt den HashCode zurück
        /// </summary>
        /// <returns>Der HashCode</returns>
        public override int GetHashCode()
        {
            return Nummer.GetHashCode();
        }

        /// <summary>
        /// Gibt die überschriebene ToString-Methode zurück. Bsp.: "Key: Prj-123456"
        /// </summary>
        /// <returns>Bsp.: "Key: Prj-123456"</returns>
        public override string ToString()
        {
            return String.Format("Key: {0}", this.Key);
        }
    }
}
