﻿using COP4365_P3.PatternRecognizers;
using COP4365_P3.PatternRecognizers.MultiCsPatternRecognizers;
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

namespace COP4365_P3
{

    // form class for viewing and interacting with stocks in a chart
    public partial class Form_viewStock : Form
    {
        string stockSymbol { get; set; }
        private BindingList<smartCandlestick> candlesticks;
        private List<smartCandlestick> allCandlesticks { get; set; }
        List<Recognizer> allRecognizers = new List<Recognizer>();

        Series series_OHLC;
        Series series_volume;
        ChartArea area_OHLC;
        ChartArea area_volume;

        DateTime startTime;
        DateTime endTime;
        // construct lists and chart components
        public Form_viewStock(string symbol, List<smartCandlestick> listOfCandlesticks, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            stockSymbol = symbol;
            this.Text = stockSymbol;

            allCandlesticks = new List<smartCandlestick>(1024);
            allCandlesticks = listOfCandlesticks;
            candlesticks = new BindingList<smartCandlestick>(allCandlesticks);
            chart_stock.DataSource = candlesticks;

            initChartProperties();
            addRecognizerItems();

            // add pattern name to combobox
            comboBox_patterns.Items.Add("None");
            foreach (Recognizer recognizer in allRecognizers)
            {
                comboBox_patterns.Items.Add(recognizer.patternName);
            }

            comboBox_patterns.SelectedIndex = 0;

            dateTimePicker_startDate.Value = startDate;
            dateTimePicker_endDate.Value = endDate;

            updateStockChart();
        }

        private void initChartProperties()
        {
            // initialize candlestick chart series
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
        }

        private void addRecognizerItems()
        {
            allRecognizers.Add(new BullishRecognizer());
            allRecognizers.Add(new BearishRecognizer());
            allRecognizers.Add(new NeutralRecognizer());
            allRecognizers.Add(new MarubozuRecognizer());
            allRecognizers.Add(new DojiRecognizer());
            allRecognizers.Add(new DragonFlyDojiRecognizer());
            allRecognizers.Add(new GravestoneDojiRecognizer());
            allRecognizers.Add(new HammerRecognizer());
            allRecognizers.Add(new InvertedHammerRecognizer());
            allRecognizers.Add(new BearishEngulfingRecognizer());
            allRecognizers.Add(new BullishEngulfingRecognizer());
            allRecognizers.Add(new BullishHaramiRecognizer());
            allRecognizers.Add(new BearishHaramiRecognizer());

            allRecognizers.Add(new PeakRecognizer());
            allRecognizers.Add(new ValleyRecognizer());
        }

        // filters out the candlesticks based on the date time picker
        private List<smartCandlestick> getCandlesticksInRange(List<smartCandlestick> tempList, DateTime startDate, DateTime endDate)
        {

            List<smartCandlestick> reversedTempList = new List<smartCandlestick>();
            tempList.Reverse();
            foreach (smartCandlestick candlestick in tempList)
            {
                if (candlestick.date < startDate)
                    break;

                if (candlestick.date <= endDate)
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
            startTime = dateTimePicker_startDate.Value;
            endTime = dateTimePicker_endDate.Value;
            List<smartCandlestick> filteredCandlesticks = getCandlesticksInRange(allCandlesticks, startTime, endTime);
            candlesticks = new BindingList<smartCandlestick>(filteredCandlesticks);

            chart_stock.DataSource = candlesticks;
            chart_stock.DataBind();
            chart_stock.Annotations.Clear();

            string selectedPattern = "is" + comboBox_patterns.SelectedItem.ToString();

            List<int> candlestickIndices = new List<int>();

            int selectedIndex = comboBox_patterns.SelectedIndex;
            // when pattern is None
            if (selectedIndex == 0) 
            {
                chart_stock.Annotations.Clear();
                return;
            }
            // when any other pattern
            else {
                selectedIndex--;
            }

            Recognizer selectedRecognizer = allRecognizers[selectedIndex];
            candlestickIndices = selectedRecognizer.Recognize(filteredCandlesticks);
            foreach (int index in candlestickIndices)
            {
                for (int subIndex = index; subIndex >= index - selectedRecognizer.patternSize + 1; subIndex--)
                {
                    DataPoint candlestickPoint = series_OHLC.Points[subIndex];
                    ArrowAnnotation arrow = makeArrow(candlestickPoint);
                    chart_stock.Annotations.Add(arrow);
                }

               // RectangleAnnotation rectangle = makeRectangle(index, selectedRecognizer.patternSize);
                //chart_stock.Annotations.Add(rectangle);
            }

            chart_stock.Invalidate();
        }

        // updates the candlesticks range and annotations
        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            updateStockChart();
        }

        // will automatically update the stocks and arrow annotations when the user changes the pattern selection
        private void comboBox_patterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStockChart();
        }

        // colors the candlesticks based on opening and closing values
        private void chart_stock_PrePaint(object sender, ChartPaintEventArgs e)
        {
            if (e.ChartElement == series_OHLC)
            {
                foreach (DataPoint dataPoint in series_OHLC.Points)
                {
                    // Change the color of the data point based on its open and close values
                    if (dataPoint.YValues[2] < dataPoint.YValues[3])
                    {
                        dataPoint.Color = Color.Green; // Green color for up days
                    }
                    else
                    {
                        dataPoint.Color = Color.Red; // Red color for down days
                    }
                }
            }
        }
    }
}
