using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Gemini2Git.Objekte;

namespace Gemini2Git.Funktionen
{
    public class AttributHelper
    {
        internal static List<EigenschaftAttribut> Liefere_Liste_Attribute<T>()
        {
            List<EigenschaftAttribut> ea = new List<EigenschaftAttribut>();

            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                GitAttribut[] attributes = property.GetCustomAttributes(typeof(GitAttribut), true) as GitAttribut[];
                if (attributes != null && attributes.Length > 0)
                {
                    foreach (GitAttribut attribut in attributes)
                    {
                        ea.Add(new EigenschaftAttribut(property.Name, attribut.Name));
                    }
                }
            }

            return ea;
        }


        internal static List<AttributWert> Liefere_Liste_Werte<T>(T geminiEintrag, List<EigenschaftAttribut> eigenschaftAttributs)
        {
            List<AttributWert> attributWerts = new List<AttributWert>();

            foreach (EigenschaftAttribut eigenschaftAttribut in eigenschaftAttributs)
            {
                string wert = (string)geminiEintrag.GetType().GetProperty(eigenschaftAttribut.Eigenschaft).GetValue(geminiEintrag, null);
                attributWerts.Add(new AttributWert(eigenschaftAttribut.Attribut, wert));
            }

            return attributWerts;
        }

        internal static string Ersetze_Liste_Werte(string wert, List<AttributWert> attributWerts)
        {
            foreach (AttributWert attributWert in attributWerts)
            {
                wert = wert.Replace(attributWert.Attribut, attributWert.Wert);
            }

            return wert;
        }
    }
}
