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
        string stockSymbol {  get; set; }
        private BindingList<candlestick> candlesticks;
        private List<candlestick> allCandlesticks {  get; set; }
        Series series_OHLC;
        Series series_volume;
        ChartArea area_OHLC;
        ChartArea area_volume;

        // construct lists and chart components
        public Form_viewStock(string symbol, List<candlestick> listOfCandlesticks)
        {
            InitializeComponent();
            stockSymbol = symbol;
            allCandlesticks = new List<candlestick>(1024);

            this.Text = stockSymbol;


            // initialize candlestick chart series
            allCandlesticks = listOfCandlesticks;
            candlesticks = new BindingList<candlestick>(allCandlesticks);
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

            // newest candlestick objects on left first
            area_OHLC.AxisX.IsReversed = true;
            area_volume.AxisX.IsReversed = true;

            // keep price y-axis on the left
            area_OHLC.AxisY.Enabled = AxisEnabled.False;
            area_OHLC.AxisY2.Enabled = AxisEnabled.True;
            area_volume.AxisY.Enabled = AxisEnabled.False;
            area_volume.AxisY2.Enabled = AxisEnabled.True;

            // add axis titles
            area_OHLC.AxisX.Title = "Date";
            area_OHLC.AxisY2.Title = "Price";
            area_volume.AxisX.Title = "Date";
            area_volume.AxisY2.Title = "Volume";
        }

        // filters out the candlesticks based on the date time picker
        private List<candlestick> getCandlesticksInRange(List<candlestick> tempList)
        {

            List<candlestick> reversedTempList = new List<candlestick>();
            tempList.Reverse();
            foreach (candlestick candlestick in tempList)
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

        // updates the candlesticks range when the 
        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            List<candlestick> filteredCandlesticks = getCandlesticksInRange(allCandlesticks);
            candlesticks = new BindingList<candlestick>(filteredCandlesticks);

            chart_stock.DataSource = candlesticks;
            chart_stock.DataBind();
        }
    }
}
