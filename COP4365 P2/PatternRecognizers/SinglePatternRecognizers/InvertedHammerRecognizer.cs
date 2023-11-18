using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    internal class InvertedHammerRecognizer: Recognizer
    {
        public InvertedHammerRecognizer() : base("InvertedHammer", 1) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick scs = lscs[0];
            return scs.isInvertedHammer;
        }
    }
}
