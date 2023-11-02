﻿using COP4365_P2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP4365_P2 // use combobox to select which type of candlestick to see
{                    // then annotate and point arrwo on chart to show which candlestick
                    // Dictionary<TypeCandlestick, list of indices or candlesticks from tempList for that type of candlestick >
    public class smartCandlestick : candlestick
    {
        public static double dojiLeeway = 0.05;
        public Decimal range { get; set; } // high - low
        public Decimal bodyRange { get; set; } // abs(open - close)
        public Decimal topPrice { get; set; }
        public Decimal bottomPrice { get; set; }
        public Decimal topTail { get; set; }
        public Decimal bottomTail { get; set; }
        public bool isBullish { get; set; } = false; // make all of these is'x' as properties
        public bool isBearish { get; set; } = false; // testBearish()
        public bool isNeutral { get; set; } = false;
        public bool isMarubozu { get; set; } = false;
        public bool isDoji { get; set; } = false;
        public bool isDragonFlyDoji { get; set; } = false;
        public bool isGravestoneDoji { get; set; } = false;
        public bool isHammer { get; set; } = false; 
        public bool isInvertedHammer { get; set; } = false;
        // need function that has access to these parameters to set true or false
            // upperTail must be 3% or less of the entire range
            // bodyRange must be >= 20% and <= 30%

        public smartCandlestick() : base() { }
        public smartCandlestick(String rowOfData) : base(rowOfData)
        {
            initHigherProperties();
            computePatterns();
        }

        private void initHigherProperties() 
        {
            range = Math.Abs(high - low);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            bodyRange = Math.Abs(topPrice - bottomPrice);
            topTail = Math.Abs(high - topPrice);
            bottomTail = Math.Abs(bottomPrice - low);
        }

        private bool leeway() { return false; }
        private static double CalculatePercentageDifference(double value1, double value2)
        {
            double difference = Math.Abs(value1 - value2);
            double average = (value1 + value2) / 2;
            return (difference / average) * 100;
        }

        private void computePatterns() 
        {
            isBullish = close > ((decimal)1.05 * open);
            isBearish = close < ((decimal)0.95 * open);
            isNeutral = bodyRange <= ((decimal)0.05 * open);
            isMarubozu = bodyRange == range;
            isDoji = CalculatePercentageDifference((double)open, (double)close) < 0.05;
        }
       
    }
}
