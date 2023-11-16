using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP4365_P3
{
    internal abstract class Recognizer
    {
        int patternSize { get; set; }
        string patternName { get; set; }
        public List<int> Recognize(List<smartCandlestick> lscs) 
        { // 
            List<int> result = new List<int>(lscs.Count);
            for (int i = 0; i < lscs.Count; i++)
            {
                if (RecognizePattern(lscs[i]))
                    result.Add(i);
            }
            return result;
        }
        public virtual bool RecognizePattern(smartCandlestick scs) { return false; }
    }
}
