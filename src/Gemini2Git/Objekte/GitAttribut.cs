using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini2Git.Objekte
{
    class GitAttribut : Attribute
    {
        public GitAttribut(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
