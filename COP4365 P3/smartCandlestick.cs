﻿using COP4365_P3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP4365_P3 
{    
    // derived class that allows for finding candlestick patterns
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

        // constructor that calls the base class constructor 
        public smartCandlestick() : base() { }

        // initializes higher level properties and patterns
        public smartCandlestick(String rowOfData) : base(rowOfData)
        {
            initHigherProperties();
            initPatternProperties();
        }

        // calculates higher properties that allow for easier calculations
        private void initHigherProperties() 
        {
            range = Math.Abs(high - low);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            bodyRange = Math.Abs(topPrice - bottomPrice);
            topTail = Math.Abs(high - topPrice);
            bottomTail = Math.Abs(bottomPrice - low);
        }

        // calculates the percent difference between two values given
        private double CalculatePercentDiff(double value1, double value2)
        {
            double difference = Math.Abs(value1 - value2);
            double average = (value1 + value2) / 2;
            return difference / average;
        }

        // initializes the bool value of the stock candlestick patterns
        private void initPatternProperties() 
        {
            isBullish = close > ((decimal)1.05 * open);
            isBearish = close < ((decimal)0.95 * open);
            isNeutral = bodyRange <= ((decimal)0.05 * open);
            isMarubozu = bodyRange == range;

            double percentDiff = CalculatePercentDiff((double)open, (double)close);
            isDoji = percentDiff < 0.03;

            double topTailRatio = (double)(topTail / range);
            double bottomTailRatio = (double)(bottomTail / range);
            isDragonFlyDoji = isDoji && topTailRatio <= 0.3 && bottomTailRatio >= 0.5;
            isGravestoneDoji = isDoji && bottomTailRatio <= 0.3 && topTailRatio >= 0.5;

            double bodyRatio = (double)(bodyRange / range);
            bool isBodyHammerRatio = bodyRatio <= 0.40 && bodyRatio >= 0.25 ;
            isHammer = (topTail / range) <= (decimal)0.30 && isBodyHammerRatio && topTailRatio >= 0.1;
            isInvertedHammer = (bottomTail / range) <= (decimal)0.3 && isBodyHammerRatio && bottomTailRatio > 0.1;

        }
       
    }
}
