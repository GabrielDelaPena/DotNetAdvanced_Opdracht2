using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Varken : Dier
    {
        public string Geluid;
        public Varken(int gewicht, string uitspraak, string geluid) : base(gewicht, uitspraak, geluid)
        {
            this.Geluid = geluid;
        }

        public override string Zegt()
        {
            return this.Uitspraak;
        }
    }
}
