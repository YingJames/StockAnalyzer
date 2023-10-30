using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP4365_P2
{
    // form that will load the stocks from multiple files in to individual forms
    public partial class Form_stockLoader : Form
    {
        private static String referenceHeaderString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

        private BindingList<candlestick> candlesticks { get; set; }
        private string stockDataDirectory;
        private HashSet<string> stockSymbols;
        List<candlestick> tempList;
        Dictionary<String, List<candlestick>> multiSymbolTempList = new Dictionary<string, List<candlestick>>(100);

        Series series_OHLC;
        Series series_volume;
        ChartArea area_OHLC;
        ChartArea area_volume;

        // when constructing/loading the app, populate the symbol combobox with the symbols in the folder
        public Form_stockLoader()
        {
            InitializeComponent();
            tempList = new List<candlestick>(1024);
            //Dictionary<String, List<candlestick>> multiSymbolTempList = new Dictionary<string, List<candlestick>>(100);
            stockSymbols = new HashSet<string>(100);

            // initialize candlestick chart series
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

            // fetch the directory of Stock Data
            string executableDirectory = Directory.GetCurrentDirectory();
            string binDirectory = Directory.GetParent(executableDirectory).FullName;
            string projectDirectory = Directory.GetParent(binDirectory).FullName;
            string solutionDirectory = Directory.GetParent(projectDirectory).FullName;
            stockDataDirectory = Path.Combine(solutionDirectory, "Stock Data");

            // gets filename paths
            string[] fileNamePaths = Directory.GetFiles(stockDataDirectory);

            // Iterate through the array of filenames
            foreach (string filePath in fileNamePaths)
            {
                string fileName = Path.GetFileName(filePath);
                
                // only get symbol before '-' and prevent duplicates
                string[] splitFileName = fileName.Split('-');
                string symbol = splitFileName[0];
                stockSymbols.Add(symbol);
            }

            // add symbols to the stock symbols combobox
            foreach (string symbol in stockSymbols)
            {
                comboBox_stockSymbols.Items.Add(symbol);
            }
            comboBox_stockSymbols.SelectedIndex = 0;

        }


        // on the openFileDialog click, read the data of the chosen file
        private void button_openStockOnClick(object sender, EventArgs e)
        {
            openFileDialog_stockLoader.InitialDirectory = stockDataDirectory;
            // filter the files using stock symbol
            string stockSymbol = comboBox_stockSymbols.SelectedItem.ToString() + "*";
            openFileDialog_stockLoader.FileName = stockSymbol;

            DialogResult result = openFileDialog_stockLoader.ShowDialog();
         
        }

        // filters out the candlesticks based on the date time picker
        private List<candlestick> getCandlesticksInRange(List<candlestick> tempList)
        {
            
            List<candlestick> reversedTempList = new List<candlestick>();
            foreach(candlestick candlestick in tempList)
            {
                if (candlestick.date > dateTimePicker_endDate.Value)
                    break;

                if (candlestick.date >= dateTimePicker_startDate.Value)
                {
                    reversedTempList.Add(candlestick);
                }
            }

            reversedTempList.Reverse();
/*
            // create the list of candlesticks we will bind to
            candlesticks = new BindingList<candlestick>();
            // connect the dataGridView to the list of candlesticks
            dataGridView_candlesticks.DataSource = candlesticks;
            foreach (candlestick candlestick in reversedTempList)
            {
                candlesticks.Add(candlestick);
            }*/
            return reversedTempList;
        }

        // populates and updates the chart based on current candlesticks
        private void updateChartStock()
        {
            chart_stock.Titles.Clear();
            chart_stock.Titles.Add(Path.GetFileNameWithoutExtension(openFileDialog_stockLoader.FileName));

            chart_stock.DataSource = candlesticks;
            chart_stock.DataBind();
        }


        // changes the color of the candlesticks based on open close values before chart paint
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

        private List<candlestick> loadCandlesticks(string fileName)
        {
            List<candlestick> resultingList = new List<candlestick>(1024);

            // multiselect
            string[] filenames = openFileDialog_stockLoader.FileNames;

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                // read the header
                string header = sr.ReadLine();
                // Read and display lines from the file until the end of
                // the file is reached.

                // if the header is correct
                if (header == referenceHeaderString)
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        // parse for the substrings and delimit with comma
                        candlestick candleStick = new candlestick(line);
                        resultingList.Add(candleStick);
                    }
                    resultingList.Reverse();
                }
            }
            return resultingList;
        }


        // resets the chart areas zoom on click
        private void button_resetZoom_Click(object sender, EventArgs e)
        {
            area_OHLC.AxisX.ScaleView.ZoomReset();
            area_volume.AxisX.ScaleView.ZoomReset();
        }

        // helper function to trigger filterStock when the Update Button is clicked
        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            area_OHLC.AxisX.ScaleView.ZoomReset();
            area_volume.AxisX.ScaleView.ZoomReset();
            tempList = getCandlesticksInRange(tempList);
            //updateChartStock();
        }

        private void openFileDialog_stockLoader_FileOk(object sender, CancelEventArgs e)
        {
                //multiSymbolTempList = loadCandlesticks(openFileDialog_stockLoader.FileNames);
            foreach (string filePath in openFileDialog_stockLoader.FileNames)
            {
                tempList = loadCandlesticks(filePath);
                tempList = getCandlesticksInRange(tempList);

                string filename = Path.GetFileName(filePath);
                // only get symbol before '-' and prevent duplicates
                string[] splitFileName = filename.Split('.');
                filename = splitFileName[0];

                multiSymbolTempList.Add(filename, tempList);
            }
   
            //updateChartStock();

            foreach (string stockSymbol in multiSymbolTempList.Keys)
            {
                Form viewStockForm = new Form_viewStock(stockSymbol, multiSymbolTempList[stockSymbol]);
                //viewStockForm.Show(this);
                viewStockForm.Show();
            }
        }
    }
}
