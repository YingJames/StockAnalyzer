﻿namespace COP4365_P2
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
            this.dataGridView_candlesticks = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candlesticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).BeginInit();
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
            this.button_loadStock.Location = new System.Drawing.Point(1203, 32);
            this.button_loadStock.Name = "button_loadStock";
            this.button_loadStock.Size = new System.Drawing.Size(154, 85);
            this.button_loadStock.TabIndex = 0;
            this.button_loadStock.Text = "Load OpenFileDialog";
            this.button_loadStock.UseVisualStyleBackColor = true;
            this.button_loadStock.Click += new System.EventHandler(this.button_openStockOnClick);
            // 
            // dataGridView_candlesticks
            // 
            this.dataGridView_candlesticks.AllowUserToAddRows = false;
            this.dataGridView_candlesticks.AllowUserToDeleteRows = false;
            this.dataGridView_candlesticks.AutoGenerateColumns = false;
            this.dataGridView_candlesticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_candlesticks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView_candlesticks.DataSource = this.candlestickBindingSource;
            this.dataGridView_candlesticks.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_candlesticks.Name = "dataGridView_candlesticks";
            this.dataGridView_candlesticks.ReadOnly = true;
            this.dataGridView_candlesticks.RowHeadersWidth = 62;
            this.dataGridView_candlesticks.RowTemplate.Height = 28;
            this.dataGridView_candlesticks.Size = new System.Drawing.Size(974, 295);
            this.dataGridView_candlesticks.TabIndex = 3;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDataGridViewTextBoxColumn.Width = 150;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            this.highDataGridViewTextBoxColumn.Width = 150;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 150;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeDataGridViewTextBoxColumn.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP4365_P2.candlestick);
            // 
            // comboBox_stockSymbols
            // 
            this.comboBox_stockSymbols.FormattingEnabled = true;
            this.comboBox_stockSymbols.Location = new System.Drawing.Point(980, 32);
            this.comboBox_stockSymbols.Name = "comboBox_stockSymbols";
            this.comboBox_stockSymbols.Size = new System.Drawing.Size(200, 28);
            this.comboBox_stockSymbols.TabIndex = 5;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(980, 95);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_startDate.TabIndex = 6;
            this.dateTimePicker_startDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label_stockSymbols
            // 
            this.label_stockSymbols.AutoSize = true;
            this.label_stockSymbols.Location = new System.Drawing.Point(984, 9);
            this.label_stockSymbols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_stockSymbols.Name = "label_stockSymbols";
            this.label_stockSymbols.Size = new System.Drawing.Size(69, 20);
            this.label_stockSymbols.TabIndex = 10;
            this.label_stockSymbols.Text = "Symbols";
            // 
            // label_periodTip
            // 
            this.label_periodTip.AutoSize = true;
            this.label_periodTip.Location = new System.Drawing.Point(1198, 9);
            this.label_periodTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_periodTip.Name = "label_periodTip";
            this.label_periodTip.Size = new System.Drawing.Size(298, 20);
            this.label_periodTip.TabIndex = 11;
            this.label_periodTip.Text = "* Period can be set in the OpenFileDialog";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(984, 72);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(83, 20);
            this.label_startDate.TabIndex = 12;
            this.label_startDate.Text = "Start Date";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(984, 135);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(77, 20);
            this.label_endDate.TabIndex = 13;
            this.label_endDate.Text = "End Date";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(980, 158);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_endDate.TabIndex = 14;
            // 
            // button_updateStockDataGridView
            // 
            this.button_updateStockDataGridView.Location = new System.Drawing.Point(1364, 32);
            this.button_updateStockDataGridView.Name = "button_updateStockDataGridView";
            this.button_updateStockDataGridView.Size = new System.Drawing.Size(136, 85);
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
            this.chart_stock.Location = new System.Drawing.Point(0, 303);
            this.chart_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.chart_stock.Size = new System.Drawing.Size(1578, 643);
            this.chart_stock.TabIndex = 17;
            this.chart_stock.Text = "chart_stock";
            this.chart_stock.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart_stock_PrePaint);
            // 
            // label_chartZoomTip
            // 
            this.label_chartZoomTip.AutoSize = true;
            this.label_chartZoomTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chartZoomTip.Location = new System.Drawing.Point(982, 265);
            this.label_chartZoomTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chartZoomTip.Name = "label_chartZoomTip";
            this.label_chartZoomTip.Size = new System.Drawing.Size(429, 29);
            this.label_chartZoomTip.TabIndex = 18;
            this.label_chartZoomTip.Text = "* Click and drag on the chart to zoom in";
            // 
            // button_resetZoom
            // 
            this.button_resetZoom.Location = new System.Drawing.Point(1419, 231);
            this.button_resetZoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_resetZoom.Name = "button_resetZoom";
            this.button_resetZoom.Size = new System.Drawing.Size(142, 63);
            this.button_resetZoom.TabIndex = 19;
            this.button_resetZoom.Text = "Reset Chart Zoom";
            this.button_resetZoom.UseVisualStyleBackColor = true;
            this.button_resetZoom.Click += new System.EventHandler(this.button_resetZoom_Click);
            // 
            // Form_stockLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 965);
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
            this.Controls.Add(this.dataGridView_candlesticks);
            this.Controls.Add(this.button_loadStock);
            this.Name = "Form_stockLoader";
            this.Text = "Stock Loader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candlesticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_stockLoader;
        private System.Windows.Forms.Button button_loadStock;
        private System.Windows.Forms.DataGridView dataGridView_candlesticks;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
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
