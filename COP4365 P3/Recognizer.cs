using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3
{
    internal abstract class Recognizer
    {
        public int patternSize { get; set; }
        public string patternName { get; set; }
        public Recognizer(string patternName, int patternSize)
        {
            this.patternName = patternName;
            this.patternSize = patternSize;
        }
        public List<int> Recognize(List<smartCandlestick> lscs) 
        {
            List<int> result = new List<int>(lscs.Count);
            for (int i = patternSize-1; i < lscs.Count; i++)
            {
                // build sublist
                List<smartCandlestick> sublist = lscs.GetRange(i-patternSize+1, patternSize);

                if (RecognizePattern(sublist))
                    result.Add(i);
            }
            return result;
        }
        // Peak and (Valley or Bottom)
        // createa a list of all the recognizers
        // foreach recognizer R in the list, add the candlestickPatterncomboBox.Items.Add(R.patternName)
        public abstract bool RecognizePattern(List<smartCandlestick> lscs);
    }
}
