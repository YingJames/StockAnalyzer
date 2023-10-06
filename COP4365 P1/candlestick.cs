using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace COP4365_P1
{
    // candlestick object represents stock data
    internal class candlestick
    {
        public DateTime date { get; set; }
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }

        public candlestick() { }

        // defines the initial values for the object
        public candlestick(DateTime date, decimal open=0, Decimal high=0, Decimal low=0, decimal close=0, long volume=0)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }

        // constructs based on the row of data by parsing
        public candlestick(String rowOfData)
        {
            char[] separators = new char[] { ',', ' ', '"', '-' };
            String[] subs = rowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           
            Dictionary<string, int> monthMap = new Dictionary<string, int>();
            int i = 1;
            monthMap.Add("Jan", i++);
            monthMap.Add("Feb", i++);
            monthMap.Add("Mar", i++);
            monthMap.Add("Apr", i++);
            monthMap.Add("May", i++);
            monthMap.Add("Jun", i++);
            monthMap.Add("Jul", i++);
            monthMap.Add("Aug", i++);
            monthMap.Add("Sep", i++);
            monthMap.Add("Oct", i++);
            monthMap.Add("Nov", i++);
            monthMap.Add("Dec", i++);

            bool success;

            int tempDate;
            // 2: month, 3: day, 4: year
            int month = monthMap[subs[2]];
            
            success = int.TryParse(subs[3], out tempDate);
            int day = tempDate;
            success = int.TryParse(subs[4], out tempDate);
            int year = tempDate;

            date = new DateTime(year, month, day);
           
            
            Decimal temp;
            success = Decimal.TryParse(subs[5], out temp);
            open = temp;
            success = Decimal.TryParse(subs[6], out temp);
            high = temp;
            success = Decimal.TryParse(subs[7], out temp);
            low = temp;
            success = Decimal.TryParse(subs[8], out temp);
            close = temp;

            long tempVolume;
            success = long.TryParse(subs[9], out tempVolume);
            volume = tempVolume;
        }
    }
}
