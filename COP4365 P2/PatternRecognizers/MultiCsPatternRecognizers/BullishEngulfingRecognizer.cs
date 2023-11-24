using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers
{
    // bullish engulfing recognizer based off of Recognizer class
    internal class BullishEngulfingRecognizer : Recognizer
    {
        // inherits from the Recognizer constructor to make a 2 candlestick pattern recognizer
        public BullishEngulfingRecognizer() : base("Bullish Engulfing", 2) { }

        // overrides RecognizePattern for the bullish engulfing implementation
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
