using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4365_P1
{
    // main form that the user will use to interact with candlesticks
    public partial class Form1 : Form
    {
        private BindingList<candlestick> candlesticks { get; set; }
        private string stockDataDirectory;
        private HashSet<string> stockSymbols;
        List<candlestick> tempList;

        // when constructing/loading the app, populate the symbol combobox with the symbols in the folder
        public Form1()
        {
            InitializeComponent();
            tempList = new List<candlestick>(1024);
            stockSymbols = new HashSet<string>(100);

            // fetch the directory of Stock Data
            string solutionDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo binDirectory = Directory.GetParent(solutionDirectory);
            string binDirectoryString = binDirectory.ToString();
            stockDataDirectory = Path.Combine(binDirectoryString, "Stock Data");

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
            listBox_period.SelectedIndex = 0;

        }


        // on the openFileDialog click, read the data of the chosen file
        private void button_openStockOnClick(object sender, EventArgs e)
        {
            openFileDialog_stockLoader.InitialDirectory = stockDataDirectory;

            // filter the files using the period
            int filterIndex = listBox_period.SelectedIndex+2;
            openFileDialog_stockLoader.FilterIndex = filterIndex;

            DialogResult result = openFileDialog_stockLoader.ShowDialog();
            if (result == DialogResult.OK)
            {
                String referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";
                String fileName = openFileDialog_stockLoader.FileName;
                Text = fileName;

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
                    if (header == referenceString)
                    {
                        
                        while ((line = sr.ReadLine()) != null)
                        {
                            // parse for the substrings and delimit with comma
                            candlestick candleStick = new candlestick(line);
                            tempList.Add(candleStick);
                        }
                        tempList.Reverse();

                        filterStock();
                    }

                }
            }
        }

        private void filterStock()
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

            // create the list of candlesticks we will bind to
            candlesticks = new BindingList<candlestick>();
            // connect the dataGridView to the list of candlesticks
            dataGridView_candlesticks.DataSource = candlesticks;
            foreach (candlestick candlestick in reversedTempList)
            {
                candlesticks.Add(candlestick);
            }
        }

        private void button_updateStockDataGridView_Click(object sender, EventArgs e)
        {
            filterStock();
        }
    }
}
