using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP4365_P2
{

    // form class for viewing and interacting with stocks in a chart
    public partial class Form_viewStock : Form
    {
        string stockSymbol { get; set; }
        private BindingList<smartCandlestick> candlesticks;
        private List<smartCandlestick> allCandlesticks { get; set; }
        Series series_OHLC;
        Series series_volume;
        ChartArea area_OHLC;
        ChartArea area_volume;

        // construct lists and chart components
        public Form_viewStock(string symbol, List<smartCandlestick> listOfCandlesticks)
        {
            InitializeComponent();
            stockSymbol = symbol;
            this.Text = stockSymbol;

            // initialize candlestick chart series
            allCandlesticks = new List<smartCandlestick>(1024);
            allCandlesticks = listOfCandlesticks;
            candlesticks = new BindingList<smartCandlestick>(allCandlesticks);
            chart_stock.DataSource = candlesticks;
            series_OHLC = chart_stock.Series["series_OHLC"];
            series_volume = chart_stock.Series["series_volume"];
            area_OHLC = chart_stock.ChartAreas["area_OHLC"];
            area_volume = chart_stock.ChartAreas["area_volume"];
            series_OHLC.XValueType = ChartValueType.DateTime;
            series_OHLC.XValueMember = "date";
            series_OHLC.YValueMembers = "high,low,open,close";

            series_volume.XValueType = ChartValueType.DateTime;
            series_volume.XValueMember = "date";
            series_volume.YValueMembers = "volume";

            // add axis titles
            area_OHLC.AxisX.Title = "Date";
            area_OHLC.AxisY2.Title = "Price";
            area_volume.AxisX.Title = "Date";
            area_volume.AxisY2.Title = "Volume";

            // combobox for showing patterns
            string[] patterns = new string[] { "None", "Bullish", "Bearish",
                "Neutral", "Marubozu", "Doji",
                "DragonFlyDoji", "GravestoneDoji", "Hammer", "InvertedHammer" };
            comboBox_patterns.Items.AddRange(patterns);
            comboBox_patterns.SelectedIndex = 0;

            updateStockChart();
        }

        // filters out the candlesticks based on the date time picker
        private List<smartCandlestick> getCandlesticksInRange(List<smartCandlestick> tempList)
        {

            List<smartCandlestick> reversedTempList = new List<smartCandlestick>();
            tempList.Reverse();
            foreach (smartCandlestick candlestick in tempList)
            {
                if (candlestick.date > dateTimePicker_endDate.Value)
                    break;

                if (candlestick.date >= dateTimePicker_startDate.Value)
                {
                    reversedTempList.Add(candlestick);
                }
            }
            tempList.Reverse();

            reversedTempList.Reverse();
            return reversedTempList;
        }

        // creates a new arrow annotation object anchored to a specific candlestick
        private ArrowAnnotation makeArrow(DataPoint candlestickPoint)
        {
            ArrowAnnotation arrow = new ArrowAnnotation();
            arrow.ArrowSize = 4;
            arrow.Height = 10;
            arrow.Width = 0;
            arrow.BackColor = Color.Red;
            arrow.ForeColor = Color.Red;
            arrow.AnchorOffsetY = 5;
            arrow.ArrowStyle = ArrowStyle.Simple;

            /*                float xPixelPosition = (float)area_OHLC.AxisX.ValueToPixelPosition(candlestickPoint.XValue);
                            float yPixelPosition = (float)area_OHLC.AxisY.ValueToPixelPosition(candlestickPoint.YValues[0]);
            */
            arrow.AnchorDataPoint = candlestickPoint;
            return arrow;
        }

        // filters the candlesticks based on date range and creates annotations on the chart
        private void updateStockChart()
        {
            List<smartCandlestick> filteredCandlesticks = getCandlesticksInRange(allCandlesticks);
            candlesticks = new BindingList<smartCandlestick>(filteredCandlesticks);

            chart_stock.DataSource = candlesticks;
            chart_stock.DataBind();
            chart_stock.Annotations.Clear();

            string selectedPattern = "is" + comboBox_patterns.SelectedItem.ToString();

            // Create a dictionary that maps the selectedPattern to the specified function
            Dictionary<string, Func<smartCandlestick, bool>> patternProperties = new Dictionary<string, Func<smartCandlestick, bool>>
            {
                { "isBullish", candlestick => candlestick.isBullish },
                { "isBearish", candlestick => candlestick.isBearish },
                { "isNeutral", candlestick => candlestick.isNeutral },
                { "isMarubozu", candlestick => candlestick.isMarubozu },
                { "isDoji", candlestick => candlestick.isDoji },
                { "isDragonFlyDoji", candlestick => candlestick.isDragonFlyDoji },
                { "isGravestoneDoji", candlestick => candlestick.isGravestoneDoji },
                { "isHammer", candlestick => candlestick.isHammer },
                { "isInvertedHammer", candlestick => candlestick.isInvertedHammer },

            };

            // checks the map to find the appropriate function based on the selected item in the combobox
            if (patternProperties.TryGetValue(selectedPattern, out Func<smartCandlestick, bool> property))
            {
                int index = 0;
                foreach (DataPoint candlestickPoint in series_OHLC.Points)
                {
                    // takes smartCandlestick and returns a bool
                    if (property(filteredCandlesticks[index]))
                    {
                        ArrowAnnotation arrow = makeArrow(candlestickPoint);
                        chart_stock.Annotations.Add(arrow);
                    }
                    index++;
                }
            }
            chart_stock.Invalidate();
        }

        // updates the candlesticks range and annotations
        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            updateStockChart();
            /*            List<smartCandlestick> filteredCandlesticks = getCandlesticksInRange(allCandlesticks);
                        candlesticks = new BindingList<smartCandlestick>(filteredCandlesticks);

                        chart_stock.DataSource = candlesticks;
                        chart_stock.DataBind();

                        chart_stock.Annotations.Clear();
                        foreach (DataPoint candlestickPoint in series_OHLC.Points)
                        {
                            ArrowAnnotation arrow = makeArrow(candlestickPoint);
                            chart_stock.Annotations.Add(arrow);
                        }
                        chart_stock.Invalidate();
            */

        }

        // will automatically update the stocks and arrow annotations when the user changes the pattern selection
        private void comboBox_patterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStockChart();
        }
    }
}
