using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    // marubozu recognizer based off of Recognizer class
    internal class MarubozuRecognizer: Recognizer
    {
        // specific pattern constructor
        public MarubozuRecognizer() : base("Marubozu", 1) { }

        // overrided recognizer for the inherited class
        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick scs = lscs[0];
            return scs.isMarubozu;
        }
    }
}
