using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers
{
    // valley recognizer based off of Recognizer class
    internal class ValleyRecognizer: Recognizer
    {
        double minDifference = 3;
        // inherits from the Recognizer constructor to make a 3 candlestick pattern recognizer
        public ValleyRecognizer() : base("Valley", 3) { }

        // overrides RecognizePattern for the valley implementation
        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick leftScs = lscs[0];
            smartCandlestick middleScs = lscs[1];
            smartCandlestick rightScs = lscs[2];
            //return (middleScs.low < leftScs.low) && (middleScs.low < rightScs.low);

            // Calculate the percentage difference between the low values of the middle and left candlesticks
            double leftDifference = Math.Abs(((double)middleScs.low - (double)leftScs.low) / ((double)middleScs.low + (double)leftScs.low)) * 100;
            double rightDifference = Math.Abs(((double)middleScs.low - (double)rightScs.low) / ((double)middleScs.low + (double)rightScs.low)) * 100;
            bool isDifferenceAboveMinimum = leftDifference > minDifference && rightDifference > minDifference;

            // Return true if the middle candlestick's low value is less than the left and right candlesticks' low values, and the percentage difference is above the minimum
            return (middleScs.low < leftScs.low) && (middleScs.low < rightScs.low) && isDifferenceAboveMinimum;
        }
    }
}
