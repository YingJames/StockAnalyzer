namespace COP4365_P2
{
    partial class Form_stockLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_stockLoader = new System.Windows.Forms.OpenFileDialog();
            this.button_loadStock = new System.Windows.Forms.Button();
            this.comboBox_stockSymbols = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_stockSymbols = new System.Windows.Forms.Label();
            this.label_periodTip = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_updateStockDataGridView = new System.Windows.Forms.Button();
            this.chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_chartZoomTip = new System.Windows.Forms.Label();
            this.button_resetZoom = new System.Windows.Forms.Button();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_stockLoader
            // 
            this.openFileDialog_stockLoader.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "cks|*-Month.csv";
            this.openFileDialog_stockLoader.Multiselect = true;
            this.openFileDialog_stockLoader.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_stockLoader_FileOk);
            // 
            // button_loadStock
            // 
            this.button_loadStock.Location = new System.Drawing.Point(195, 26);
            this.button_loadStock.Margin = new System.Windows.Forms.Padding(2);
            this.button_loadStock.Name = "button_loadStock";
            this.button_loadStock.Size = new System.Drawing.Size(103, 55);
            this.button_loadStock.TabIndex = 0;
            this.button_loadStock.Text = "Load OpenFileDialog";
            this.button_loadStock.UseVisualStyleBackColor = true;
            this.button_loadStock.Click += new System.EventHandler(this.button_openStockOnClick);
            // 
            // comboBox_stockSymbols
            // 
            this.comboBox_stockSymbols.FormattingEnabled = true;
            this.comboBox_stockSymbols.Location = new System.Drawing.Point(46, 26);
            this.comboBox_stockSymbols.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_stockSymbols.Name = "comboBox_stockSymbols";
            this.comboBox_stockSymbols.Size = new System.Drawing.Size(135, 21);
            this.comboBox_stockSymbols.TabIndex = 5;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(46, 67);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker_startDate.TabIndex = 6;
            this.dateTimePicker_startDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label_stockSymbols
            // 
            this.label_stockSymbols.AutoSize = true;
            this.label_stockSymbols.Location = new System.Drawing.Point(49, 11);
            this.label_stockSymbols.Name = "label_stockSymbols";
            this.label_stockSymbols.Size = new System.Drawing.Size(46, 13);
            this.label_stockSymbols.TabIndex = 10;
            this.label_stockSymbols.Text = "Symbols";
            // 
            // label_periodTip
            // 
            this.label_periodTip.AutoSize = true;
            this.label_periodTip.Location = new System.Drawing.Point(192, 11);
            this.label_periodTip.Name = "label_periodTip";
            this.label_periodTip.Size = new System.Drawing.Size(201, 13);
            this.label_periodTip.TabIndex = 11;
            this.label_periodTip.Text = "* Period can be set in the OpenFileDialog";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(49, 52);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(55, 13);
            this.label_startDate.TabIndex = 12;
            this.label_startDate.Text = "Start Date";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(49, 93);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(52, 13);
            this.label_endDate.TabIndex = 13;
            this.label_endDate.Text = "End Date";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(46, 108);
            this.dateTimePicker_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker_endDate.TabIndex = 14;
            // 
            // button_updateStockDataGridView
            // 
            this.button_updateStockDataGridView.Location = new System.Drawing.Point(302, 26);
            this.button_updateStockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.button_updateStockDataGridView.Name = "button_updateStockDataGridView";
            this.button_updateStockDataGridView.Size = new System.Drawing.Size(91, 55);
            this.button_updateStockDataGridView.TabIndex = 15;
            this.button_updateStockDataGridView.Text = "Update Start & End Date";
            this.button_updateStockDataGridView.UseVisualStyleBackColor = true;
            this.button_updateStockDataGridView.Click += new System.EventHandler(this.button_updateStockDataGridView_Click);
            // 
            // chart_stock
            // 
            chartArea1.AlignWithChartArea = "area_volume";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "area_OHLC";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "area_volume";
            this.chart_stock.ChartAreas.Add(chartArea1);
            this.chart_stock.ChartAreas.Add(chartArea2);
            this.chart_stock.DataSource = this.candlestickBindingSource;
            legend1.Name = "Legend1";
            this.chart_stock.Legends.Add(legend1);
            this.chart_stock.Location = new System.Drawing.Point(12, 221);
            this.chart_stock.Name = "chart_stock";
            series1.ChartArea = "area_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "series_OHLC";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "area_volume";
            series2.Legend = "Legend1";
            series2.Name = "series_volume";
            this.chart_stock.Series.Add(series1);
            this.chart_stock.Series.Add(series2);
            this.chart_stock.Size = new System.Drawing.Size(403, 141);
            this.chart_stock.TabIndex = 17;
            this.chart_stock.Text = "chart_stock";
            this.chart_stock.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart_stock_PrePaint);
            // 
            // label_chartZoomTip
            // 
            this.label_chartZoomTip.AutoSize = true;
            this.label_chartZoomTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chartZoomTip.Location = new System.Drawing.Point(20, 196);
            this.label_chartZoomTip.Name = "label_chartZoomTip";
            this.label_chartZoomTip.Size = new System.Drawing.Size(285, 20);
            this.label_chartZoomTip.TabIndex = 18;
            this.label_chartZoomTip.Text = "* Click and drag on the chart to zoom in";
            // 
            // button_resetZoom
            // 
            this.button_resetZoom.Location = new System.Drawing.Point(311, 174);
            this.button_resetZoom.Name = "button_resetZoom";
            this.button_resetZoom.Size = new System.Drawing.Size(95, 41);
            this.button_resetZoom.TabIndex = 19;
            this.button_resetZoom.Text = "Reset Chart Zoom";
            this.button_resetZoom.UseVisualStyleBackColor = true;
            this.button_resetZoom.Click += new System.EventHandler(this.button_resetZoom_Click);
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP4365_P2.candlestick);
            // 
            // Form_stockLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 383);
            this.Controls.Add(this.button_resetZoom);
            this.Controls.Add(this.label_chartZoomTip);
            this.Controls.Add(this.chart_stock);
            this.Controls.Add(this.button_updateStockDataGridView);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.label_periodTip);
            this.Controls.Add(this.label_stockSymbols);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.comboBox_stockSymbols);
            this.Controls.Add(this.button_loadStock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_stockLoader";
            this.Text = "Stock Loader";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_stockLoader;
        private System.Windows.Forms.Button button_loadStock;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.ComboBox comboBox_stockSymbols;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_stockSymbols;
        private System.Windows.Forms.Label label_periodTip;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_updateStockDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stock;
        private System.Windows.Forms.Label label_chartZoomTip;
        private System.Windows.Forms.Button button_resetZoom;
    }
}

