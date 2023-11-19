using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers
{
    internal class BearishEngulfingRecognizer : Recognizer
    {
        public BearishEngulfingRecognizer() : base("BearishEngulfing", 2) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick largerScs = lscs[0];
            smartCandlestick smallerScs = lscs[1];
            bool correctPattern = largerScs.isBullish && smallerScs.isBearish;
            bool engulfingBody = largerScs.topPrice > smallerScs.topPrice && largerScs.bottomPrice < smallerScs.bottomPrice;
            bool engulfingTail = largerScs.high > smallerScs.high && largerScs.low < smallerScs.low;

            bool hasNoLowerTail = smallerScs.bottomTail == 0;
            return correctPattern && engulfingBody && hasNoLowerTail;

        }
    }
}
