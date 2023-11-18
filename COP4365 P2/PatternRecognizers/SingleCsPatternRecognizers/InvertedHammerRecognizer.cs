using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    // invertedhammer recognizer based off of Recognizer class
    internal class InvertedHammerRecognizer: Recognizer
    {
        // specific pattern constructor
        public InvertedHammerRecognizer() : base("InvertedHammer", 1) { }

        // overrided recognizer for the inherited class
        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick scs = lscs[0];
            return scs.isInvertedHammer;
        }
    }
}
