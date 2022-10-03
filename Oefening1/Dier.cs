using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Dier
    {
        public int Gewicht { get; set; }
        protected string Uitspraak { get; set; }
        protected string Geluid { get; set; }

        public Dier(int gewicht, string uitspraak, string geluid)
        {
            Gewicht = gewicht;
            Uitspraak = uitspraak;
            Geluid = geluid;
        }

        public virtual string Zegt()
        {
            return Uitspraak;
        }
    }
}
