using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Models
{
    public class GruppeEintraege
    {
        public string Gruppe { get; set; }

        public List<Eintrag> Eintraege { get; set; }
    }
}
