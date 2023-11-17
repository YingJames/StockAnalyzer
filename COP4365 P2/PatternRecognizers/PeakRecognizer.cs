using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    internal class PeakRecognizer : Recognizer
    {
        public PeakRecognizer() : base("Peak", 3) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick leftScs = lscs[0];
            smartCandlestick middleScs = lscs[1];
            smartCandlestick rightScs = lscs[2];
            return (middleScs.high > leftScs.high) && (middleScs.high > rightScs.high);
        }
    }
}
