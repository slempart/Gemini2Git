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
    }
}
