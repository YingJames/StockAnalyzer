using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers
{
    internal class BullishEngulfingRecognizer : Recognizer
    {
        public BullishEngulfingRecognizer() : base("Bullish Engulfing", 2) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick smallerScs = lscs[0];
            smartCandlestick largerScs = lscs[1];
            bool correctPattern = largerScs.isBullish && smallerScs.isBearish;
            bool engulfingBody = largerScs.topPrice > smallerScs.topPrice && largerScs.bottomPrice < smallerScs.bottomPrice;
            bool engulfingTail = largerScs.high > smallerScs.high && largerScs.low < smallerScs.low;
            return correctPattern && engulfingBody && engulfingTail;
            
        }
    }
}
