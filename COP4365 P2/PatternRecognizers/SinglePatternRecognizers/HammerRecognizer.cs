using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    // hammer recognizer based off of Recognizer class
    internal class HammerRecognizer: Recognizer
    {
        // specific pattern constructor
        public HammerRecognizer() : base("Hammer", 1) { }

        // overrided recognizer for the inherited class
        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick scs = lscs[0];
            return scs.isHammer;
        }
    }
}
