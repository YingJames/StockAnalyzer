using COP4365_P2;
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
        public Decimal lowerTail { get; set; }
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
            range = Math.Abs(high - low);
            bodyRange = Math.Abs(open - close);

            if (open <= close)
            {
                isBullish = true;
                topPrice = close; 
                bottomPrice = open;
            } 
            else
            {
                isBearish = true;
                topPrice = open;
                bottomPrice = close;
            }

            //initHigherProperties();
            
        }

        private void initHigherProperties() { }

        private bool leeway() { return false; }

        private void computePatterns() 
        {
            //isBullish = (close - open) > 1.05 * open;
            //isBearish = (close - open) > 0.95 * open;
            //isNeutral = (close - open) >  * open;
        }
       
    }
}
