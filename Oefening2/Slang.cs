using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Slang : Dier
    {
        public SoundPlayer Geluid;
        public Slang(int gewicht, string uitspraak, string geluid) : base(gewicht, uitspraak, geluid)
        {
            this.Geluid = new SoundPlayer(geluid);
        }

        public override string Zegt()
        {
            return this.Uitspraak;
        }
    }
}
