using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3.PatternRecognizers
{
    internal class PeakRecognizer : Recognizer
    {
        double minDifference = 3;
        public PeakRecognizer() : base("Peak", 3) { }

        public override bool RecognizePattern(List<smartCandlestick> lscs)
        {
            smartCandlestick leftScs = lscs[0];
            smartCandlestick middleScs = lscs[1];
            smartCandlestick rightScs = lscs[2];
            //return (middleScs.high > leftScs.high) && (middleScs.high > rightScs.high);
            // Calculate the percentage difference between the high values of the middle and left candlesticks
            double leftDifference = Math.Abs(((double)middleScs.high - (double)leftScs.high) / ((double)middleScs.high + (double)leftScs.high)) * 100;

            // Calculate the percentage difference between the high values of the middle and right candlesticks
            double rightDifference = Math.Abs(((double)middleScs.high - (double)rightScs.high) / ((double)middleScs.high + (double)rightScs.high)) * 100;

            // Check if the percentage difference is above the minimum
            bool isDifferenceAboveMinimum = leftDifference > minDifference && rightDifference > minDifference;

            // Return true if the middle candlestick's high value is greater than the left and right candlesticks' high values, and the percentage difference is above the minimum
            return (middleScs.high > leftScs.high) && (middleScs.high > rightScs.high) && isDifferenceAboveMinimum;
        }
    }
}
