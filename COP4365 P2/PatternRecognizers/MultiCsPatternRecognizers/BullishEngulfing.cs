using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers
{
    internal class BullishEngulfing : Recognizer
    {
        public BullishEngulfing() : base("BullishEngulfing", 2) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick smallerScs = lscs[0];
            smartCandlestick bullishScs = lscs[1];
            return bullishScs.isBullish;
            
        }
    }
}
