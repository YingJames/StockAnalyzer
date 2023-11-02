﻿using System;
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
        string stockSymbol {  get; set; }
        private BindingList<smartCandlestick> candlesticks;
        private List<smartCandlestick> allCandlesticks {  get; set; }
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
            string[] patterns = new string[] {"None", "isBullish", "isBearish", "isNeutral"};
            comboBox_patterns.Items.AddRange(patterns);

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

        private ArrowAnnotation makeArrow(DataPoint candlestickPoint)
        {
            ArrowAnnotation arrow = new ArrowAnnotation();
            arrow.ArrowSize = 10;
            arrow.Height = 10;
            arrow.Width = 10;
            arrow.BackColor = Color.Red;
            arrow.ForeColor = Color.Red;
            arrow.AnchorOffsetY = 10;
            arrow.ArrowStyle = ArrowStyle.Simple;

                float xPixelPosition = (float)area_OHLC.AxisX.ValueToPixelPosition(candlestickPoint.XValue);
                float yPixelPosition = (float)area_OHLC.AxisY.ValueToPixelPosition(candlestickPoint.YValues[0]);

            arrow.AnchorDataPoint = candlestickPoint;
/*            arrow.X = 50;
            arrow.Y = 50;
*//*            arrow.AnchorDataPoint = candlestickPoint;
            arrow.X = xPixelPosition;
            arrow.Y = yPixelPosition;
*/
            return arrow;
        }

        // updates the candlesticks range when the 
        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            List<smartCandlestick> filteredCandlesticks = getCandlesticksInRange(allCandlesticks);
            candlesticks = new BindingList<smartCandlestick>(filteredCandlesticks);

            chart_stock.DataSource = candlesticks;
            chart_stock.DataBind();

            foreach (DataPoint candlestickPoint in series_OHLC.Points)
            {
                ArrowAnnotation arrow = makeArrow(candlestickPoint);
                chart_stock.Annotations.Add(arrow);
            }

/*            foreach (DataPoint candlestickPoint in series_OHLC.Points)
            {
                //TODO: must make a new arrow for each candlestick bruhhhh
                ArrowAnnotation arrowPoint = new ArrowAnnotation();
                float xPixelPosition = (float)area_OHLC.AxisX.ValueToPixelPosition(candlestickPoint.XValue);
                float yPixelPosition = (float)area_OHLC.AxisY.ValueToPixelPosition(candlestickPoint.YValues[0]);

                //arrow.AnchorDataPoint = candlestickPoint;
                DataPoint dataPoint = new DataPoint(xPixelPosition, yPixelPosition);
                chart_stock.Annotations.Add(arrowPoint);
                index++;
                break;
            }
*/            
        }
    }
}
