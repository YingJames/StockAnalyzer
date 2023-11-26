using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{

    // peak recognizer based off of Recognizer class
    internal class PeakRecognizer : Recognizer
    {
        double minDifference = 3;
        // inherits from the Recognizer constructor to make a 3 candlestick pattern recognizer
        public PeakRecognizer() : base("Peak", 3) { }

        // overrides RecognizePattern for the peak implementation
        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick leftScs = lscs[0];
            smartCandlestick middleScs = lscs[1];
            smartCandlestick rightScs = lscs[2];
            //return (middleScs.high > leftScs.high) && (middleScs.high > rightScs.high);
            
            double leftDifference = Math.Abs(((double)middleScs.high - (double)leftScs.high) / ((double)middleScs.high + (double)leftScs.high)) * 100;
            double rightDifference = Math.Abs(((double)middleScs.high - (double)rightScs.high) / ((double)middleScs.high + (double)rightScs.high)) * 100;
            bool isDifferenceAboveMinimum = leftDifference > minDifference && rightDifference > minDifference;

            return (middleScs.high > leftScs.high) && (middleScs.high > rightScs.high) && isDifferenceAboveMinimum;
        }
    }
}
