namespace COP4365_P2
{
    partial class Form_viewStock
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_endDate = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.button_updateStockDataGridView = new System.Windows.Forms.Button();
            this.chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_patterns = new System.Windows.Forms.ComboBox();
            this.label_patterns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(541, 438);
            this.dateTimePicker_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker_endDate.TabIndex = 18;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(582, 423);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(52, 13);
            this.label_endDate.TabIndex = 17;
            this.label_endDate.Text = "End Date";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(156, 423);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(55, 13);
            this.label_startDate.TabIndex = 16;
            this.label_startDate.Text = "Start Date";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(116, 438);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker_startDate.TabIndex = 15;
            this.dateTimePicker_startDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // button_updateStockDataGridView
            // 
            this.button_updateStockDataGridView.Location = new System.Drawing.Point(371, 402);
            this.button_updateStockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.button_updateStockDataGridView.Name = "button_updateStockDataGridView";
            this.button_updateStockDataGridView.Size = new System.Drawing.Size(91, 55);
            this.button_updateStockDataGridView.TabIndex = 19;
            this.button_updateStockDataGridView.Text = "Update Start & End Date";
            this.button_updateStockDataGridView.UseVisualStyleBackColor = true;
            this.button_updateStockDataGridView.Click += new System.EventHandler(this.button_updateStockDataGridView_Click);
            // 
            // chart_stock
            // 
            lineAnnotation1.EndCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            lineAnnotation1.Name = "testArrow";
            this.chart_stock.Annotations.Add(lineAnnotation1);
            chartArea1.AlignWithChartArea = "area_volume";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "area_OHLC";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "area_volume";
            this.chart_stock.ChartAreas.Add(chartArea1);
            this.chart_stock.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart_stock.Legends.Add(legend1);
            this.chart_stock.Location = new System.Drawing.Point(12, 12);
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
            this.chart_stock.Size = new System.Drawing.Size(709, 305);
            this.chart_stock.TabIndex = 20;
            this.chart_stock.Text = "chart_stock";
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP4365_P2.candlestick);
            // 
            // comboBox_patterns
            // 
            this.comboBox_patterns.FormattingEnabled = true;
            this.comboBox_patterns.Location = new System.Drawing.Point(600, 348);
            this.comboBox_patterns.Name = "comboBox_patterns";
            this.comboBox_patterns.Size = new System.Drawing.Size(121, 21);
            this.comboBox_patterns.TabIndex = 21;
            // 
            // label_patterns
            // 
            this.label_patterns.AutoSize = true;
            this.label_patterns.Location = new System.Drawing.Point(600, 332);
            this.label_patterns.Name = "label_patterns";
            this.label_patterns.Size = new System.Drawing.Size(72, 13);
            this.label_patterns.TabIndex = 22;
            this.label_patterns.Text = "View Patterns";
            // 
            // Form_viewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 471);
            this.Controls.Add(this.label_patterns);
            this.Controls.Add(this.comboBox_patterns);
            this.Controls.Add(this.chart_stock);
            this.Controls.Add(this.button_updateStockDataGridView);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_viewStock";
            this.Text = "Form_viewStock";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Button button_updateStockDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stock;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.ComboBox comboBox_patterns;
        private System.Windows.Forms.Label label_patterns;
    }
}