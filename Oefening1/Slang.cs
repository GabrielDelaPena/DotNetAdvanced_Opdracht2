using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Slang : Dier
    {
        public string Geluid;
        public Slang(int gewicht, string uitspraak, string geluid) : base(gewicht, uitspraak, geluid)
        {
            this.Geluid = geluid;
        }

        public override string Zegt()
        {
            return this.Uitspraak;
        }
    }
}
